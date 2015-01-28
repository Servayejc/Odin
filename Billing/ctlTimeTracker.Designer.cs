using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Billing
{
    partial class ctlTimeTracker
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

        #region Visual WebGui UserControl Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.cboWorkType = new Gizmox.WebGUI.Forms.ComboBox();
            this.btnStart = new Gizmox.WebGUI.Forms.Button();
            this.btnStop = new Gizmox.WebGUI.Forms.Button();
            this.btnPause = new Gizmox.WebGUI.Forms.Button();
            this.btnFinalize = new Gizmox.WebGUI.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nature of work:";
            // 
            // cboWorkType
            // 
            this.cboWorkType.FormattingEnabled = true;
            this.cboWorkType.Items.AddRange(new object[] {
            "Personal Tax",
            "Corporate Tax",
            "Audit",
            "Payroll"});
            this.cboWorkType.Location = new System.Drawing.Point(115, 16);
            this.cboWorkType.Name = "cboWorkType";
            this.cboWorkType.Size = new System.Drawing.Size(121, 21);
            this.cboWorkType.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(259, 16);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(259, 70);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(259, 43);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            // 
            // btnFinalize
            // 
            this.btnFinalize.Enabled = false;
            this.btnFinalize.Location = new System.Drawing.Point(259, 97);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(75, 23);
            this.btnFinalize.TabIndex = 5;
            this.btnFinalize.Text = "Finalize";
            // 
            // ctlTimeTracker
            // 
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cboWorkType);
            this.Controls.Add(this.label1);
            this.Size = new System.Drawing.Size(488, 137);
            this.Text = "ctlTimeTracker";
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private ComboBox cboWorkType;
        private Button btnStart;
        private Button btnStop;
        private Button btnPause;
        private Button btnFinalize;


    }
}