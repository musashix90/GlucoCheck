
namespace GlucoCheck.Forms
{
    partial class FrmLogGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.BSLChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbFilterDays = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rangeAverage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BSLChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BSLChart
            // 
            this.BSLChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.BSLChart.ChartAreas.Add(chartArea2);
            this.BSLChart.Location = new System.Drawing.Point(12, 114);
            this.BSLChart.Name = "BSLChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "BSL";
            this.BSLChart.Series.Add(series2);
            this.BSLChart.Size = new System.Drawing.Size(776, 324);
            this.BSLChart.TabIndex = 0;
            this.BSLChart.Text = "bslchart";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Position.Auto = false;
            title2.Position.Height = 90F;
            title2.Position.Width = 5F;
            title2.Text = "Blood Sugar Level";
            title2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            this.BSLChart.Titles.Add(title2);
            // 
            // cbFilterDays
            // 
            this.cbFilterDays.FormattingEnabled = true;
            this.cbFilterDays.Items.AddRange(new object[] {
            "Past 30 days...",
            "Past 60 days...",
            "Past 90 days..."});
            this.cbFilterDays.Location = new System.Drawing.Point(36, 73);
            this.cbFilterDays.Name = "cbFilterDays";
            this.cbFilterDays.Size = new System.Drawing.Size(121, 24);
            this.cbFilterDays.TabIndex = 1;
            this.cbFilterDays.SelectedIndexChanged += new System.EventHandler(this.cbFilterDays_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter by:";
            // 
            // rangeAverage
            // 
            this.rangeAverage.AutoSize = true;
            this.rangeAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeAverage.Location = new System.Drawing.Point(237, 61);
            this.rangeAverage.Name = "rangeAverage";
            this.rangeAverage.Size = new System.Drawing.Size(49, 36);
            this.rangeAverage.TabIndex = 3;
            this.rangeAverage.Text = "00";
            // 
            // FrmLogGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rangeAverage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilterDays);
            this.Controls.Add(this.BSLChart);
            this.Name = "FrmLogGraph";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlucoCheck - Log Graph";
            this.Load += new System.EventHandler(this.FrmLogGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BSLChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BSLChart;
        private System.Windows.Forms.ComboBox cbFilterDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rangeAverage;
    }
}