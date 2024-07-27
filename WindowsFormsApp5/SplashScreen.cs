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
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            buttonCheckGoogle.Enabled = false;
            PingGoogle();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private async void PingGoogle()
        {
            bool pingable = await Task.Run(() => PingHost("192.168.11.1"));
            if (pingable)
            {
                buttonCheckGoogle.Enabled = true;
                labelStatus.Text = "Google is reachable.";
            }
            else
            {
                labelStatus.Text = "Google is not reachable.";
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
        private void buttonCheckGoogle_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonCheckGoogle_Click_1(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (progressBar1.Value <99)
            {
                progressBar1.Value = progressBar1.Value + 1;
            }

            if (progressBar1.Value == 99)
            {
                buttonCheckGoogle.Enabled = true;
            }
        }
    }
}
