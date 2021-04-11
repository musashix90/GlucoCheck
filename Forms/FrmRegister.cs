using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlucoCheck.Classes;
using BCrypt.Net;

namespace GlucoCheck.Forms
{
    public partial class FrmRegister : Form
    {
        private string username;
        private string password;
        public User user { get; set; }

        public FrmRegister()
        {
            InitializeComponent();
        }

        public FrmRegister(string username, string password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            UsernameTextbox.Text = username;
            PasswordTextbox.Text = password;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var username = UsernameTextbox.Text;
            var password = PasswordTextbox.Text;
            var firstName = FirstNameTextbox.Text;
            var lastName = LastNameTextbox.Text;
            var dateOfBirth = DOBPicker.Value;

            var npassword = BCrypt.Net.BCrypt.HashPassword(password);

            //TODO: Save user to database
            using (var db = new AppDbContext())
            {
                user = new User(username, firstName, lastName, npassword, "", "", "", dateOfBirth);
                db.User.Add(user);
                db.SaveChanges();
            }
            //TODO: Go to main form
            DialogResult = DialogResult.OK;
        }
    }
}
