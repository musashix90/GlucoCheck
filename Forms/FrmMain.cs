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

namespace GlucoCheck.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RefreshLastEntry();
            InitializeTimer();
        }

        private void BtnNewEntry_Click(object sender, EventArgs e)
        {
            Form addEntry = new FrmAddEntry();
            addEntry.ShowDialog();
            RefreshLastEntry();
        }

        private void BtnViewGraph_Click(object sender, EventArgs e)
        {
            Form logGraph = new FrmLogGraph();
            logGraph.ShowDialog();
        }
        private void RefreshLastEntry()
        {
            using (var db = new AppDbContext())
            {
                var lastEntry = db.Log.OrderByDescending(l => l.Id).Take(1).SingleOrDefault();
                if (lastEntry != null)
                {
                    LblLastEntry.Text = lastEntry.BSL.ToString();
                    LblLastEntryDate.Text = lastEntry.EasyDate.ToString() + " at " + lastEntry.EasyTime.ToString();
                }
            }
        }

        private void InitializeTimer()
        {
            timer1.Interval = 10000;
            timer1.Tick += new EventHandler(TimerTick);
            timer1.Enabled = true;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            //LblLastEntry.Text += "a"; I wrote this line to make sure the timer worked
            // This is where code would go if I could figure out how to send a notification without everything breaking
        }
    }
}
