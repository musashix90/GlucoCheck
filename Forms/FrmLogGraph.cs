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
            BSLChart.ChartAreas["ChartArea1"].AxisX.IntervalType = DateTimeIntervalType.Auto;

            // This can be changed to include the time with "hh:mm"
            // however, when IntervalType = DateTimeIntervalType.Auto,
            // the label tends to show "yyyy-MM-dd 12:00" each interval
            BSLChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "yyyy-MM-dd";

            var fromDate = DateTime.Now.AddDays(-7);

            using (var db = new AppDbContext())
            {
                foreach (var entry in db.Log.Where(l => l.EntryDate >= fromDate).OrderByDescending(l => l.Id)) {
                    DataPoint point = new DataPoint();
                    point.SetValueXY(entry.EntryDate, entry.BSL);
                    point.ToolTip = entry.EasyDate + " at " + entry.EasyTime + ", " + entry.BSL + "mg/dl";
                    BSLChart.Series["BSL"].Points.Add(point);
                }
            }

            int userBSLHigh = 180;
            int userBSLLow = 130;

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
            DateTime currentDate = DateTime.Today;
            
            switch(cbFilterDays.SelectedIndex)
            {
                case 0:
                    Console.WriteLine("30 days selected");
      
                    break;
                case 1:
                    Console.WriteLine("60 days selected");
                    break;
                case 2:
                    Console.WriteLine("90 days selected");
                    break;
            }
        }
    }
}
