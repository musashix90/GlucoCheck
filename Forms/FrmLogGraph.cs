using System;
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

            //Display Top and Bottom line for BSL user average
            StripLine HighLine = new StripLine();
            StripLine LowLine = new StripLine();
            LowLine.Interval = 0;
            LowLine.IntervalOffset = 100;//(Placeholder) This would be where users low range would go.
            LowLine.StripWidth = 1;
            LowLine.BackColor = Color.Red;
            BSLChart.ChartAreas["ChartArea1"].AxisY.StripLines.Add(LowLine);
            HighLine.Interval = 0;
            HighLine.IntervalOffset = 130;//(Placeholder) This would be where users high range would go.
            HighLine.StripWidth = 1;
            HighLine.BackColor = Color.Red;
            BSLChart.ChartAreas["ChartArea1"].AxisY.StripLines.Add(HighLine);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
