using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlucoCheck.Classes
{
    [Table("users")]
    public class User
    {
        #region Properties
        [Key]
        public string UserId { get; set; }

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public string DoctorName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public float Weight { get; set; }
        public int Phone { get; set; }

        [NotMapped]
        LogEntry[] AllLogs { get; set; }
        #endregion

        #region Functions

        // Blank constructor for empty User object
        public User()
        {

        }

        // Call constructor after user signs up.
        public User(String UserName, string FirstName, string LastName, string Password, string SecurityQuestion, string SecurityAnswer, string Gender, DateTime BirthDate)
        {
            Guid guid = Guid.NewGuid();
            this.UserId = guid.ToString();
            this.UserName = UserName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Password = Password;
            this.SecurityQuestion = SecurityQuestion;
            this.Gender = Gender;
            this.BirthDate = BirthDate;
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
