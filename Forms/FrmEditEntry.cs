using System;
using GlucoCheck.Classes;
using System.Windows.Forms;

namespace GlucoCheck.Forms
{
    public partial class FrmEditEntry : Form
    {
        #region Variables

        private LogEntry originalEntry = null;

        #endregion

        #region Constructors

        public FrmEditEntry()
        {
            InitializeComponent();
        }

        public FrmEditEntry(LogEntry originalEntry)
        {
            InitializeComponent();

            this.originalEntry = originalEntry;
        }

        #endregion

        #region Events

        private void FrmEditEntry_Load(object sender, EventArgs e)
        {
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
            LogEntry editedEntry = new LogEntry()
            {
                BSL = (int)NumUpDownBSL.Value,
                Carbs = (int)NumUpDownCarbs.Value,
                InsulinDosed = (float)NumUpDownInsulinDosed.Value,
                EntryDate = DTPEntryDate.Value
            };

            //To do: add code that updates the entry on the DB.
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}