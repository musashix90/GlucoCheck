using System;

namespace GlucoCheck.Classes
{
    public class LogEntry
    {
        #region Properties

        //DateTime related properties
        //====================================================================================
        public DateTime LogDate
        {
            get { return LogDate; }

            set
            {
                //Flawed code!!!
                //Causes infinite recursion!
                LogDate = value;

                EasyTime = LogDate.ToString("hh:mmtt").ToLower();
                EasyYear = LogDate.ToString("MM/dd/yyyy");
            }
        }

        /// <summary>
        /// The time the entry was made, formatted as: hour:minute am/pm. For
        /// example: 2:15pm. This value is automatically updated if the LogDate
        /// property is changed.
        /// </summary>
        public string EasyTime { get; private set; }

        /// <summary>
        /// The date the entry was made, formatted as: month/day/year. For
        /// example: 02/17/2021. This value is automatically updated if the 
        /// LogDate property is changed.
        /// </summary>
        public string EasyYear { get; private set; }


        //BSL related properties
        //====================================================================================
        public int BSL { get; set; }
        public int PostBSL
        {
            get { return PostBSL; }

            set
            {
                //Flawed code!!!
                //Causes infinite recursion!
                PostBSL = value;
                BSLDelta = Math.Abs(BSL - PostBSL);
            }
        }

        /// <summary>
        /// How much the BSL changed between the time eating and 2 hours after.
        /// This value is automatically updated if the PostBSL property is
        /// changed.
        /// </summary>
        public int BSLDelta { get; private set; }


        //Other properties
        //====================================================================================
        public int Carbs { get; set; }
        public float InsulinDosed { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an empty (or "blank") LogEntry object. Only the LogDate
        /// property is set, everything else is left as its default value.
        /// </summary>
        public LogEntry()
        {
            this.LogDate = DateTime.Now;
        }

        #endregion

        #region Functions



        #endregion
    }
}