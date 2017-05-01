namespace Inventory_System
{
    partial class ProductStatistics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.statisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(128, 128);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // statisticsChart
            // 
            this.statisticsChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statisticsChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea";
            this.statisticsChart.ChartAreas.Add(chartArea1);
            this.statisticsChart.Location = new System.Drawing.Point(137, 3);
            this.statisticsChart.Name = "statisticsChart";
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Name = "Series";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.statisticsChart.Series.Add(series1);
            this.statisticsChart.Size = new System.Drawing.Size(227, 163);
            this.statisticsChart.TabIndex = 1;
            this.statisticsChart.Text = "chart1";
            this.statisticsChart.Click += new System.EventHandler(this.statisticsChart_Click);
            this.statisticsChart.MouseEnter += new System.EventHandler(this.statisticsChart_MouseEnter);
            this.statisticsChart.MouseLeave += new System.EventHandler(this.statisticsChart_MouseLeave);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(3, 134);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(128, 32);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            this.nameLabel.MouseEnter += new System.EventHandler(this.nameLabel_MouseEnter);
            this.nameLabel.MouseLeave += new System.EventHandler(this.nameLabel_MouseLeave);
            // 
            // ProductStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.statisticsChart);
            this.Controls.Add(this.pictureBox);
            this.Name = "ProductStatistics";
            this.Size = new System.Drawing.Size(367, 169);
            this.Click += new System.EventHandler(this.ProductStatistics_Click);
            this.MouseEnter += new System.EventHandler(this.ProductStatistics_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ProductStatistics_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticsChart;
        private System.Windows.Forms.Label nameLabel;
    }
}
