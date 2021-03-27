using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlucoCheck.Classes
{
    [Table("entry_log")]
    public class LogEntry
    {
        #region Properties
        [Key]
        public long Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        //Note: The EntryDate property needs to store its value in another 
        //(private) variable to avoid infinite recursion. In this case, I name
        //these variables: M_PropertName. The "M" stands for mirror since it
        //mirrors the value given to the public property.
        [NotMapped]
        private DateTime M_EntryDate { get; set; }

        /// <summary>
        /// The date of the log entry, formatted as: month/day/year (for 
        /// example: 02/19/2021). This value is automatically updated when the
        /// LogDate property is chanced.
        /// </summary>
        [NotMapped]
        public string EasyDate { get; private set; }

        /// <summary>
        /// The time of the log entry, formatted as: hour:minute am/pm (for 
        /// example: 2:34pm). This value is automatically updated when the
        /// LogDate property is chanced.
        /// </summary>
        [NotMapped]
        public string EasyTime { get; private set; }

        [Required]
        public int BSL { get; set; }
        public int Carbs { get; set; }
        public float InsulinDosed { get; set; }

        #endregion

        #region Property get/set functions

        [Required]
        public DateTime EntryDate
        {
            get { return M_EntryDate; }

            set
            {
                M_EntryDate = value;

                EasyDate = M_EntryDate.ToString("MM/dd/yyyy");
                EasyTime = M_EntryDate.ToString("hh:mmtt").ToLower();
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an emptry (or "blank") LogEntry object. The LogDate 
        /// property is automatically set to DateTime.Now when this constructor is
        /// used (this property can be changed later).
        /// </summary>
        public LogEntry()
        {
            this.EntryDate = DateTime.Now;
        }

        #endregion

        #region Functions



        #endregion
    }
}