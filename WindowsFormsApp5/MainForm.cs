using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace WindowsFormsApp5
{
    public partial class MainForm : Form
    {
        private Plc _plc;
        private CancellationTokenSource _cancellationTokenSource;
        private System.Windows.Forms.Timer timerClock;

        public MainForm()
        {
            InitializeComponent();
            button1.MouseEnter += new EventHandler(button1_MouseEnter);
            button1.MouseLeave += new EventHandler(button1_MouseLeave);

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);

            // Initialize and configure the timer for clock
            timerClock = new System.Windows.Forms.Timer();
            timerClock.Interval = 500; // .5 second
            timerClock.Tick += new EventHandler(this.timerClock_Tick);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize CancellationTokenSource
            _cancellationTokenSource = new CancellationTokenSource();

            // Update time in footer
            UpdateDateTime();
            timerClock.Start();

            try
            {
                await ReadDataFromPlcAsync(_cancellationTokenSource.Token);
            }
            catch (OperationCanceledException)
            {
                // Handle cancellation (if needed)
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Request cancellation
            _cancellationTokenSource?.Cancel();

            // Optionally, wait for ongoing tasks to finish
            // You might want to use a timeout here
            _cancellationTokenSource?.Dispose();

            // Ensure PLC is closed
            if (_plc != null && _plc.IsConnected)
            {
                _plc.Close();
            }
        }

        private async Task ReadDataFromPlcAsync(CancellationToken cancellationToken)
        {
            string ipAddress = GlobalData.PlcGlobalData.PLC_IP; // IP address of the PLC
            short rack = GlobalData.PlcGlobalData.PLC_RACK; // Typically, the main rack is numbered 0
            short slot = GlobalData.PlcGlobalData.PLC_POS; // Slot number where the CPU is installed
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
                        this.Invoke(new Action(() => DisplayData(data)));
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
                tag100Label.Text = data.Tag1.ToString();
                tag101Label.Text = data.Tag2.ToString();
                tag102Label.Text = data.Tag3.ToString();
                tag103Label.Text = data.Tag4.ToString();
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
    }
}
