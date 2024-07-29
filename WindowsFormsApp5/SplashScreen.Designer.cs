namespace WindowsFormsApp5
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonCheckGoogle = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPlcPingStaus = new System.Windows.Forms.Label();
            this.labelPlcConnectionStatus = new System.Windows.Forms.Label();
            this.pictureBoxPlcPing = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlcConnectionstatus = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlcPing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlcConnectionstatus)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCheckGoogle
            // 
            this.buttonCheckGoogle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCheckGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCheckGoogle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCheckGoogle.Location = new System.Drawing.Point(553, 246);
            this.buttonCheckGoogle.Name = "buttonCheckGoogle";
            this.buttonCheckGoogle.Size = new System.Drawing.Size(104, 38);
            this.buttonCheckGoogle.TabIndex = 0;
            this.buttonCheckGoogle.Text = "PRIJAVA";
            this.buttonCheckGoogle.UseVisualStyleBackColor = false;
            this.buttonCheckGoogle.Click += new System.EventHandler(this.buttonCheckGoogle_Click_1);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelStatus.Location = new System.Drawing.Point(410, 421);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(201, 16);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Checking if device is accesible...";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 440);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 10);
            this.progressBar1.Step = 2;
            this.progressBar1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 440);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(399, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 440);
            this.panel2.TabIndex = 4;
            // 
            // labelPlcPingStaus
            // 
            this.labelPlcPingStaus.AutoSize = true;
            this.labelPlcPingStaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelPlcPingStaus.Location = new System.Drawing.Point(445, 374);
            this.labelPlcPingStaus.Name = "labelPlcPingStaus";
            this.labelPlcPingStaus.Size = new System.Drawing.Size(109, 16);
            this.labelPlcPingStaus.TabIndex = 5;
            this.labelPlcPingStaus.Text = "PLC ping status...";
            // 
            // labelPlcConnectionStatus
            // 
            this.labelPlcConnectionStatus.AutoSize = true;
            this.labelPlcConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelPlcConnectionStatus.Location = new System.Drawing.Point(445, 397);
            this.labelPlcConnectionStatus.Name = "labelPlcConnectionStatus";
            this.labelPlcConnectionStatus.Size = new System.Drawing.Size(148, 16);
            this.labelPlcConnectionStatus.TabIndex = 6;
            this.labelPlcConnectionStatus.Text = "PLC connection status...";
            // 
            // pictureBoxPlcPing
            // 
            this.pictureBoxPlcPing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlcPing.Location = new System.Drawing.Point(413, 371);
            this.pictureBoxPlcPing.Name = "pictureBoxPlcPing";
            this.pictureBoxPlcPing.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxPlcPing.TabIndex = 7;
            this.pictureBoxPlcPing.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(39, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxPlcConnectionstatus
            // 
            this.pictureBoxPlcConnectionstatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlcConnectionstatus.Location = new System.Drawing.Point(413, 393);
            this.pictureBoxPlcConnectionstatus.Name = "pictureBoxPlcConnectionstatus";
            this.pictureBoxPlcConnectionstatus.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxPlcConnectionstatus.TabIndex = 8;
            this.pictureBoxPlcConnectionstatus.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxPlcConnectionstatus);
            this.Controls.Add(this.pictureBoxPlcPing);
            this.Controls.Add(this.labelPlcConnectionStatus);
            this.Controls.Add(this.labelPlcPingStaus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonCheckGoogle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlcPing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlcConnectionstatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckGoogle;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPlcPingStaus;
        private System.Windows.Forms.Label labelPlcConnectionStatus;
        private System.Windows.Forms.PictureBox pictureBoxPlcPing;
        private System.Windows.Forms.PictureBox pictureBoxPlcConnectionstatus;
    }
}