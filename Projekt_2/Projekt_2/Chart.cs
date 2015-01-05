using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_2
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }

        public void pokazGantta(System.Windows.Forms.DataVisualization.Charting.Chart gantt, int ymax)
        {
            chart1.Series.Clear();
            foreach (System.Windows.Forms.DataVisualization.Charting.Series s in gantt.Series)
            {
                chart1.Series.Add(s);
            }
        }

        private void Chart_FormClosing(object sender, FormClosingEventArgs e)
        {
                e.Cancel = true;
        }
    }
}
