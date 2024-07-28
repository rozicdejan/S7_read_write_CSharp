using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace WindowsFormsApp5
{
    public partial class MainForm : Form
    {
        private Plc _plc;

        public MainForm()
        {
            
            InitializeComponent();
            button1.MouseEnter += new EventHandler(button1_MouseEnter);
            button1.MouseLeave += new EventHandler(button1_MouseLeave);

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _plc = new Plc(CpuType.S71200, "192.168.33.100", 0, 1);
            try
            {
                _plc.Open();
                if (_plc.IsConnected)
                {
                    // Connection is successful, you can perform PLC operations here
                    MessageBox.Show("Connected to PLC.");
                }
                else
                {
                    MessageBox.Show("Failed to connect to PLC.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to PLC: {ex.Message}");
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_plc != null && _plc.IsConnected)
            {
                _plc.Close();
            }
            while (_plc.IsConnected)  { } 
            System.Windows.Forms.Application.Exit();

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
    }
}
