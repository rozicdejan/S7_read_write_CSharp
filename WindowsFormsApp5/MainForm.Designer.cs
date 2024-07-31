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
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tag100Label = new System.Windows.Forms.Label();
            this.tag101Label = new System.Windows.Forms.Label();
            this.tag102Label = new System.Windows.Forms.Label();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tag103Label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 956);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1921, 44);
            this.panel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.labelDateandTime);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1724, 0);
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
            this.panel2.Size = new System.Drawing.Size(1921, 10);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonOpenGrafana);
            this.panel3.Controls.Add(this.buttonNodeRedWeb);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 946);
            this.panel3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.gear_empty;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(142, 906);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 31);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1271, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(650, 946);
            this.panel5.TabIndex = 8;
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
            // tag100Label
            // 
            this.tag100Label.AutoSize = true;
            this.tag100Label.BackColor = System.Drawing.Color.Yellow;
            this.tag100Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tag100Label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag100Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tag100Label.Location = new System.Drawing.Point(668, 35);
            this.tag100Label.MinimumSize = new System.Drawing.Size(80, 60);
            this.tag100Label.Name = "tag100Label";
            this.tag100Label.Size = new System.Drawing.Size(80, 60);
            this.tag100Label.TabIndex = 2;
            this.tag100Label.Text = "label1";
            this.tag100Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tag101Label
            // 
            this.tag101Label.AutoSize = true;
            this.tag101Label.BackColor = System.Drawing.Color.Yellow;
            this.tag101Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tag101Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tag101Label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag101Label.Location = new System.Drawing.Point(668, 141);
            this.tag101Label.MinimumSize = new System.Drawing.Size(80, 60);
            this.tag101Label.Name = "tag101Label";
            this.tag101Label.Size = new System.Drawing.Size(80, 60);
            this.tag101Label.TabIndex = 3;
            this.tag101Label.Text = "label1";
            this.tag101Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tag102Label
            // 
            this.tag102Label.AutoSize = true;
            this.tag102Label.BackColor = System.Drawing.Color.Yellow;
            this.tag102Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tag102Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tag102Label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag102Label.Location = new System.Drawing.Point(668, 249);
            this.tag102Label.MinimumSize = new System.Drawing.Size(80, 60);
            this.tag102Label.Name = "tag102Label";
            this.tag102Label.Size = new System.Drawing.Size(80, 60);
            this.tag102Label.TabIndex = 4;
            this.tag102Label.Text = "label1";
            this.tag102Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temperatureChart
            // 
            this.temperatureChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.temperatureChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.temperatureChart.Legends.Add(legend1);
            this.temperatureChart.Location = new System.Drawing.Point(6, 657);
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
            this.temperatureChart.Size = new System.Drawing.Size(1071, 280);
            this.temperatureChart.TabIndex = 6;
            this.temperatureChart.Text = "chart1";
            title1.Name = "Temperature v sistemu [°C]";
            this.temperatureChart.Titles.Add(title1);
            this.temperatureChart.Click += new System.EventHandler(this.temperatureChart_Click);
            // 
            // tag103Label
            // 
            this.tag103Label.AutoSize = true;
            this.tag103Label.BackColor = System.Drawing.Color.Yellow;
            this.tag103Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tag103Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tag103Label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag103Label.Location = new System.Drawing.Point(668, 359);
            this.tag103Label.MinimumSize = new System.Drawing.Size(80, 60);
            this.tag103Label.Name = "tag103Label";
            this.tag103Label.Size = new System.Drawing.Size(80, 60);
            this.tag103Label.TabIndex = 5;
            this.tag103Label.Text = "label1";
            this.tag103Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.temperatureChart);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(186, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1085, 946);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.Strip_layout_of_multi_station_progressive_die_for_complex_automotive_structure_part;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(6, 483);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1071, 110);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.tag103Label);
            this.panel7.Controls.Add(this.tag100Label);
            this.panel7.Controls.Add(this.tag101Label);
            this.panel7.Controls.Add(this.tag102Label);
            this.panel7.Location = new System.Drawing.Point(6, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1071, 458);
            this.panel7.TabIndex = 8;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 250);
            this.label3.MinimumSize = new System.Drawing.Size(2, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 45);
            this.label3.TabIndex = 10;
            this.label3.Text = "Temperatura  okolice";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 141);
            this.label2.MinimumSize = new System.Drawing.Size(2, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 45);
            this.label2.TabIndex = 9;
            this.label2.Text = "Temperatura orodja #1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 35);
            this.label1.MinimumSize = new System.Drawing.Size(2, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "Temperatura orodja #1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.progressive_stamping_tool;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(35, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(445, 403);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 359);
            this.label4.MinimumSize = new System.Drawing.Size(2, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "Temperatura  okolice";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1921, 1000);
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
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOpenGrafana;
        private System.Windows.Forms.Button buttonNodeRedWeb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDateandTime;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label tag100Label;
        private System.Windows.Forms.Label tag101Label;
        private System.Windows.Forms.Label tag102Label;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperatureChart;
        private System.Windows.Forms.Label tag103Label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
    }
}