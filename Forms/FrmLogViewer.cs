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

        LogEntry[] log;

        bool formLoaded = false;

        #endregion

        #region Events

        private void FrmLogViewer_Load(object sender, EventArgs e)
        {
            //Set date time picker control values and set max date properties
            //so that the user cannot pick an invalid date range.
            DateTimePkrFrom.MaxDate = DateTime.Now;
            DateTimePkrTo.MaxDate = DateTime.Now;
            DateTimePkrTo.Value = DateTime.Now.AddDays(-30);

            log = GenerateDummyData(100);
            LogEntry[] filteredLog = FilterLogByRange(log, 
                DateTimePkrFrom.Value, DateTimePkrTo.Value);

            PopulateLstbox(LstboxEntries, filteredLog);
            LblEntriesHeader.Text = "Log entires (" +
                   LstboxEntries.Items.Count + " results)";

            formLoaded = true;
        }

        private void DateTimePkrFrom_ValueChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                LogEntry[] filteredLog = FilterLogByRange(log,
                    DateTimePkrFrom.Value, DateTimePkrTo.Value);

                PopulateLstbox(LstboxEntries, filteredLog);
                LblEntriesHeader.Text = "Log entires (" + 
                    LstboxEntries.Items.Count + " results)";
            }
        }

        private void DateTimePkrTo_ValueChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                LogEntry[] filteredLog = FilterLogByRange(log,
                    DateTimePkrFrom.Value, DateTimePkrTo.Value);

                PopulateLstbox(LstboxEntries, filteredLog);
                LblEntriesHeader.Text = "Log entires (" +
                    LstboxEntries.Items.Count + " results)";
            }
        }

        private void LstboxEntries_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("To add: FrmEditEntry");
        }

        #endregion

        #region Functions

        /// <summary>
        /// Filters log entires by the given to and from dates.
        /// </summary>
        /// <param name="log"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        private LogEntry[] FilterLogByRange(LogEntry[] log, DateTime dateFrom,
            DateTime dateTo)
        {
            return log.Where(o => 
            (o.EntryDate <= dateFrom && o.EntryDate >= dateTo)).ToArray();
        }

        /// <summary>
        /// Populates the given list box with the given log entires.
        /// </summary>
        /// <param name="lstbox"></param>
        /// <param name="log"></param>
        private void PopulateLstbox(ListBox lstbox, LogEntry[] log)
        {
            lstbox.Items.Clear();

            foreach (LogEntry entry in log)
            {
                string item = entry.EasyDate + "\t" + entry.EasyTime + "\t" +
                    entry.BSL + "\t" + entry.Carbs + "\t" + entry.InsulinDosed;

                lstbox.Items.Add(item);
            }
        }

        /// <summary>
        /// Generates X amount of random log entires, where X = the given size.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        private LogEntry[] GenerateDummyData(int size)
        {
            Random random = new Random();
            LogEntry[] entries = new LogEntry[size];

            for (int i = 0; i < size; i++)
            {
                LogEntry entry = new LogEntry()
                {
                    BSL = random.Next(100, 301),
                    Carbs = random.Next(10, 101),
                    InsulinDosed = random.Next(1, 11),
                    EntryDate = DateTime.Now.AddDays(-random.Next(0, 101))
                };

                entries[i] = entry;
            }

            return entries;
        }

        #endregion
    }
}