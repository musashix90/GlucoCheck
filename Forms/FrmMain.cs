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
        public static User user;
        public static Settings settings;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            AddOrFetchUser();
            CheckSettings();
            RefreshLastEntry();
            InitializeTimer();
        }

        private void BtnNewEntry_Click(object sender, EventArgs e)
        {
            FrmAddEntry addEntry = new FrmAddEntry();
            addEntry.User = user;
            addEntry.ShowDialog();
            RefreshLastEntry();
        }

        private void BtnViewGraph_Click(object sender, EventArgs e)
        {
            Form logGraph = new FrmLogGraph();
            logGraph.ShowDialog();
        }

        private void BtnViewLog_Click(object sender, EventArgs e)
        {
            Form logViewer = new FrmLogViewer();
            logViewer.ShowDialog();
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

        private void AddOrFetchUser()
        {
            using (var db = new AppDbContext())
            {
                if (db.User.Count() == 0)
                {
                    user = new User("New", "User", "", "", "", "", DateTime.Today, 0, 0);
                    db.User.Add(user);
                    db.SaveChanges();
                }
                else
                {
                    user = db.User.First();
                }
            }
        }

        private void CheckSettings()
        {
            using (var db = new AppDbContext())
            {
                if (db.Settings.Where(l => l.UserId == user.UserId).Count() == 0)
                {
                    FrmSettings frmSettings = new FrmSettings();
                    frmSettings.User = user;
                    frmSettings.ShowDialog();
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
            Form reminderBox = new FrmReminder("this is a placeholder reminder");
            reminderBox.ShowDialog();

            timer1.Interval = 600000; // I added this line to show the reminder every 10 minutes so that you won't get spammed with reminders. I leave it going to prove that it works
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.User = user;
            frmSettings.ShowDialog();
        }
    }
}
