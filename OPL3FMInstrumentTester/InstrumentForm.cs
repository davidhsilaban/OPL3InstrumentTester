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
    public partial class InstrumentForm : Form
    {
        PreviewForm previewForm;
        //IBKInstrument ibkInstrumentData;

        public InstrumentForm(object instrumentData)
            : this()
        {
            //if (instrumentData is IBKInstrument)
            //{
            //    this.ibkInstrumentData = (IBKInstrument)instrumentData;
            //}
            SetOperatorData(instrumentData);
        }

        private void SetOperatorData(object instrumentData)
        {
            if (instrumentData is IBKInstrument)
            {
                IBKInstrument ibkInstrumentData = (IBKInstrument)instrumentData;

                //ModulatorOperatorPage modulatorOpPage = (ModulatorOperatorPage)tabControlOperators.TabPages[0].Controls[0];
                modulatorOperatorPage1.numericUpDownAttack.Value = (ibkInstrumentData.iModAttack >> 4) & 0xF;
                modulatorOperatorPage1.numericUpDownDecay.Value = (ibkInstrumentData.iModAttack & 0xF);

                modulatorOperatorPage1.numericUpDownSustain.Value = (ibkInstrumentData.iModSustain >> 4) & 0xF;
                modulatorOperatorPage1.numericUpDownRelease.Value = (ibkInstrumentData.iModSustain & 0xF);

                modulatorOperatorPage1.numericUpDownKSL.Value = (ibkInstrumentData.iModScale >> 6) & 0x3;
                modulatorOperatorPage1.trackBarTotalLevel.Value = (ibkInstrumentData.iModScale & 0x3F);                

                modulatorOperatorPage1.numericUpDownMultiplier.Value = (ibkInstrumentData.iModChar & 0xF);

                modulatorOperatorPage1.checkBoxKSR.Checked = (ibkInstrumentData.iModChar & 0x10) > 0;
                modulatorOperatorPage1.checkBoxSustain.Checked = (ibkInstrumentData.iModChar & 0x20) > 0;
                modulatorOperatorPage1.checkBoxVibrato.Checked = (ibkInstrumentData.iModChar & 0x40) > 0;
                modulatorOperatorPage1.checkBoxTremolo.Checked = (ibkInstrumentData.iModChar & 0x80) > 0;

                //modulatorOperatorPage1.buttonWaveformSelect.Tag = (int)(ibkInstrumentData.iModWaveSel & 0x7);
                modulatorOperatorPage1.comboBoxWaveSel.SelectedIndex = (int)(ibkInstrumentData.iModWaveSel & 0x7);
                //switch (ibkInstrumentData.iModWaveSel & 0x7)
                //{
                //    case 0:
                //        modulatorOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave0;
                //        break;

                //    case 1:
                //        modulatorOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave1;
                //        break;

                //    case 2:
                //        modulatorOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave2;
                //        break;

                //    case 3:
                //        modulatorOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave3;
                //        break;

                //    case 4:
                //        modulatorOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave4;
                //        break;

                //    case 5:
                //        modulatorOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave5;
                //        break;

                //    case 6:
                //        modulatorOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave6;
                //        break;

                //    case 7:
                //        modulatorOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave7;
                //        break;

                //    default:
                //        modulatorOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave0;
                //        break;
                //}


                carrierOperatorPage1.numericUpDownAttack.Value = (ibkInstrumentData.iCarAttack >> 4) & 0xF;
                carrierOperatorPage1.numericUpDownDecay.Value = (ibkInstrumentData.iCarAttack & 0xF);

                carrierOperatorPage1.numericUpDownSustain.Value = (ibkInstrumentData.iCarSustain >> 4) & 0xF;
                carrierOperatorPage1.numericUpDownRelease.Value = (ibkInstrumentData.iCarSustain & 0xF);

                carrierOperatorPage1.numericUpDownKSL.Value = (ibkInstrumentData.iCarScale >> 6) & 0x3;
                carrierOperatorPage1.trackBarTotalLevel.Value = (ibkInstrumentData.iCarScale & 0x3F);

                carrierOperatorPage1.numericUpDownMultiplier.Value = (ibkInstrumentData.iCarChar & 0xF);

                carrierOperatorPage1.checkBoxKSR.Checked = (ibkInstrumentData.iCarChar & 0x10) > 0;
                carrierOperatorPage1.checkBoxSustain.Checked = (ibkInstrumentData.iCarChar & 0x20) > 0;
                carrierOperatorPage1.checkBoxVibrato.Checked = (ibkInstrumentData.iCarChar & 0x40) > 0;
                carrierOperatorPage1.checkBoxTremolo.Checked = (ibkInstrumentData.iCarChar & 0x80) > 0;

                //carrierOperatorPage1.buttonWaveformSelect.Tag = (int)(ibkInstrumentData.iCarWaveSel & 0x7);
                carrierOperatorPage1.comboBoxWaveSel.SelectedIndex = (int)(ibkInstrumentData.iCarWaveSel & 0x7);
                //switch (ibkInstrumentData.iCarWaveSel & 0x7)
                //{
                //    case 0:
                //        carrierOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave0;
                //        break;

                //    case 1:
                //        carrierOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave1;
                //        break;

                //    case 2:
                //        carrierOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave2;
                //        break;

                //    case 3:
                //        carrierOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave3;
                //        break;

                //    case 4:
                //        carrierOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave4;
                //        break;

                //    case 5:
                //        carrierOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave5;
                //        break;

                //    case 6:
                //        carrierOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave6;
                //        break;

                //    case 7:
                //        carrierOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave7;
                //        break;

                //    default:
                //        carrierOperatorPage1.buttonWaveformSelect.Image = OPL3FMInstrumentTester.Properties.Resources.wave0;
                //        break;
                //}

                carrierOperatorPage1.comboBoxSynthesisType.SelectedIndex = ibkInstrumentData.iFeedback & 0x1;
                carrierOperatorPage1.numericUpDownFeedback.Value = (ibkInstrumentData.iFeedback >> 1) & 0x7;
            }
        }

        public InstrumentForm()
        {
            InitializeComponent();

            previewForm = new PreviewForm();
            previewForm.MdiParent = (MainForm)this.MdiParent;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void previewInstrumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (previewForm.IsDisposed)
            {
                previewForm = new PreviewForm();
                //previewForm.MdiParent = (MainForm)this.MdiParent;
            }

            if (!previewForm.Visible)
            {
                previewForm.MdiParent = (MainForm)this.MdiParent;
                //previewForm.Parent = this;
                previewForm.Show();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void InstrumentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (previewForm != null)
            {
                previewForm.Close();
            }
        }
    }
}
