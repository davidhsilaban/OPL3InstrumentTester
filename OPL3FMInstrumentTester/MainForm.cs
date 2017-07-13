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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //this.MainMenuStrip = new MenuStrip();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //InstrumentForm instrumentForm = new InstrumentForm();
            //instrumentForm.MdiParent = this;
            //instrumentForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialogOpenBank.ShowDialog(this);
            if (dlgResult == DialogResult.OK)
            {
                InstrumentsListForm instrumentsListForm = new InstrumentsListForm(openFileDialogOpenBank.FileName);
                instrumentsListForm.MdiParent = this;
                instrumentsListForm.Show();
            }
        }
    }
}
