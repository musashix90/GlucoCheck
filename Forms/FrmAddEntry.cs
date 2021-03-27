using System;
using GlucoCheck.Classes;
using System.Windows.Forms;

namespace GlucoCheck.Forms
{
    public partial class FrmAddEntry : Form
    {
        #region Variables

        public User User { get; set; }

        #endregion

        public FrmAddEntry()
        {
            InitializeComponent();
        }

        #region Events

        private void FrmAddEntry_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LogEntry entry = new LogEntry()
            {
                BSL = (int)NumUpDownCurrentBSL.Value,
                Carbs = (int)NumUpDownCarbs.Value,
                InsulinDosed = (float)NumUpDownInsulinDosed.Value,
                UserId = User.UserId
            };

            // Update the database with the current entry object
            using (var db = new AppDbContext())
            {
                db.Log.Add(entry);
                db.SaveChanges();
            }

            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Functions



        #endregion
    }
}