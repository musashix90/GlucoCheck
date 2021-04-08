using GlucoCheck.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlucoCheck.Forms
{
    public partial class FrmSettings : Form
    {
        public Settings settings { get; set; }
        public User User { get; set; }

        public FrmSettings()
        {
            settings = new Settings();

            InitializeComponent();

        }

        public FrmSettings(Settings existingSettings)
        {
            settings = existingSettings;

            InitializeComponent();

        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            HighThresholdTextBox.Text = settings.IsMillimoles ? Math.Round((decimal)settings.HighBSLThreshold / 18, 1).ToString() : settings.HighBSLThreshold.ToString();
            LowThresholdTextBox.Text = settings.IsMillimoles ? Math.Round((decimal)settings.LowBSLThreshold / 18, 1).ToString() : settings.LowBSLThreshold.ToString();
            MmolButton.Checked = settings.IsMillimoles;
            MgButton.Checked = !settings.IsMillimoles;

            if (settings.ActiveStart == null)
            {
                StartTimePicker.CustomFormat = " ";
                StartTimePicker.Format = DateTimePickerFormat.Custom;
            }
            else 
            {
                StartTimePicker.Value = settings.ActiveStart.Value;
            }

            if (settings.ActiveEnd == null)
            {
                EndTimePicker.CustomFormat = " ";
                EndTimePicker.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                EndTimePicker.Value = settings.ActiveEnd.Value;
            }

            DailyReminderUpDown.Value = settings.MaxDailyReminder;
            SecondReminderUpDown.Value = Convert.ToDecimal(settings.SecondEntryReminder);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            DateTime? activeStart = null;
            DateTime? activeEnd = null;

            if (!string.IsNullOrEmpty(StartTimePicker.CustomFormat))
            {
                activeStart = StartTimePicker.Value;
            }

            if (!string.IsNullOrEmpty(EndTimePicker.CustomFormat))
            {
                activeEnd = EndTimePicker.Value;
            }

            Settings editedSettings = new Settings()
            {
                HighBSLThreshold = MmolButton.Checked && double.Parse(HighThresholdTextBox.Text) < 27 ? double.Parse(HighThresholdTextBox.Text)*18 : double.Parse(HighThresholdTextBox.Text),
                LowBSLThreshold = MmolButton.Checked && double.Parse(LowThresholdTextBox.Text) < 27 ? double.Parse(LowThresholdTextBox.Text)*18 : double.Parse(LowThresholdTextBox.Text),
                IsMillimoles = MmolButton.Checked,
                ActiveStart = activeStart,
                ActiveEnd = activeEnd,
                MaxDailyReminder = Convert.ToInt32(DailyReminderUpDown.Value),
                SecondEntryReminder = Convert.ToDouble(SecondReminderUpDown.Value),
                UserId = User.UserId
            };

            //TODO: Create or update object in the database
            using (var db = new AppDbContext())
            {
                if (db.Settings.Where(l => l.UserId == User.UserId).Count() == 0)
                {
                    db.Settings.Add(editedSettings);
                }
                else
                {
                    editedSettings.Id = settings.Id;
                    db.Settings.Attach(editedSettings);
                    db.Entry(editedSettings).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
            settings = editedSettings;
        }

        private void StartTimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            StartTimePicker.CustomFormat = "hh:mm tt";
        }

        private void EndTimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            EndTimePicker.CustomFormat = "hh:mm tt";
        }

        private void MmolButton_CheckedChanged(object sender, EventArgs e)
        {
            if (double.Parse(HighThresholdTextBox.Text) > 27)
            {
                HighThresholdTextBox.Text = Math.Round(double.Parse(HighThresholdTextBox.Text) / 18, 1).ToString();
            }
            if (double.Parse(LowThresholdTextBox.Text) > 27)
            {
                LowThresholdTextBox.Text = Math.Round(double.Parse(LowThresholdTextBox.Text) / 18, 1).ToString();
            }
        }

        private void MgButton_CheckedChanged(object sender, EventArgs e)
        {
            if (double.Parse(HighThresholdTextBox.Text) <= 27)
            {
                HighThresholdTextBox.Text = Math.Round(double.Parse(HighThresholdTextBox.Text) * 18, 0).ToString();
            }
            if (double.Parse(LowThresholdTextBox.Text) <= 27)
            {
                LowThresholdTextBox.Text = Math.Round(double.Parse(LowThresholdTextBox.Text) * 18, 0).ToString();
            }
        }
    }
}
