using System;

namespace GlucoCheck.Classes
{
    public class Settings
    {
        #region Properties

        // TODO: Specific thresholds needed? (i.e., fasting, before meal, after meal, before bed, etc...)

        public float HighBSLThreshold { get; set; }

        public float LowBSLThreshold { get; set; }

        // Maximum number of hours user will allow to pass since last entry before receiving reminder
        // Default maximum will be 24 hours to enter at least once per day
        public int MaxDailyReminder { get; set; }

        // A property to determine if user wants measurements in mmol/L or mg/dL
        // Default set to False since US standard is mg/dL
        public Boolean IsMillimoles { get; set; }

        public DateTime ActiveStart { get; set; }

        public DateTime ActiveEnd { get; set; }

        #endregion

        #region Constructors

        // TODO: Complete no arg constructor speak w/ group about default value preferences - in constructor or in methods?
        // Could provide default values for reminders, unit of measurement, and normal BSL thresholds
        public Settings()
        {

        }

        public Settings(float highBSLThreshold, float lowBSLThreshold, int maxDailyReminder,
            Boolean isMillimoles, DateTime activeStart, DateTime activeEnd)
        {
            HighBSLThreshold = highBSLThreshold;
            LowBSLThreshold = lowBSLThreshold;
            MaxDailyReminder = maxDailyReminder;
            IsMillimoles = isMillimoles;
            ActiveStart = activeStart;
            ActiveEnd = activeEnd;
        }

        #endregion

        #region Functions
        #endregion
    }
}
