namespace OPL3FMInstrumentTester
{
    partial class InstrumentsListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dgvInstrumentList = new System.Windows.Forms.DataGridView();
            this.iBKFileBinderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iBKInstrumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iBKHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBKFileBinderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBKInstrumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBKHeaderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvInstrumentList);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(444, 336);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(444, 361);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // dgvInstrumentList
            // 
            this.dgvInstrumentList.AllowUserToAddRows = false;
            this.dgvInstrumentList.AllowUserToDeleteRows = false;
            this.dgvInstrumentList.AutoGenerateColumns = false;
            this.dgvInstrumentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstrumentList.DataSource = this.iBKFileBinderBindingSource;
            this.dgvInstrumentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInstrumentList.Location = new System.Drawing.Point(0, 0);
            this.dgvInstrumentList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInstrumentList.Name = "dgvInstrumentList";
            this.dgvInstrumentList.Size = new System.Drawing.Size(444, 336);
            this.dgvInstrumentList.TabIndex = 0;
            this.dgvInstrumentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstrumentList_CellDoubleClick);
            // 
            // iBKFileBinderBindingSource
            // 
            this.iBKFileBinderBindingSource.DataSource = typeof(OPL3FMInstrumentTester.IBKFileBinder);
            // 
            // iBKInstrumentBindingSource
            // 
            this.iBKInstrumentBindingSource.DataMember = "InstrumentData";
            this.iBKInstrumentBindingSource.DataSource = typeof(OPL3FMInstrumentTester.IBKHeader);
            // 
            // iBKHeaderBindingSource
            // 
            this.iBKHeaderBindingSource.AllowNew = false;
            this.iBKHeaderBindingSource.DataSource = typeof(OPL3FMInstrumentTester.IBKHeader);
            // 
            // InstrumentsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 361);
            this.Controls.Add(this.toolStripContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InstrumentsListForm";
            this.Text = "Instruments List";
            this.Load += new System.EventHandler(this.InstrumentsListForm_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrumentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBKFileBinderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBKInstrumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBKHeaderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dgvInstrumentList;
        private System.Windows.Forms.BindingSource iBKHeaderBindingSource;
        private System.Windows.Forms.BindingSource iBKInstrumentBindingSource;
        private System.Windows.Forms.BindingSource iBKFileBinderBindingSource;
    }
}