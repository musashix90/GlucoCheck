using System;

namespace GlucoCheck.Classes
{
    public class Reminder
    {
        #region Properties

        public long Id { get; set; }

        /// <summary>
        /// The time for when to send the user the reminder. Formatted as MM/DD/YYYY.
        /// </summary>
        public DateTime TimeToRemind { get; set; }

        /// <summary>
        /// The actual task the user is being reminded of.
        /// </summary>
        public string TaskToRemind { get; set; }

        #endregion

        #region Constructors

        public Reminder(DateTime timeToRemind, string taskToRemind)
        {
            TimeToRemind = timeToRemind;
            TaskToRemind = taskToRemind;
        }

        #endregion

        #region Functions

        #endregion
    }
}