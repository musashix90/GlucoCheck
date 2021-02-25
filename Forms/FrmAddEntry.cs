using System;
using GlucoCheck.Classes;
using System.Windows.Forms;

namespace GlucoCheck.Forms
{
    public partial class FrmAddEntry : Form
    {
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
                InsulinDosed = (float)NumUpDownInsulinDosed.Value
            };

            //Todo: update DB with the new entry.
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