using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlucoCheck.Forms;
using System.Data.Entity;
using GlucoCheck.Classes;

namespace GlucoCheck
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, GlucoCheck.Migrations.Configuration>(true));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //TODO: show login page, hide main form?

            User user = null;
            DialogResult result;
            using (var loginForm = new FrmLogin())
            {
                result = loginForm.ShowDialog();
                user = loginForm.user;
            }
            if (result == DialogResult.OK)
            {
                // login was successful
                FrmMain mainForm = new FrmMain();
                mainForm.user = user;
                Application.Run(mainForm);
            }

        }
    }
}
