using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPL3FMInstrumentTester
{
    public partial class PreviewForm : Form
    {
        WinMMWaveOut waveOut;

        public PreviewForm()
        {
            InitializeComponent();

            new FMSynth();
            waveOut = new WinMMWaveOut(2, 44100, 16);
            waveOut.Open();
        }

        private void PreviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            waveOut.Close();
        }
    }
}
