﻿namespace OPL3FMInstrumentTester
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
            this.tabControlOperators = new System.Windows.Forms.TabControl();
            this.tabPageOperator1 = new System.Windows.Forms.TabPage();
            this.tabPageOperator2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewInstrumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulatorOperatorPage1 = new OPL3FMInstrumentTester.ModulatorOperatorPage();
            this.carrierOperatorPage1 = new OPL3FMInstrumentTester.CarrierOperatorPage();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControlOperators.SuspendLayout();
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControlOperators);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(779, 543);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(779, 543);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // tabControlOperators
            // 
            this.tabControlOperators.Controls.Add(this.tabPageOperator1);
            this.tabControlOperators.Controls.Add(this.tabPageOperator2);
            this.tabControlOperators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOperators.Location = new System.Drawing.Point(0, 0);
            this.tabControlOperators.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlOperators.Name = "tabControlOperators";
            this.tabControlOperators.SelectedIndex = 0;
            this.tabControlOperators.Size = new System.Drawing.Size(779, 543);
            this.tabControlOperators.TabIndex = 0;
            // 
            // tabPageOperator1
            // 
            this.tabPageOperator1.Controls.Add(this.modulatorOperatorPage1);
            this.tabPageOperator1.Location = new System.Drawing.Point(4, 25);
            this.tabPageOperator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageOperator1.Name = "tabPageOperator1";
            this.tabPageOperator1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageOperator1.Size = new System.Drawing.Size(771, 514);
            this.tabPageOperator1.TabIndex = 0;
            this.tabPageOperator1.Text = "OP 1";
            this.tabPageOperator1.UseVisualStyleBackColor = true;
            // 
            // tabPageOperator2
            // 
            this.tabPageOperator2.Controls.Add(this.carrierOperatorPage1);
            this.tabPageOperator2.Location = new System.Drawing.Point(4, 25);
            this.tabPageOperator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageOperator2.Name = "tabPageOperator2";
            this.tabPageOperator2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageOperator2.Size = new System.Drawing.Size(771, 514);
            this.tabPageOperator2.TabIndex = 1;
            this.tabPageOperator2.Text = "OP 2";
            this.tabPageOperator2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(61, 28);
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
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "&View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // previewInstrumentToolStripMenuItem
            // 
            this.previewInstrumentToolStripMenuItem.Name = "previewInstrumentToolStripMenuItem";
            this.previewInstrumentToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.previewInstrumentToolStripMenuItem.Text = "Preview Instrument...";
            this.previewInstrumentToolStripMenuItem.Click += new System.EventHandler(this.previewInstrumentToolStripMenuItem_Click);
            // 
            // modulatorOperatorPage1
            // 
            this.modulatorOperatorPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modulatorOperatorPage1.Location = new System.Drawing.Point(4, 4);
            this.modulatorOperatorPage1.Margin = new System.Windows.Forms.Padding(5);
            this.modulatorOperatorPage1.Name = "modulatorOperatorPage1";
            this.modulatorOperatorPage1.Size = new System.Drawing.Size(763, 506);
            this.modulatorOperatorPage1.TabIndex = 0;
            // 
            // carrierOperatorPage1
            // 
            this.carrierOperatorPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carrierOperatorPage1.Location = new System.Drawing.Point(4, 4);
            this.carrierOperatorPage1.Margin = new System.Windows.Forms.Padding(5);
            this.carrierOperatorPage1.Name = "carrierOperatorPage1";
            this.carrierOperatorPage1.Size = new System.Drawing.Size(763, 506);
            this.carrierOperatorPage1.TabIndex = 0;
            // 
            // InstrumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 543);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(794, 579);
            this.Name = "InstrumentForm";
            this.Text = "Instrument";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InstrumentForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControlOperators.ResumeLayout(false);
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
        public System.Windows.Forms.TabControl tabControlOperators;
    }
}

