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
        public User user = null;
        public static Settings settings = new Settings();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
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
            FrmLogGraph logGraph = new FrmLogGraph();
            logGraph.User = user;
            logGraph.Settings = settings;
            logGraph.ShowDialog();
        }

        private void BtnViewLog_Click(object sender, EventArgs e)
        {
            FrmLogViewer logViewer = new FrmLogViewer();
            logViewer.user = user;
            logViewer.ShowDialog();
        }

        private void RefreshLastEntry()
        {
            using (var db = new AppDbContext())
            {
                var lastEntry = db.Log.Where(l => l.UserId.Equals(user.UserId)).OrderByDescending(l => l.Id).Take(1).SingleOrDefault();
                if (lastEntry != null)
                {
                    double lastBSL = lastEntry.BSL;
                    string measurement = "mg/dL";
                    if (settings.IsMillimoles)
                    {
                        lastBSL /= 18;
                        lastBSL = Math.Round(lastBSL, 1);

                        measurement = "mmol/L";
                    }
                    LblLastEntry.Text = lastBSL.ToString() + " " + measurement;
                    LblLastEntryDate.Text = lastEntry.EasyDate.ToString() + " at " + lastEntry.EasyTime.ToString();
                }
            }
        }

        private void CheckSettings()
        {
            using (var db = new AppDbContext())
            {
                if (db.Settings.Where(l => l.UserId.Equals(user.UserId)).Count() == 0)
                {
                    MessageBox.Show("Please update your settings before proceeding.");
                    FrmSettings frmSettings = new FrmSettings();
                    frmSettings.User = user;
                    frmSettings.settings = settings;
                    frmSettings.ShowDialog();
                }
                else
                {
                    settings = db.Settings.Where(l => l.UserId == user.UserId).Single();
                }
            }
        }

        private void InitializeTimer()
        {
            timer1.Interval = 5000;
            timer1.Tick += new EventHandler(TimerTick);
            timer1.Enabled = true;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                if (db.Reminder.Where(l => l.UserId.Equals(user.UserId)).OrderBy(l => l.TimeToRemind).Take(1).SingleOrDefault() == null) return;
                var nextReminder = db.Reminder.Where(l => l.UserId.Equals(user.UserId)).OrderBy(l => l.TimeToRemind).First();

                if (DateTime.Compare(nextReminder.TimeToRemind, DateTime.Now) < 0)
                {
                    db.Reminder.Remove(nextReminder);
                    db.SaveChanges();
                    Form reminderBox = new FrmReminder(nextReminder.TaskToRemind);
                    reminderBox.ShowDialog();
                }
            }
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.User = user;
            frmSettings.settings = settings;
            frmSettings.ShowDialog();
            CheckSettings();
            RefreshLastEntry();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FrmFoodSearch frmFoodSearch = new FrmFoodSearch();
            frmFoodSearch.ShowDialog();
        }

        // Button Mouse Hover events.
        private void BtnNewEntry_MouseHover(object sender, EventArgs e)
        {
            lblInfo.Text = "*Create a new log entry to be added to your table.";
        }

        private void BtnViewGraph_MouseHover(object sender, EventArgs e)
        {
            lblInfo.Text = "*View a trend graph that tracks your progress.";
        }

        private void BtnViewLog_MouseHover(object sender, EventArgs e)
        {
            lblInfo.Text = "*View all your entries in a table format.";
        }

        private void SettingsBtn_MouseHover(object sender, EventArgs e)
        {
            lblInfo.Text = "*Edit your personalized application settings.";
        }

        private void BtnSearch_MouseHover(object sender, EventArgs e)
        {
            lblInfo.Text = "*Search for foods that are perfect for you.";
        }

        private void Buttons_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }
    }
}
