using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using S7.Net;
using Newtonsoft.Json;

namespace WindowsFormsApp5
{
    public partial class MainForm : Form
    {
        private Plc _plc;
        private CancellationTokenSource _cancellationTokenSource;
        private System.Windows.Forms.Timer timerClock;

        //public object JsonConvert { get; private set; }

        public MainForm()
        {
           // InitializeChart();
            InitializeComponent();
            SetupChart();
            button1.MouseEnter += new EventHandler(button1_MouseEnter);
            button1.MouseLeave += new EventHandler(button1_MouseLeave);

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);

            // Initialize and configure the timer for clock
            timerClock = new System.Windows.Forms.Timer();
            timerClock.Interval = 500; // .5 second
            timerClock.Tick += new EventHandler(this.timerClock_Tick);
            
        }
        private void SetupChart()
        {

            // Configure the existing chart
            var chartArea = temperatureChart.ChartAreas[0];
            chartArea.AxisX.Title = "Time";
            chartArea.AxisY.Title = "Temperature (°C)";

            // Set X-Axis to DateTime
            chartArea.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Minutes;
            chartArea.AxisX.Interval = 10;
            chartArea.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;


            // Configure each series
            foreach (var series in temperatureChart.Series)
            {
                series.ChartType = SeriesChartType.Line;
                //series.Color = System.Drawing.Color.White; // Change the series color as needed
                series.BorderWidth = 2; // Make the series lines bold
            }

        }
        public class ChartDataPoint
        {
            public string SeriesName { get; set; }
            public DateTime XValue { get; set; }
            public double YValue { get; set; }
        }

