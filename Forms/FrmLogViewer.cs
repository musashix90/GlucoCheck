using System;
using System.Windows.Forms;
using System.Linq;
using GlucoCheck.Classes;

namespace GlucoCheck.Forms
{
    public partial class FrmLogViewer : Form
    {
        public FrmLogViewer()
        {
            InitializeComponent();
        }

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
    }
}