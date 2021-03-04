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
    public partial class FrmLogGraph : Form
    {
        public FrmLogGraph()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            //Adds some test elements to the graph
            bslchart.Series["BSL"].Points.AddXY("Jan. 1", 180 + "mg/dl");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
