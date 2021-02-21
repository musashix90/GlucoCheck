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

        #region Functions

        private void FrmAddEntry_Load(object sender, EventArgs e)
        {

        }

        private void TxtboxBSL_TextChanged(object sender, EventArgs e)
        {
            CheckInput(TxtboxBSL, LblWarningBSL);
        }

        private void TxtboxCarbs_TextChanged(object sender, EventArgs e)
        {
            CheckInput(TxtboxCarbs, LblWarningCarbs);
        }
        
        private void TxtboxInsulin_TextChanged(object sender, EventArgs e)
        {
            CheckInput(TxtboxInsulin, LblWarningInsulin);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckFormControls())
                MessageBox.Show("Invalid input on one or more controls!");

            else
            {
                LogEntry entry = new LogEntry()
                {
                    BSL = Convert.ToInt32(TxtboxBSL.Text),
                    Carbs = Convert.ToInt32(TxtboxCarbs.Text),
                    InsulinDosed = Convert.ToInt32(TxtboxInsulin.Text)
                };
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Functions

        /// <summary>
        /// Checks if the input to a text box is valid. If it is not, a message
        /// will be displayed on a label.
        /// </summary>
        /// <param name="txtbox"></param>
        /// <param name="lbl"></param>
        private void CheckInput(TextBox txtbox, Label lbl)
        {
            if (!DataValidation.IsNaturalNumber(txtbox.Text) 
                && txtbox.Text != "")
                lbl.Visible = true;

            else
                lbl.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool CheckFormControls()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (!DataValidation.IsNaturalNumber(control.Text))
                        return false;
                }
            }

            return true;
        }

        #endregion
    }
}