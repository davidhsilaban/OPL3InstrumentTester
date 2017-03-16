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

        public PreviewForm()
        {
            InitializeComponent();

            synth = new FMSynth();
            waveOut = new WinMMWaveOut(2, 44100, 16);
            waveOut.Open();

            lock (renderingLock)
            {
                isRendering = true;
                Monitor.Pulse(renderingLock);
            }

            synthThread = new Thread(SynthProcessingThread);
            synthThread.Start();
        }

        private void SynthProcessingThread()
        {
            while (isRendering)
            {
                short[] buffer = new short[1024];
                synth.getsample(buffer, 1024);
                Debug.Write(buffer.Length);
            }
        }

        private void PreviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lock (renderingLock)
            {
                isRendering = false;
                Monitor.Pulse(renderingLock);
                waveOut.Close();
            }
        }
    }
}
