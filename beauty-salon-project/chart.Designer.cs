namespace beauty_salon_project
{
    partial class chart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chart));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.homePicBx = new System.Windows.Forms.PictureBox();
            this.BtnMonthly = new System.Windows.Forms.Button();
            this.BtnWeekly = new System.Windows.Forms.Button();
            this.BtnToday = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.homePicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // homePicBx
            // 
            this.homePicBx.Image = ((System.Drawing.Image)(resources.GetObject("homePicBx.Image")));
            this.homePicBx.Location = new System.Drawing.Point(12, 12);
            this.homePicBx.Name = "homePicBx";
            this.homePicBx.Size = new System.Drawing.Size(38, 41);
            this.homePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.homePicBx.TabIndex = 31;
            this.homePicBx.TabStop = false;
            this.homePicBx.Click += new System.EventHandler(this.homePicBx_Click);
            // 
            // BtnMonthly
            // 
            this.BtnMonthly.Location = new System.Drawing.Point(705, 315);
            this.BtnMonthly.Name = "BtnMonthly";
            this.BtnMonthly.Size = new System.Drawing.Size(85, 40);
            this.BtnMonthly.TabIndex = 28;
            this.BtnMonthly.Text = "ماهانه";
            this.BtnMonthly.UseVisualStyleBackColor = true;
            this.BtnMonthly.Click += new System.EventHandler(this.BtnMonthly_Click);
            // 
            // BtnWeekly
            // 
            this.BtnWeekly.Location = new System.Drawing.Point(705, 263);
            this.BtnWeekly.Name = "BtnWeekly";
            this.BtnWeekly.Size = new System.Drawing.Size(85, 40);
            this.BtnWeekly.TabIndex = 29;
            this.BtnWeekly.Text = "هفتگی";
            this.BtnWeekly.UseVisualStyleBackColor = true;
            this.BtnWeekly.Click += new System.EventHandler(this.BtnWeekly_Click);
            // 
            // BtnToday
            // 
            this.BtnToday.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnToday.Location = new System.Drawing.Point(705, 211);
            this.BtnToday.Name = "BtnToday";
            this.BtnToday.Size = new System.Drawing.Size(85, 40);
            this.BtnToday.TabIndex = 30;
            this.BtnToday.Text = "امروز";
            this.BtnToday.UseVisualStyleBackColor = false;
            this.BtnToday.Click += new System.EventHandler(this.BtnToday_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(79, 136);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(526, 295);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            // 
            // chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.homePicBx);
            this.Controls.Add(this.BtnMonthly);
            this.Controls.Add(this.BtnWeekly);
            this.Controls.Add(this.BtnToday);
            this.Name = "chart";
            this.Text = "chart";
            this.Load += new System.EventHandler(this.chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homePicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox homePicBx;
        private System.Windows.Forms.Button BtnMonthly;
        private System.Windows.Forms.Button BtnWeekly;
        private System.Windows.Forms.Button BtnToday;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}