using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlucoCheck.Classes
{
    [Table("reminders")]
    public class Reminder
    {
        #region Properties

        [Key]
        public long Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        /// <summary>
        /// The actual task the user is being reminded of.
        /// </summary>
        [Required]
        public string TaskToRemind { get; set; }

        /// <summary>
        /// The time and date for when to send the user the reminder.
        /// </summary>
        [Required]
        public DateTime TimeToRemind
        {
            get { return M_TimeToRemind; }

            set
            {
                M_TimeToRemind = value;
                EasyDate = M_TimeToRemind.ToString("MM/dd/yyyy");
                EasyTime = M_TimeToRemind.ToString("hh:mmtt").ToLower();
            }
        }

        /// <summary>
        /// The date of the reminder in MM/DD/YYYY format.
        /// </summary>
        [NotMapped]
        public string EasyDate { get; private set; }

        /// <summary>
        /// The time of the reminder in HH:MMTT format.
        /// </summary>
        [NotMapped]
        public string EasyTime { get; private set; }

        /// <summary>
        /// A mirror for the time to remind property.
        /// </summary>
        [NotMapped]
        public DateTime M_TimeToRemind { get; set; }

        #endregion

        #region Constructors

        public Reminder()
        {
            TimeToRemind = DateTime.Now;
            TaskToRemind = "N/A";
        }

        public Reminder(String userId, DateTime timeToRemind, string taskToRemind)
        {
            UserId = userId;
            TimeToRemind = timeToRemind;
            TaskToRemind = taskToRemind;
        }

        #endregion

        #region Functions
        #endregion
    }
}