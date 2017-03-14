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
    public partial class mainForm : Form
    {
        PreviewForm previewForm = new PreviewForm();

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void previewInstrumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (previewForm.IsDisposed) previewForm = new PreviewForm();
            previewForm.Show();
        }
    }
}
