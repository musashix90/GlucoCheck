using System;
using System.Linq;
using GlucoCheck.Classes;
using System.Windows.Forms;

namespace GlucoCheck.Forms
{
    public partial class FrmLogViewer : Form
    {
        public FrmLogViewer()
        {
            InitializeComponent();
        }

        #region Variables



        #endregion

        #region Events

        private void FrmLogViewer_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                DGVLogEntries.DataSource = db.Log.ToList();
                DGVLogEntries.Columns["Id"].Visible = false;
                DGVLogEntries.AllowUserToAddRows = false;
                DGVLogEntries.CellEndEdit += new DataGridViewCellEventHandler(DataGridView_CellEndEdit);
                DGVLogEntries.CellValidating += new DataGridViewCellValidatingEventHandler(DataGridView_CellValidating);
            }

            //Set form controls to their defualt values.
            SetControlsToDefault();
        }

        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            InitializeComponent();
            if (e.ColumnIndex == 0)
            {
                DGVLogEntries.CancelEdit();
            }
        }

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // TODO - add database updating mechanism
        }

        private void BtnApplyFilter_Click(object sender, EventArgs e)
        {
            FilterLog();
        }

        private void BtnClearFilter_Click(object sender, EventArgs e)
        {
            SetControlsToDefault();
        }

        #endregion

        #region Functions

        /// <summary>
        /// Resets all the controls of the form to their default value.
        /// </summary>
        private void SetControlsToDefault()
        {
            //Set the default values for each control.
            DTPFrom.Value = DateTime.Now;
            DTPTo.Value = DateTime.Now.AddDays(-30);

            ComboxBSLFilter.SelectedIndex = -1;
            NumUDBSLValue.Value = 100;

            ComboxCarbsFilter.SelectedIndex = -1;
            NumUDCarbsValue.Value = 50;

            ComboxInsulinFilter.SelectedIndex = -1;
            NumUDInsulinValue.Value = 5;
        }

        /// <summary>
        /// Applies all set filters to the DataGridView control.
        /// </summary>
        private void FilterLog()
        {

        }

        #endregion
    }
}