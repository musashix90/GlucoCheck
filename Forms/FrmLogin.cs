using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlucoCheck.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var username = UsernameTextbox.Text;
            var password = PasswordTextbox.Text;
            //TODO: retrieve user from database and check password
            var passwordCheck = true;
            if (passwordCheck)
            {
                //goto main form
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
            if (userExists)
            {
                UserExistsErrorLabel.Visible = true;
            }
            else
            {
                Form form = new FrmRegister(username, password);
                form.ShowDialog();
                //TODO: close login
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
