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

            //pictureBoxWaveSel.Tag = 0;
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

        private void comboBoxWaveSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxWaveSel.SelectedIndex)
            {
                case 0:
                    pictureBoxWaveSel.Image = OPL3FMInstrumentTester.Properties.Resources.wave0;
                    break;

                case 1:
                    pictureBoxWaveSel.Image = OPL3FMInstrumentTester.Properties.Resources.wave1;
                    break;

                case 2:
                    pictureBoxWaveSel.Image = OPL3FMInstrumentTester.Properties.Resources.wave2;
                    break;

                case 3:
                    pictureBoxWaveSel.Image = OPL3FMInstrumentTester.Properties.Resources.wave3;
                    break;

                case 4:
                    pictureBoxWaveSel.Image = OPL3FMInstrumentTester.Properties.Resources.wave4;
                    break;

                case 5:
                    pictureBoxWaveSel.Image = OPL3FMInstrumentTester.Properties.Resources.wave5;
                    break;

                case 6:
                    pictureBoxWaveSel.Image = OPL3FMInstrumentTester.Properties.Resources.wave6;
                    break;

                case 7:
                    pictureBoxWaveSel.Image = OPL3FMInstrumentTester.Properties.Resources.wave7;
                    break;

                default:
                    pictureBoxWaveSel.Image = OPL3FMInstrumentTester.Properties.Resources.wave0;
                    break;
            }
        }
    }
}
