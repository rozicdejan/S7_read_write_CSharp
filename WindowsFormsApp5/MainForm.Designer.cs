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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.buttonOpenGrafana = new System.Windows.Forms.Button();
            this.buttonNodeRedWeb = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelDateandTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tag103Label = new System.Windows.Forms.Label();
            this.tag102Label = new System.Windows.Forms.Label();
            this.tag101Label = new System.Windows.Forms.Label();
            this.tag100Label = new System.Windows.Forms.Label();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenGrafana
            // 
            this.buttonOpenGrafana.Location = new System.Drawing.Point(12, 6);
            this.buttonOpenGrafana.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenGrafana.Name = "buttonOpenGrafana";
            this.buttonOpenGrafana.Size = new System.Drawing.Size(165, 58);
            this.buttonOpenGrafana.TabIndex = 2;
            this.buttonOpenGrafana.Text = "Grafana WEB";
            this.buttonOpenGrafana.UseVisualStyleBackColor = true;
            this.buttonOpenGrafana.Click += new System.EventHandler(this.buttonOpenGrafana_Click);
            // 
            // buttonNodeRedWeb
            // 
            this.buttonNodeRedWeb.Location = new System.Drawing.Point(12, 71);
            this.buttonNodeRedWeb.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNodeRedWeb.Name = "buttonNodeRedWeb";
            this.buttonNodeRedWeb.Size = new System.Drawing.Size(165, 59);
            this.buttonNodeRedWeb.TabIndex = 3;
            this.buttonNodeRedWeb.Text = "NodeRed WEB";
            this.buttonNodeRedWeb.UseVisualStyleBackColor = true;
            this.buttonNodeRedWeb.Click += new System.EventHandler(this.buttonNodeRedWeb_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(0, 718);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1369, 44);
            this.panel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.labelDateandTime);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1172, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 44);
            this.panel6.TabIndex = 2;
            // 
            // labelDateandTime
            // 
            this.labelDateandTime.AutoSize = true;
            this.labelDateandTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateandTime.Location = new System.Drawing.Point(35, 14);
            this.labelDateandTime.Name = "labelDateandTime";
            this.labelDateandTime.Size = new System.Drawing.Size(106, 16);
            this.labelDateandTime.TabIndex = 1;
            this.labelDateandTime.Text = "##-##-#### ##:##";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.dafra_logo_noDAFRA;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(154, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1369, 10);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonOpenGrafana);
            this.panel3.Controls.Add(this.buttonNodeRedWeb);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 708);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tag103Label);
            this.panel4.Controls.Add(this.temperatureChart);
            this.panel4.Controls.Add(this.tag102Label);
            this.panel4.Controls.Add(this.tag101Label);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.tag100Label);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(186, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(837, 708);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.gear_empty;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(96, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 224);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tag103Label
            // 
            this.tag103Label.AutoSize = true;
            this.tag103Label.Location = new System.Drawing.Point(47, 93);
            this.tag103Label.Name = "tag103Label";
            this.tag103Label.Size = new System.Drawing.Size(45, 16);
            this.tag103Label.TabIndex = 5;
            this.tag103Label.Text = "label1";
            // 
            // tag102Label
            // 
            this.tag102Label.AutoSize = true;
            this.tag102Label.Location = new System.Drawing.Point(47, 71);
            this.tag102Label.Name = "tag102Label";
            this.tag102Label.Size = new System.Drawing.Size(45, 16);
            this.tag102Label.TabIndex = 4;
            this.tag102Label.Text = "label1";
            // 
            // tag101Label
            // 
            this.tag101Label.AutoSize = true;
            this.tag101Label.Location = new System.Drawing.Point(47, 50);
            this.tag101Label.Name = "tag101Label";
            this.tag101Label.Size = new System.Drawing.Size(45, 16);
            this.tag101Label.TabIndex = 3;
            this.tag101Label.Text = "label1";
            // 
            // tag100Label
            // 
            this.tag100Label.AutoSize = true;
            this.tag100Label.Location = new System.Drawing.Point(47, 29);
            this.tag100Label.Name = "tag100Label";
            this.tag100Label.Size = new System.Drawing.Size(45, 16);
            this.tag100Label.TabIndex = 2;
            this.tag100Label.Text = "label1";
            // 
            // temperatureChart
            // 
            chartArea1.Name = "ChartArea1";
            this.temperatureChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.temperatureChart.Legends.Add(legend1);
            this.temperatureChart.Location = new System.Drawing.Point(27, 376);
            this.temperatureChart.Name = "temperatureChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Tag1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Tag2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Tag3";
            this.temperatureChart.Series.Add(series1);
            this.temperatureChart.Series.Add(series2);
            this.temperatureChart.Series.Add(series3);
            this.temperatureChart.Size = new System.Drawing.Size(750, 280);
            this.temperatureChart.TabIndex = 6;
            this.temperatureChart.Text = "chart1";
            title1.Name = "Temperature v sistemu [°C]";
            this.temperatureChart.Titles.Add(title1);
            this.temperatureChart.Click += new System.EventHandler(this.temperatureChart_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.gear_empty;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(75, 72);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(327, 224);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1023, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(346, 708);
            this.panel5.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 762);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOpenGrafana;
        private System.Windows.Forms.Button buttonNodeRedWeb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDateandTime;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label tag103Label;
        private System.Windows.Forms.Label tag102Label;
        private System.Windows.Forms.Label tag101Label;
        private System.Windows.Forms.Label tag100Label;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperatureChart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
    }
}