using System;
using System.Linq;
using System.Diagnostics;
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
            //Set form controls to their defualt values.
            SetControlsToDefault();
            FilterLog();

            DGVLogEntries.Columns["Id"].Visible = false;
            DGVLogEntries.Columns["User"].Visible = false;
            DGVLogEntries.Columns["UserId"].Visible = false;
            DGVLogEntries.Columns["EntryDate"].Visible = false;

            DGVLogEntries.Columns["BSL"].DisplayIndex = 0;
            DGVLogEntries.Columns["Carbs"].DisplayIndex = 1;
            DGVLogEntries.Columns["InsulinDosed"].DisplayIndex = 2;
            DGVLogEntries.Columns["EasyDate"].DisplayIndex = 3;
            DGVLogEntries.Columns["EasyTime"].DisplayIndex = 4;

            DGVLogEntries.Columns["EasyDate"].HeaderText = "Date";
            DGVLogEntries.Columns["EasyTime"].HeaderText = "Time";

            DGVLogEntries.AllowUserToAddRows = false;
//            DGVLogEntries.CellEndEdit += new DataGridViewCellEventHandler(DataGridView_CellEndEdit);
//            DGVLogEntries.CellValidating += new DataGridViewCellValidatingEventHandler(DataGridView_CellValidating);

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
            FilterLog();
        }

        private void BtnPrintLog_Click(object sender, EventArgs e)
        {
            //Get all the entries within the date rage.
            using (var db = new AppDbContext())
            {
                var entries = db.Log.Where(l => l.EntryDate >= DTPFrom.Value)
                    .Where(l => l.EntryDate <= DTPTo.Value)
                    .OrderByDescending(l => l.EntryDate);


                //Create a local HTML doc of the log.
                string desktopPath = Environment.
                    GetFolderPath(Environment.SpecialFolder.Desktop);

                GCUtility.LogToHTMLDoc(entries.ToArray(), 
                    desktopPath + "\\BSL log.html");

                //Open the HTML doc so the user can print it.
                Process.Start(desktopPath + "\\BSL log.html");
            }
        }

        #endregion

        #region Functions

        /// <summary>
        /// Resets all the controls of the form to their default value.
        /// </summary>
        private void SetControlsToDefault()
        {
            //Set the default values for each control.
            DTPFrom.Value = DateTime.Now.AddDays(-30);
            DTPTo.Value = DateTime.Now;

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
            using (var db = new AppDbContext())
            {
                //Filter the log entires by the from and to dates.
                var entries = db.Log.Where(l => l.EntryDate >= DTPFrom.Value)
                    .Where(l => l.EntryDate <= DTPTo.Value);
                
                switch (ComboxBSLFilter.SelectedIndex)
                {
                    case 0:
                        entries = entries.Where(l => l.BSL == NumUDBSLValue.Value);
                        break;
                    case 1:
                        entries = entries.Where(l => l.BSL > NumUDBSLValue.Value);
                        break;
                    case 2:
                        entries = entries.Where(l => l.BSL < NumUDBSLValue.Value);
                        break;
                    default:
                        break;
                }

                switch (ComboxCarbsFilter.SelectedIndex)
                {
                    case 0:
                        entries = entries.Where(l => l.Carbs == NumUDCarbsValue.Value);
                        break;

                    case 1:
                        entries = entries.Where(l => l.Carbs > NumUDCarbsValue.Value);
                        break;

                    case 2:
                        entries = entries.Where(l => l.Carbs < NumUDCarbsValue.Value);
                        break;

                    default:
                        break;
                }

                switch (ComboxInsulinFilter.SelectedIndex)
                {
                    case 0:
                        entries = entries.Where(l => l.InsulinDosed == (float)NumUDInsulinValue.Value);
                        break;

                    case 1:
                        entries = entries.Where(l => l.InsulinDosed > (float)NumUDInsulinValue.Value);
                        break;

                    case 2:
                        entries = entries.Where(l => l.InsulinDosed < (float)NumUDInsulinValue.Value);
                        break;

                    default:
                        break;
                }
                
                DGVLogEntries.DataSource = entries.ToList();
            }
        }

        #endregion
    }
}