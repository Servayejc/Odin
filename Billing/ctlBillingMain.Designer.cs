using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Billing
{
    partial class ctlBillingMain
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
            this.tableLayoutPanel1 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.toolStrip1 = new Gizmox.WebGUI.Forms.ToolStrip();
            this.tnNew = new Gizmox.WebGUI.Forms.ToolStripDropDownButton();
            this.tsTimeTracker = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.tsCustom = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.hpMain = new Gizmox.WebGUI.Forms.HeaderedPanel();
            this.pnlTimeTracker = new Gizmox.WebGUI.Forms.Panel();
            this.pnlCustom = new Gizmox.WebGUI.Forms.Panel();
            this.hpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hpMain, 0, 1);
            this.tableLayoutPanel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 306);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.tnNew});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(391, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tnNew
            // 
            this.tnNew.DisplayStyle = Gizmox.WebGUI.Forms.ToolStripItemDisplayStyle.Text;
            this.tnNew.DropDownItems.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.tsTimeTracker,
            this.tsCustom});
            this.tnNew.Name = "toolStripDropDownButton1";
            this.tnNew.Size = new System.Drawing.Size(41, 17);
            this.tnNew.Text = "&New";
            // 
            // tsTimeTracker
            // 
            this.tsTimeTracker.Name = "toolStripMenuItem2";
            this.tsTimeTracker.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.tsTimeTracker.Size = new System.Drawing.Size(152, 20);
            this.tsTimeTracker.Text = "&Time Tracker";
            this.tsTimeTracker.Click += new System.EventHandler(this.tsTimeTracker_Click);
            // 
            // tsCustom
            // 
            this.tsCustom.Name = "toolStripMenuItem3";
            this.tsCustom.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.tsCustom.Size = new System.Drawing.Size(152, 20);
            this.tsCustom.Text = "&Custom Invoice";
            this.tsCustom.Click += new System.EventHandler(this.tsCustom_Click);
            // 
            // hpMain
            // 
            this.hpMain.Controls.Add(this.pnlCustom);
            this.hpMain.Controls.Add(this.pnlTimeTracker);
            this.hpMain.CustomStyle = "HeaderedPanel";
            this.hpMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.hpMain.Location = new System.Drawing.Point(0, 25);
            this.hpMain.Name = "hpMain";
            this.hpMain.Size = new System.Drawing.Size(391, 281);
            this.hpMain.TabIndex = 0;
            // 
            // pnlTimeTracker
            // 
            this.pnlTimeTracker.Location = new System.Drawing.Point(81, 59);
            this.pnlTimeTracker.Name = "pnlTimeTracker";
            this.pnlTimeTracker.Size = new System.Drawing.Size(100, 100);
            this.pnlTimeTracker.TabIndex = 0;
            // 
            // pnlCustom
            // 
            this.pnlCustom.Location = new System.Drawing.Point(224, 59);
            this.pnlCustom.Name = "pnlCustom";
            this.pnlCustom.Size = new System.Drawing.Size(100, 100);
            this.pnlCustom.TabIndex = 1;
            // 
            // ctlBillingMain
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Size = new System.Drawing.Size(391, 306);
            this.Text = "ctlBillingMain";
            this.hpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton tnNew;
        private ToolStripMenuItem tsTimeTracker;
        private ToolStripMenuItem tsCustom;
        private HeaderedPanel hpMain;
        private Panel pnlCustom;
        private Panel pnlTimeTracker;


    }
}