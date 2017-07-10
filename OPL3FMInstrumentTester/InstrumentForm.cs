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
    }
}
