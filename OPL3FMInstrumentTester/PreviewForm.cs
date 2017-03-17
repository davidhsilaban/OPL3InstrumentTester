using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPL3FMInstrumentTester
{
    public partial class PreviewForm : Form
    {
        WinMMWaveOut waveOut;
        FMSynth synth;
        private Thread synthThread;
        private bool isRendering;
        private object renderingLock = new object();
        private bool soundOn;
        private Stopwatch watch = new Stopwatch();

        public PreviewForm()
        {
            InitializeComponent();

            synth = new FMSynth();
            waveOut = new WinMMWaveOut(2, 44100, 16);
            waveOut.Open();
        }

        private void SynthProcessingThread()
        {
            while (isRendering)
            {
                short[] buffer = new short[4410*2];
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                synth.getsample(buffer, 4410);
                stopwatch.Stop();
                //Debug.WriteLine("Render " + stopwatch.ElapsedMilliseconds);
                stopwatch.Restart();
                waveOut.Write(buffer);
                stopwatch.Stop();
                //Debug.WriteLine("Write " + stopwatch.ElapsedMilliseconds);
                Thread.Sleep(1);
            }
        }

        private void SetupFMParameters()
        {
            MainForm mainForm = (MainForm)this.Owner;

            TabPage tabPageOp1 = mainForm.tabControl1.TabPages[0];
            ModulatorOperatorPage modOpPage1 = (ModulatorOperatorPage)tabPageOp1.Controls[0];

            TabPage tabPageOp2 = mainForm.tabControl1.TabPages[1];
            CarrierOperatorPage modOpPage2 = (CarrierOperatorPage)tabPageOp2.Controls[0];

            int ar_dr_op1 = (((int)modOpPage1.numericUpDownAttack.Value & 0xF) << 4) | ((int)modOpPage1.numericUpDownDecay.Value & 0xF);
            int sr_rr_op1 = (((int)modOpPage1.numericUpDownSustain.Value & 0xF) << 4) | ((int)modOpPage1.numericUpDownRelease.Value & 0xF);
            int trem_vibr_sust_ksr_mult_op1 = (modOpPage1.checkBoxTremolo.Checked ? 1 << 7 : 0 << 7) | 
                (modOpPage1.checkBoxVibrato.Checked ? 1 << 6 : 0 << 6) | 
                (modOpPage1.checkBoxSustain.Checked ? 1 << 5 : 0 << 5) |
                (modOpPage1.checkBoxKSR.Checked ? 1 << 4 : 0 << 4) |
                ((int)modOpPage1.numericUpDownMultiplier.Value & 0x0F);
            int ksl_tl_op1 = (((int)modOpPage1.numericUpDownKSL.Value & 0x3) << 6) | ((int)modOpPage1.trackBarTotalLevel.Value);
            int waveform_op1 = ((int)modOpPage1.buttonWaveformSelect.Tag & 0x7);

            int ar_dr_op2 = (((int)modOpPage2.numericUpDownAttack.Value & 0xF) << 4) | ((int)modOpPage2.numericUpDownDecay.Value & 0xF);
            int sr_rr_op2 = (((int)modOpPage2.numericUpDownSustain.Value & 0xF) << 4) | ((int)modOpPage2.numericUpDownRelease.Value & 0xF);
            int trem_vibr_sust_ksr_mult_op2 = (modOpPage2.checkBoxTremolo.Checked ? 1 << 7 : 0 << 7) |
                (modOpPage2.checkBoxVibrato.Checked ? 1 << 6 : 0 << 6) |
                (modOpPage2.checkBoxSustain.Checked ? 1 << 5 : 0 << 5) |
                (modOpPage2.checkBoxKSR.Checked ? 1 << 4 : 0 << 4) |
                ((int)modOpPage2.numericUpDownMultiplier.Value & 0x0F);
            int ksl_tl_op2 = (((int)modOpPage2.numericUpDownKSL.Value & 0x3) << 6) | ((int)modOpPage2.trackBarTotalLevel.Value);
            int waveform_op2 = ((int)modOpPage2.buttonWaveformSelect.Tag & 0x7);

            int fb_alg = (((int)modOpPage2.numericUpDownFeedback.Value & 0x7) << 1) | (modOpPage2.comboBoxSynthesisType.SelectedIndex);

            /*Debug.WriteLine(trem_vibr_sust_ksr_mult_op1);*/

            // Write OP 1 to synthesizer
            synth.write(0x20, (byte)trem_vibr_sust_ksr_mult_op1);
            synth.write(0x40, (byte)ksl_tl_op1);
            synth.write(0x60, (byte)ar_dr_op1);
            synth.write(0x80, (byte)sr_rr_op1);
            synth.write(0xE0, (byte)waveform_op1);

            // Write OP 2 to synthesizer
            synth.write(0x23, (byte)trem_vibr_sust_ksr_mult_op2);
            synth.write(0x43, (byte)ksl_tl_op2);
            synth.write(0x63, (byte)ar_dr_op2);
            synth.write(0x83, (byte)sr_rr_op2);
            synth.write(0xE3, (byte)waveform_op2);

            // Write CH 1 to synthesizer
            synth.write(0xC0, (byte)fb_alg);
        }

        private void SoundOnSingleNote()
        {
            synth.write(0xA0, 0x6E);
            synth.write(0xB0, (1 << 5) | (4 << 2) | (0x01));
        }

        private void SoundOffSingleNote()
        {
            synth.write(0xA0, 0x6E);
            synth.write(0xB0, (4 << 2) | (0x01));
        }

        private void PreviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lock (renderingLock)
            {
                timer1.Enabled = false;

                isRendering = false;
                Monitor.Pulse(renderingLock);
                waveOut.Close();
            }
        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {
            lock (renderingLock)
            {
                isRendering = true;
                Monitor.Pulse(renderingLock);
            }

            synthThread = new Thread(SynthProcessingThread);
            synthThread.Start();

            timer1.Enabled = true;
        }

        private void buttonSingleNote_MouseDown(object sender, MouseEventArgs e)
        {
            SetupFMParameters();
            SoundOnSingleNote();
        }

        private void buttonSingleNote_MouseUp(object sender, MouseEventArgs e)
        {            
            SoundOffSingleNote();
        }

        private void buttonSingleNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                buttonSingleNote_MouseDown(sender, null);
            }
        }

        private void buttonSingleNote_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                buttonSingleNote_MouseUp(sender, null);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            soundOn = !soundOn;
            if (soundOn)
            {
                watch.Restart();
                SetupFMParameters();
                SoundOnSingleNote();
                watch.Stop();
                Debug.WriteLine("On: " + watch.ElapsedMilliseconds);
            } else
            {
                watch.Restart();
                SoundOffSingleNote();
                watch.Stop();
                Debug.WriteLine("Off: " + watch.ElapsedMilliseconds);
            }
        }
    }
}
