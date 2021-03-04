using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlucoCheck.Classes
{
    class User
    {
        #region Properties
        string FirstName { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
        string SecurityQuestion { get; set; }
        string SecurityAnswer { get; set; }
        string DoctorName { get; set; }
        string Gender { get; set; }
        DateTime BirthDate { get; set; }
        float Weight { get; set; }
        int Phone { get; set; }
        int BSLHigh { get; set; }
        int BSLLow { get; set; }
        LogEntry[] AllLogs { get; set; }
        #endregion

        #region Functions
        // Call constructor after user signs up.
        public User(string FirstName, string LastName, string Password, string SecurityQuestion, string SecurityAnswer, string Gender, DateTime BirthDate, int BSLHigh, int BSLLow)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Password = Password;
            this.SecurityQuestion = SecurityQuestion;
            this.Gender = Gender;
            this.BirthDate = BirthDate;
            this.BSLHigh = BSLHigh;
            this.BSLLow = BSLLow;
        }

        public void EditProfile()
        {
            //Open edit profile form
        }

        public void DisplayGraph()
        {
            
        }

        public void CreateLog()
        {
            //Open form to input new log properties

        }

        public void EditLog(LogEntry editLog)
        {
            //Open form to edit the passed log
        }

        public void ViewLogs()
        {
            //Open page that displays all logs
        }
        #endregion
    }
}
