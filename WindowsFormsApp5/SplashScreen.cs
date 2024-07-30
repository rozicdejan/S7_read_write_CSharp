using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using S7.Net;

namespace WindowsFormsApp5
{
    public partial class SplashScreen : Form
    {
        string ipaddr = Properties.Settings.Default.plcipAddr;
        public SplashScreen()
        {
            InitializeComponent();
            buttonCheckGoogle.Enabled = false;
            CheckConnections();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SplashScreen_FormClosing);
            timer2.Enabled = true;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            buttonCheckGoogle.Visible = false;
        }

        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Handle form closing event if needed
        }

        bool plcConnect;
        bool plcPingable;
        private async void CheckConnections()
        {
            bool googlePingable = await Task.Run(() => PingHost("google.com"));
            plcPingable = await Task.Run(() => PingHost("192.168.33.100"));

            bool isOnline = plcPingable;
            if (isOnline)
            {
                plcConnect = await Task.Run(() => TestPlcConnection());

                if (plcConnect)
                {
                    buttonCheckGoogle.Enabled = true;
                    labelStatus.Text = "WEB and PLC are reachable.";
                    buttonCheckGoogle.Visible = true;
                    progressBar1.Visible = false;
                }
            }
            else
            {
                labelStatus.Text = "WEB or PLC is not reachable.";
            }

            updateLabelStatus(labelPlcPingStaus, plcPingable, "PLC ping is OK", "PLC ping is NOT OK", pictureBoxPlcPing);
            updateLabelStatus(labelPlcConnectionStatus, plcConnect, "Connection to PLC is OK", "Connection to PLC is NOT OK", pictureBoxPlcConnectionstatus);
        }

        private void updateLabelStatus(Label label, bool isPingaable, string isPingableString, string isNotPinagleString, PictureBox picture)
        {
            if (isPingaable)
            {
                label.Text = isPingableString;
                label.ForeColor = GlobalData.mySpecialColor.ColorGreen;
                picture.BackgroundImage = Properties.Resources.OK;
            }
            else
            {
                label.Text = isNotPinagleString;
                label.ForeColor = Color.Red;
                picture.BackgroundImage = Properties.Resources.NOK;
            }
        }

        private async void PingGoogle()
        {
            bool pingable = await Task.Run(() => PingHost(ipaddr));
            if (pingable)
            {
                buttonCheckGoogle.Enabled = true;
                labelStatus.Text = "Device is reachable @ " + ipaddr;
            }
            else
            {
                labelStatus.Text = "Device is not reachable @ " + ipaddr;
            }
        }

        private bool PingHost(string host)
        {
            bool pingable = false;
            Ping pinger = null;
            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(host);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }
            return pingable;
        }

        private bool TestPlcConnection()
        {
            using (var plc = new Plc(CpuType.S71200, "192.168.33.100", 0, 1))
            {
                try
                {
                    plc.Open();
                    return plc.IsConnected;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        private void buttonCheckGoogle_Click(object sender, EventArgs e)
        {
            // Handle button click if needed
        }

        private void buttonCheckGoogle_Click_1(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 99)
            {
                progressBar1.Value = progressBar1.Value + 1;
            }

            if (progressBar1.Value == 99)
            {
                buttonCheckGoogle.Enabled = true;
                progressBar1.Visible = false;
                buttonCheckGoogle.Visible = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            CheckConnections();
        }
    }
}
