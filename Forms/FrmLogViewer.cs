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

        /// <summary>
        /// Indicates if the log should be filtered when a filter control's
        /// value on the form is changed. You may want to disable this
        /// when, say, the form is loading and you are setting the default
        /// values of the controls.
        /// </summary>
        bool filterActive = true;

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

        private void DTPFrom_ValueChanged(object sender, EventArgs e)
        {
            FilterLogByDate();
        }

        private void DTPTo_ValueChanged(object sender, EventArgs e)
        {
            FilterLogByDate();
        }

        #endregion

        #region Functions

        /// <summary>
        /// Resets all the controls of the form to their default value.
        /// </summary>
        private void SetControlsToDefault()
        {
            //Disable the filter controls so that default values can be set.
            filterActive = false;

            //Set the default values for each control.
            DTPFrom.Value = DateTime.Now;
            DTPTo.Value = DateTime.Now.AddDays(-30);

            //Enable the filter controls after setting their default values.
            filterActive = true;
        }

        /// <summary>
        /// Filters the log entries by the date range the user has selected.
        /// </summary>
        private void FilterLogByDate()
        {
            //Check to make sure the date range is valid.
            if (DateTime.Compare(DTPFrom.Value, DTPTo.Value) < 0)
            {
                MessageBox.Show("The \"From\" date must be date that is " +
                    "later than the \"To\" date!", "Invalid date range!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (filterActive)
            {
                //Filter the log entires by the from and to dates.
                BindingSource source = new BindingSource();
                source.DataSource = DGVLogEntries.DataSource;
                source.Filter = "Data > " + DTPTo.Value + "AND Data < " + DTPFrom.Value;
                DGVLogEntries.DataSource = source;
            }
        }

        #endregion
    }
}