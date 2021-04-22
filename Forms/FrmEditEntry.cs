using System;
using GlucoCheck.Classes;
using System.Windows.Forms;

namespace GlucoCheck.Forms
{
    public partial class FrmEditEntry : Form
    {
        #region Variables

        public LogEntry originalEntry;
        public int Id;

        #endregion

        #region Constructors

        public FrmEditEntry()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void FrmEditEntry_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                //Filter the log entires by the from and to dates.
                originalEntry = db.Log.Find(Id);
            }

            DTPEntryDate.MaxDate = DateTime.Today;

            if (originalEntry != null)
            {
                NumUpDownBSL.Value = originalEntry.BSL;
                NumUpDownCarbs.Value = originalEntry.Carbs;
                NumUpDownInsulinDosed.Value = (decimal)originalEntry.InsulinDosed;
                DTPEntryDate.Value = originalEntry.EntryDate;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                originalEntry.BSL = (int)NumUpDownBSL.Value;
                originalEntry.Carbs = (int)NumUpDownCarbs.Value;
                originalEntry.InsulinDosed = (float)NumUpDownInsulinDosed.Value;
                originalEntry.EntryDate = DTPEntryDate.Value;

                db.Log.Attach(originalEntry);
                db.Entry(originalEntry).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}