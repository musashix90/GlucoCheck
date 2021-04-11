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
    public partial class FrmLogin : Form
    {
        public User user { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
            using (var db = new AppDbContext())
            {
                var count = db.User.Count();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var username = UsernameTextbox.Text;
            var password = PasswordTextbox.Text;
            //TODO: retrieve user from database and check password
            var passwordCheck = true;
            using (var db = new AppDbContext())
            {
                var loginUser = db.User.Where(l => l.UserName.Equals(username)).FirstOrDefault();
                if (loginUser == null)
                {
                    passwordCheck = false;
                } else
                {
                    if (BCrypt.Net.BCrypt.Verify(password, loginUser.Password))
                    {
                        passwordCheck = true;
                        user = loginUser;
                    }
                    else
                    {
                        passwordCheck = false;
                    }
                }
            }
            if (passwordCheck)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                ErrorLabel.Visible = true;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var username = UsernameTextbox.Text;
            var password = PasswordTextbox.Text;
            //TODO: check if user already exists;
            var userExists = true;
            using (var db = new AppDbContext())
            {
                if (db.User.Where(l => l.UserName.Equals(username)).FirstOrDefault() == null)
                {
                    userExists = false;
                }
                else
                {
                    userExists = true;
                }
            }
            if (userExists)
            {
                UserExistsErrorLabel.Visible = true;
            }
            else
            {
                DialogResult result;
                using (var form = new FrmRegister(username, password))
                {
                    result = form.ShowDialog();
                    //TODO: close login
                    if (result == DialogResult.OK)
                    {
                        user = form.user;
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            UserExistsErrorLabel.Visible = false;
        }

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            UserExistsErrorLabel.Visible = false;
        }
    }
}
