using System;

namespace GlucoCheck.Classes
{
    public class Settings
    {
        #region Properties

        public double HighBSLThreshold { get; set; } = 200.0;

        public double LowBSLThreshold { get; set; } = 70.0;

        // Maximum number of hours user will allow to pass since last entry before receiving reminder
        // Default maximum will be 24 hours to enter at least once per day
        public int MaxDailyReminder { get; set; } = 24;

        // Number of hours allowed to pass after "first" entry before receiving a reminder to enter a "second" entry.
        // TODO: still waiting for group feedback about distinguishing entries based on when they were entered
        // to change this setting to a "post-meal" reminder.
        public double SecondEntryReminder { get; set; } = 2.0;

        // A property to determine if user wants measurements in mmol/L or mg/dL
        // Default set to False since US standard is mg/dL
        public Boolean IsMillimoles { get; set; } = false;

        // ActiveStart and ActiveEnd defaults to null so "active hours" will be 24/7
        public DateTime? ActiveStart { get; set; }

        public DateTime? ActiveEnd { get; set; }

        #endregion

        #region Constructors

        public Settings() { }

        #endregion

        #region Functions
        #endregion
    }
}
