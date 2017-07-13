using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPL3FMInstrumentTester
{
    public partial class InstrumentsListForm : Form
    {
        IBKHeader ibkFile = new IBKHeader();

        public InstrumentsListForm(string path)
            : this()
        {
            using (Stream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BinaryReader reader = new BinaryReader(fileStream);
                int ibkFormatSize = Marshal.SizeOf(typeof(IBKHeader));
                Debug.Write(ibkFormatSize);
                byte[] bytes = reader.ReadBytes(ibkFormatSize);
                GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                Marshal.PtrToStructure(handle.AddrOfPinnedObject(), ibkFile);
                handle.Free();
                Debug.WriteLine(ibkFile.InstrumentNames[0]);
                Debug.WriteLine(ibkFile.InstrumentData[0].iModChar.ToString());
                var bindableNames = from names in ibkFile.InstrumentNames select new { InstrName = names };
                iBKHeaderBindingSource.DataSource = bindableNames;
                dgvInstrumentList.AutoGenerateColumns = true;
                dgvInstrumentList.DataSource = iBKHeaderBindingSource;
            }
        }

        public InstrumentsListForm()
        {
            InitializeComponent();
        }

        private void InstrumentsListForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvInstrumentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString());
            InstrumentForm instrumentForm = new InstrumentForm(ibkFile.InstrumentData[e.RowIndex]);
            instrumentForm.MdiParent = this.MdiParent;
            instrumentForm.Show();
        }
    }
}
