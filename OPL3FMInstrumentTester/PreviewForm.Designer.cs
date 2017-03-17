namespace OPL3FMInstrumentTester
{
    partial class PreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSingleNote = new System.Windows.Forms.Button();
            this.buttonCMajorChord = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.buttonSingleNote, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCMajorChord, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // buttonSingleNote
            // 
            resources.ApplyResources(this.buttonSingleNote, "buttonSingleNote");
            this.buttonSingleNote.Name = "buttonSingleNote";
            this.buttonSingleNote.UseVisualStyleBackColor = true;
            this.buttonSingleNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonSingleNote_KeyDown);
            this.buttonSingleNote.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonSingleNote_KeyUp);
            this.buttonSingleNote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSingleNote_MouseDown);
            this.buttonSingleNote.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonSingleNote_MouseUp);
            // 
            // buttonCMajorChord
            // 
            resources.ApplyResources(this.buttonCMajorChord, "buttonCMajorChord");
            this.buttonCMajorChord.Name = "buttonCMajorChord";
            this.buttonCMajorChord.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PreviewForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreviewForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreviewForm_FormClosing);
            this.Load += new System.EventHandler(this.PreviewForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSingleNote;
        private System.Windows.Forms.Button buttonCMajorChord;
        private System.Windows.Forms.Timer timer1;
    }
}