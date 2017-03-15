using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPL3FMInstrumentTester
{
    public partial class ModulatorOperatorPage : UserControl
    {
        public ModulatorOperatorPage()
        {
            InitializeComponent();

            buttonWaveformSelect.Tag = 0;
        }

        private void buttonWaveformSelect_Click(object sender, EventArgs e)
        {

        }

        private void trackBarTotalLevel_Scroll(object sender, EventArgs e)
        {
            labelTotalLevel.Text = ((TrackBar)sender).Value.ToString();
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
