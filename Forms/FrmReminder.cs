using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlucoCheck.Forms
{
    public partial class FrmReminder : Form
    {
        public FrmReminder(string reminder)
        {
            InitializeComponent();
            LblReminder.Text = reminder;
        }
    }
}
