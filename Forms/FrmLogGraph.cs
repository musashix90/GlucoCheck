﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlucoCheck.Classes;
using System.Windows.Forms.DataVisualization.Charting;

namespace GlucoCheck.Forms
{
    public partial class FrmLogGraph : Form
    {
        public Settings Settings { get; set; }
        public User User { get; set; }

        public int userBSLHigh;
        public int userBSLLow;

        public FrmLogGraph()
        {
            InitializeComponent();
            // Set cbFilterDays to default text
            cbFilterDays.SelectedIndex = 0;
        }
        private void FrmLogGraph_Load(object sender, EventArgs e)
        {
            BSLChart.Series["BSL"].MarkerStyle = MarkerStyle.Circle;
            BSLChart.Series["BSL"].XValueType = ChartValueType.DateTime;

            // scroll / zoom settings
            BSLChart.ChartAreas["ChartArea1"].AxisX.ScrollBar.Enabled = true;
            BSLChart.ChartAreas["ChartArea1"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            BSLChart.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoom(DateTime.Now.AddDays(-7).ToOADate(), DateTime.Today.ToOADate());
            BSLChart.ChartAreas["ChartArea1"].AxisX.ScaleView.SmallScrollSizeType = DateTimeIntervalType.Weeks;

            // changed from DateTimeIntervalType.Days
            BSLChart.ChartAreas["ChartArea1"].AxisX.IntervalType = DateTimeIntervalType.Auto;
            BSLChart.ChartAreas["ChartArea1"].AxisX.IntervalOffset = 0;
            // This can be changed to include the time with "hh:mm"
            // however, when IntervalType = DateTimeIntervalType.Auto,
            // the label tends to show "yyyy-MM-dd 12:00" each interval
            BSLChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "yyyy-MM-dd";
            BSLChart.ChartAreas["ChartArea1"].AxisY.Minimum = 50;
            BSLChart.ChartAreas["ChartArea1"].AxisY.Maximum = 315;
            BSLChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            BSLChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Gainsboro;

            var fromDate = DateTime.Now.AddDays(-7);

            using (var db = new AppDbContext())
            {
                //foreach (var entry in db.Log.Where(l => l.EntryDate >= fromDate).OrderByDescending(l => l.Id)) {
                foreach (var entry in db.Log.OrderByDescending(l => l.Id)) {
                    DataPoint point = new DataPoint();
                    point.SetValueXY(entry.EntryDate, entry.BSL);
                    point.ToolTip = entry.EasyDate + " at " + entry.EasyTime + ", " + entry.BSL + "mg/dl";
                    BSLChart.Series["BSL"].Points.Add(point);
                }
            }

            userBSLHigh = (int)Settings.HighBSLThreshold;
            userBSLLow = (int)Settings.LowBSLThreshold;

            //Display Top and Bottom line for BSL user average
            StripLine HighLine = new StripLine();
            StripLine LowLine = new StripLine();
            LowLine.Interval = 0;
            LowLine.IntervalOffset = userBSLLow;
            LowLine.StripWidth = 1;
            LowLine.BackColor = Color.Red;
            BSLChart.ChartAreas["ChartArea1"].AxisY.StripLines.Add(LowLine);
            HighLine.Interval = 0;
            HighLine.IntervalOffset = userBSLHigh;
            HighLine.StripWidth = 1;
            HighLine.BackColor = Color.Red;
            BSLChart.ChartAreas["ChartArea1"].AxisY.StripLines.Add(HighLine);
        }

        private void cbFilterDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now.AddDays(1);
            BSLChart.ChartAreas["ChartArea1"].AxisX.Maximum = currentDate.ToOADate();
            DateTime minDate;
            int rangeSize = 0; //Used for calculating average percent 
            switch (cbFilterDays.SelectedIndex)
            {
                
                case 0:
                    Console.WriteLine("30 days selected");
                    minDate = currentDate.AddDays(-30);
                    BSLChart.ChartAreas["ChartArea1"].AxisX.Minimum = minDate.ToOADate();
                    
                    //BSLChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    break;
                case 1:
                    Console.WriteLine("60 days selected");
                    minDate = currentDate.AddDays(-60);
                    BSLChart.ChartAreas["ChartArea1"].AxisX.Minimum = minDate.ToOADate();
                    //BSLChart.ChartAreas["ChartArea1"].AxisX.Interval = 2;

                    rangeSize = 60;
                    break;
                case 2:
                    Console.WriteLine("90 days selected");
                    minDate = currentDate.AddDays(-90);
                    BSLChart.ChartAreas["ChartArea1"].AxisX.Minimum = minDate.ToOADate();
                    //BSLChart.ChartAreas["ChartArea1"].AxisX.Interval = 3;

                    rangeSize = 90;
                    break;
            }

            //Calculate in range average percent for selected day range.
            int pointCount = BSLChart.Series["BSL"].Points.Count;
            int cntDown = rangeSize;
            int cntInRange = 0;
            while (cntDown > 0 || pointCount >= 0)
            {
                double currentBSL = BSLChart.Series["BSL"].Points[pointCount].YValues[0];
                if (currentBSL >= userBSLLow && currentBSL <= userBSLHigh)
                {
                    cntInRange++;
                }
                pointCount--;
                cntDown--;
            }
            double percentInRange = (cntInRange / rangeSize) * 100;
            rangeAverage.Text = percentInRange.ToString();
        }
    }
}