        private void SaveChartData()
        {
            List<ChartDataPoint> dataPoints = new List<ChartDataPoint>();

            foreach (var series in temperatureChart.Series)
            {
                foreach (var point in series.Points)
                {
                    dataPoints.Add(new ChartDataPoint
                    {
                        SeriesName = series.Name,
                        XValue = DateTime.FromOADate(point.XValue),
                        YValue = point.YValues[0]
                    });
                }
            }

            string filePath = "chartData.json";
            File.WriteAllText(filePath, JsonConvert.SerializeObject(dataPoints));
        }
        private void LoadChartData()
        {
            string filePath = "chartData.json";
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                var dataPoints = JsonConvert.DeserializeObject<List<ChartDataPoint>>(jsonData);

                temperatureChart.Series["Tag1"].Points.Clear();
                temperatureChart.Series["Tag2"].Points.Clear();
                temperatureChart.Series["Tag3"].Points.Clear();

                foreach (var dataPoint in dataPoints)
                {
                    temperatureChart.Series[dataPoint.SeriesName].Points.AddXY(dataPoint.XValue, dataPoint.YValue);
                }

                temperatureChart.ChartAreas[0].RecalculateAxesScale();
                temperatureChart.Update();
            }
        }




        private async void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize CancellationTokenSource
            _cancellationTokenSource = new CancellationTokenSource();

            // Update time in footer
            UpdateDateTime();
            timerClock.Start();

            LoadChartData();


            try
            {
                await ReadDataFromPlcAsync(_cancellationTokenSource.Token);
            }
            catch (OperationCanceledException)
            {
                // Handle cancellation if needed
            }
            catch (Exception ex)
            {
                // Handle any other exceptions if needed
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            // Request cancellation
            //_cancellationTokenSource?.Cancel();

            // Stop the timer
            timerClock.Stop();

            // Ensure PLC is closed
            if (_plc != null && _plc.IsConnected)
            {
                _plc.Close();
            }
            SaveChartData();
            // Clean up background tasks
            _cancellationTokenSource?.Dispose();

            // Allow time for the tasks to cancel
            //Task.Delay(500).Wait();
            Application.Exit();
        }

        private async Task ReadDataFromPlcAsync(CancellationToken cancellationToken)
        {
            string ipAddress = GlobalData.PlcGlobalData.PLC_IP;
            short rack = GlobalData.PlcGlobalData.PLC_RACK;
            short slot = GlobalData.PlcGlobalData.PLC_POS;
            int timeoutMilliseconds = 3000; // 3 seconds

            Plc plc = new Plc(CpuType.S71200, ipAddress, rack, slot);
            _plc = plc;

            try
            {
                // Open PLC connection
                await Task.Run(() => plc.Open(), cancellationToken);

                if (!plc.IsConnected)
                {
                    throw new Exception("Failed to connect to PLC.");
                }

                while (!cancellationToken.IsCancellationRequested)
                {
                    // Perform PLC read operation
                    var data = plc.ReadClass<GlobalData.PlcDataRead>(1, 0);

                    // Update the UI with the data if the form is not disposed
                    if (!IsDisposed)
                    {
                        this.Invoke(new Action(() =>
                        {
                            DisplayData(data);
                            UpdateChart(data);
                        }));
                    }

                    // Wait for a short period before the next read
                    await Task.Delay(1000, cancellationToken);
                }
            }
            catch (OperationCanceledException)
            {
                // Handle task cancellation
            }
            catch (Exception ex)
            {
                // Handle errors
                if (!IsDisposed)
                {
                    this.Invoke(new Action(() => MessageBox.Show("Error reading data: " + ex.Message)));
                }
            }
            finally
            {
                // Ensure the connection is closed
                if (plc.IsConnected)
                {
                    plc.Close();
                }
            }
        }

        private void DisplayData(GlobalData.PlcDataRead data)
        {
            // Display the data on your form (e.g., in text boxes or labels)
            if (!IsDisposed)
            {
                tag100Label.Text = data.Tag1.ToString() + " °C";
                tag101Label.Text = data.Tag2.ToString() + " °C";
                tag102Label.Text = data.Tag3.ToString() + " °C";
                tag103Label.Text = data.Tag4.ToString() + " °C";
                //tag5Label.Text = data.Tag5.ToString();
                //tag6CheckBox.Checked = data.Tag6;
                //tag7CheckBox.Checked = data.Tag7;
                //tag8Label.Text = data.Tag8.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gear_empty));
        }

        void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gear_full1));
        }

        private void buttonOpenGrafana_Click(object sender, EventArgs e)
        {
            GlobalFunctions.OpenBrowser_webpage(GlobalData.WebPageAdresses.GrafanaWebPageAdress);
        }

        private void buttonNodeRedWeb_Click(object sender, EventArgs e)
        {
            GlobalFunctions.OpenBrowser_webpage(GlobalData.WebPageAdresses.NodeRedaWebPageAdress);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        // SYSTEM CLOCK SHOW
        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            if (!IsDisposed)
            {
                labelDateandTime.Text = DateTime.Now.ToString("d-M-yyyy HH:mm");
            }
        }

        private void InitializeChart()
        {
            
          temperatureChart = new Chart();
          temperatureChart.Dock = DockStyle.Fill;
          this.Controls.Add(temperatureChart);

         ChartArea chartArea = new ChartArea();
         temperatureChart.ChartAreas.Add(chartArea);

         Series series1 = new Series("Tag1");
         series1.ChartType = SeriesChartType.Line;
         temperatureChart.Series.Add(series1);

         Series series2 = new Series("Tag2");
         series2.ChartType = SeriesChartType.Line;
         temperatureChart.Series.Add(series2);

         Series series3 = new Series("Tag3");
         series3.ChartType = SeriesChartType.Line;
         temperatureChart.Series.Add(series3);

            // Set X-Axis to DateTime
            //temperatureChart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            //temperatureChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            //temperatureChart.ChartAreas[0].AxisX.Interval = 1;
           // temperatureChart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
           // temperatureChart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
        }
        private void UpdateChart(GlobalData.PlcDataRead data)
        {
            DateTime now = DateTime.Now;

            // Add new data points
            temperatureChart.Series["Tag1"].Points.AddXY(now, data.Tag1);
            temperatureChart.Series["Tag2"].Points.AddXY(now, data.Tag2);
            temperatureChart.Series["Tag3"].Points.AddXY(now, data.Tag3);

            // Keep the chart with a fixed number of points to avoid performance issues
            int maxPoints = 1800;
            foreach (var series in temperatureChart.Series)
            {
                while (series.Points.Count > maxPoints)
                {
                    series.Points.RemoveAt(0);
                }
            }

            // Adjust the X-axis to scroll with the data
            var chartArea = temperatureChart.ChartAreas[0];
            chartArea.AxisX.Minimum = DateTime.Now.AddSeconds(-maxPoints).ToOADate();
            chartArea.AxisX.Maximum = DateTime.Now.ToOADate();

            temperatureChart.ChartAreas[0].RecalculateAxesScale(); // Ensure axis scales are updated
            temperatureChart.Update(); // Redraw the chart smoothly
        }

        private void temperatureChart_Click(object sender, EventArgs e)
        {

        }
    }
}
