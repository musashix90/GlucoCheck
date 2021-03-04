
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.BSLChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.BSLChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BSLChart
            // 
            chartArea1.Name = "ChartArea1";
            this.BSLChart.ChartAreas.Add(chartArea1);
            this.BSLChart.Location = new System.Drawing.Point(18, 36);
            this.BSLChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BSLChart.Name = "BSLChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "BSL";
            this.BSLChart.Series.Add(series1);
            this.BSLChart.Size = new System.Drawing.Size(1169, 648);
            this.BSLChart.TabIndex = 0;
            this.BSLChart.Text = "bslchart";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Position.Auto = false;
            title1.Position.Height = 90F;
            title1.Position.Width = 5F;
            title1.Text = "Blood Sugar Level";
            title1.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            this.BSLChart.Titles.Add(title1);
            this.BSLChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // FrmLogGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.BSLChart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLogGraph";
            this.Text = "FrmLogGraph";
            this.Load += new System.EventHandler(this.FrmLogGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BSLChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BSLChart;
    }
}