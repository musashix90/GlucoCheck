using System;
using GlucoCheck.Classes;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace GlucoCheck.Forms
{
    public partial class FrmAddEntry : Form
    {
        #region Variables

        public User User { get; set; }
        public Settings settings { get; set; }

        #endregion

        public FrmAddEntry()
        {
            InitializeComponent();
        }

        #region Events

        private void FrmAddEntry_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            using (var db = new AppDbContext())
            {
                settings = db.Settings.Where(l => l.UserId == User.UserId).Single();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LogEntry entry = new LogEntry()
            {
                BSL = (int)NumUpDownCurrentBSL.Value,
                Carbs = (int)NumUpDownCarbs.Value,
                InsulinDosed = (float)NumUpDownInsulinDosed.Value,
                UserId = User.UserId
            };

            // Update the database with the current entry object
            using (var db = new AppDbContext())
            {
                var lastEntry = db.Log.Where(l => l.UserId.Equals(User.UserId)).OrderByDescending(l => l.Id).Take(1).SingleOrDefault();
                if (lastEntry == null || DateTime.Today != lastEntry.EntryDate.Date)
                {
                    Reminder rem2Hr = new Reminder(User.UserId, DateTime.Now.AddHours(settings.SecondEntryReminder), "REMINDER: It's time to do your 2nd reading.");
                    Reminder remDay = new Reminder(User.UserId, DateTime.Now.AddHours(settings.MaxDailyReminder), "REMINDER: It's time for your daily reading.");
                    db.Reminder.Add(rem2Hr);
                    db.Reminder.Add(remDay);
                }

                db.Log.Add(entry);
                db.SaveChanges();
            }

            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearchFoods_Click(object sender, EventArgs e)
        {
            FrmFoodSearch frmFoodSearch = new FrmFoodSearch();
            frmFoodSearch.ShowDialog();
        }

        #endregion

        #region Functions



        #endregion
    }
}