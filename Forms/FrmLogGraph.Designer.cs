
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.BSLChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbFilterDays = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BSLChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BSLChart
            // 
            chartArea3.Name = "ChartArea1";
            this.BSLChart.ChartAreas.Add(chartArea3);
            this.BSLChart.Location = new System.Drawing.Point(12, 114);
            this.BSLChart.Name = "BSLChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "BSL";
            this.BSLChart.Series.Add(series3);
            this.BSLChart.Size = new System.Drawing.Size(776, 324);
            this.BSLChart.TabIndex = 0;
            this.BSLChart.Text = "bslchart";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Position.Auto = false;
            title3.Position.Height = 90F;
            title3.Position.Width = 5F;
            title3.Text = "Blood Sugar Level";
            title3.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            this.BSLChart.Titles.Add(title3);
            
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
            // FrmLogGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilterDays);
            this.Controls.Add(this.BSLChart);
            this.Name = "FrmLogGraph";
            this.Text = "FrmLogGraph";
            this.Load += new System.EventHandler(this.FrmLogGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BSLChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BSLChart;
        private System.Windows.Forms.ComboBox cbFilterDays;
        private System.Windows.Forms.Label label1;
    }
}