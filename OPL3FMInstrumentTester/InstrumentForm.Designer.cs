namespace OPL3FMInstrumentTester
{
    partial class InstrumentForm
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOperator1 = new System.Windows.Forms.TabPage();
            this.modulatorOperatorPage1 = new OPL3FMInstrumentTester.ModulatorOperatorPage();
            this.tabPageOperator2 = new System.Windows.Forms.TabPage();
            this.carrierOperatorPage1 = new OPL3FMInstrumentTester.CarrierOperatorPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewInstrumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageOperator1.SuspendLayout();
            this.tabPageOperator2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(584, 417);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(584, 441);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOperator1);
            this.tabControl1.Controls.Add(this.tabPageOperator2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 417);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageOperator1
            // 
            this.tabPageOperator1.Controls.Add(this.modulatorOperatorPage1);
            this.tabPageOperator1.Location = new System.Drawing.Point(4, 22);
            this.tabPageOperator1.Name = "tabPageOperator1";
            this.tabPageOperator1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOperator1.Size = new System.Drawing.Size(576, 391);
            this.tabPageOperator1.TabIndex = 0;
            this.tabPageOperator1.Text = "OP 1";
            this.tabPageOperator1.UseVisualStyleBackColor = true;
            // 
            // modulatorOperatorPage1
            // 
            this.modulatorOperatorPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modulatorOperatorPage1.Location = new System.Drawing.Point(3, 3);
            this.modulatorOperatorPage1.Margin = new System.Windows.Forms.Padding(4);
            this.modulatorOperatorPage1.Name = "modulatorOperatorPage1";
            this.modulatorOperatorPage1.Size = new System.Drawing.Size(570, 385);
            this.modulatorOperatorPage1.TabIndex = 0;
            // 
            // tabPageOperator2
            // 
            this.tabPageOperator2.Controls.Add(this.carrierOperatorPage1);
            this.tabPageOperator2.Location = new System.Drawing.Point(4, 22);
            this.tabPageOperator2.Name = "tabPageOperator2";
            this.tabPageOperator2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOperator2.Size = new System.Drawing.Size(576, 415);
            this.tabPageOperator2.TabIndex = 1;
            this.tabPageOperator2.Text = "OP 2";
            this.tabPageOperator2.UseVisualStyleBackColor = true;
            // 
            // carrierOperatorPage1
            // 
            this.carrierOperatorPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carrierOperatorPage1.Location = new System.Drawing.Point(3, 3);
            this.carrierOperatorPage1.Margin = new System.Windows.Forms.Padding(4);
            this.carrierOperatorPage1.Name = "carrierOperatorPage1";
            this.carrierOperatorPage1.Size = new System.Drawing.Size(570, 409);
            this.carrierOperatorPage1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewInstrumentToolStripMenuItem});
            this.viewToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.viewToolStripMenuItem.MergeIndex = 1;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // previewInstrumentToolStripMenuItem
            // 
            this.previewInstrumentToolStripMenuItem.Name = "previewInstrumentToolStripMenuItem";
            this.previewInstrumentToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.previewInstrumentToolStripMenuItem.Text = "Preview Instrument...";
            this.previewInstrumentToolStripMenuItem.Click += new System.EventHandler(this.previewInstrumentToolStripMenuItem_Click);
            // 
            // InstrumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 479);
            this.Name = "InstrumentForm";
            this.Text = "Instrument";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageOperator1.ResumeLayout(false);
            this.tabPageOperator2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabPage tabPageOperator1;
        private System.Windows.Forms.TabPage tabPageOperator2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewInstrumentToolStripMenuItem;
        private ModulatorOperatorPage modulatorOperatorPage1;
        private System.Windows.Forms.ImageList imageList1;
        private CarrierOperatorPage carrierOperatorPage1;
        public System.Windows.Forms.TabControl tabControl1;
    }
}

