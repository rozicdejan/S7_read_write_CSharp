namespace WindowsFormsApp5
{
    partial class MainForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOpenGrafana = new System.Windows.Forms.Button();
            this.buttonNodeRedWeb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 127);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.gear_empty;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(92, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 182);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOpenGrafana
            // 
            this.buttonOpenGrafana.Location = new System.Drawing.Point(503, 12);
            this.buttonOpenGrafana.Name = "buttonOpenGrafana";
            this.buttonOpenGrafana.Size = new System.Drawing.Size(106, 35);
            this.buttonOpenGrafana.TabIndex = 2;
            this.buttonOpenGrafana.Text = "Grafana WEB";
            this.buttonOpenGrafana.UseVisualStyleBackColor = true;
            this.buttonOpenGrafana.Click += new System.EventHandler(this.buttonOpenGrafana_Click);
            // 
            // buttonNodeRedWeb
            // 
            this.buttonNodeRedWeb.Location = new System.Drawing.Point(503, 53);
            this.buttonNodeRedWeb.Name = "buttonNodeRedWeb";
            this.buttonNodeRedWeb.Size = new System.Drawing.Size(106, 35);
            this.buttonNodeRedWeb.TabIndex = 3;
            this.buttonNodeRedWeb.Text = "NodeRed WEB";
            this.buttonNodeRedWeb.UseVisualStyleBackColor = true;
            this.buttonNodeRedWeb.Click += new System.EventHandler(this.buttonNodeRedWeb_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNodeRedWeb);
            this.Controls.Add(this.buttonOpenGrafana);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonOpenGrafana;
        private System.Windows.Forms.Button buttonNodeRedWeb;
    }
}