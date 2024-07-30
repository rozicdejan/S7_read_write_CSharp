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
        private System.Windows.Forms.Timer timerClock;
        private CancellationTokenSource _cancellationTokenSource;

        public MainForm()
        {
            InitializeComponent();
            button1.MouseEnter += new EventHandler(button1_MouseEnter);
            button1.MouseLeave += new EventHandler(button1_MouseLeave);

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);

            // Initialize and configure the timer for clock
            timerClock = new System.Windows.Forms.Timer();
            timerClock.Interval = 500; // 0.5 second
            timerClock.Tick += new EventHandler(this.timerClock_Tick);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            // Update time in footer
            UpdateDateTime();
            timerClock.Start();

            // Initialize PLC connection
            string ipAddress = GlobalData.PlcGlobalData.PLC_IP;
            short rack = GlobalData.PlcGlobalData.PLC_RACK;
            short slot = GlobalData.PlcGlobalData.PLC_POS;

            _plc = new Plc(CpuType.S71200, ipAddress, rack, slot);

            try
            {
                _plc.Open();
                if (_plc.IsConnected)
                {
                    // Connection is successful, start reading data
                    MessageBox.Show("Connected to PLC. @" + ipAddress);

                    _cancellationTokenSource = new CancellationTokenSource();
                    await StartReadingDataAsync(_cancellationTokenSource.Token);
                }
                else
                {
                    MessageBox.Show("Failed to connect to PLC. - Check PLC IP");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to PLC: {ex.Message}");
            }
        }

        private async Task StartReadingDataAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                await ReadDataFromPlcAsync();
                await Task.Delay(1000, cancellationToken); // Wait for 1 second
            }
        }

        private async Task ReadDataFromPlcAsync()
        {
            try
            {
                if (_plc.IsConnected)
                {
                    // Read the data from DB1, starting at offset 0
                    GlobalData.PlcDataRead data = _plc.ReadClass<GlobalData.PlcDataRead>(1, 0);

                    // Display the read data
                    DisplayData(data);
                }
                else
                {
                    MessageBox.Show("PLC is not connected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data: " + ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel the background task
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
            }

            // Ensure the connection is closed
            if (_plc != null && _plc.IsConnected)
            {
                _plc.Close();
            }

            // Allow the form to close normally
            e.Cancel = false;
            Application.Exit();
        }

        private void DisplayData(GlobalData.PlcDataRead data)
        {
            // Display the data on your form (e.g., in text boxes or labels)
            tag100Label.Text = data.Tag1.ToString();
            tag101Label.Text = data.Tag2.ToString();
            tag102Label.Text = data.Tag3.ToString();
            tag103Label.Text = data.Tag4.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e) { }

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

        private void panel4_Paint(object sender, PaintEventArgs e) { }

        // SYSTEM CLOCK SHOW
        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            labelDateandTime.Text = DateTime.Now.ToString("d-M-yyyy HH:mm");
        }
    }
}
