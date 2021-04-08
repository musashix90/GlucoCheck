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
    public partial class FrmRegister : Form
    {
        private string username;
        private string password;

        public FrmRegister()
        {
            InitializeComponent();
        }

        public FrmRegister(string username, string password)
        {
            this.username = username;
            this.password = password;
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

            //TODO: Save user to database
            //TODO: Go to main form
        }
    }
}
