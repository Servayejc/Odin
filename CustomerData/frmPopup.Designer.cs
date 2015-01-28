using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace CustomerData
{
    partial class frmPopup
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

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.txtReason = new Gizmox.WebGUI.Forms.TextBox();
            this.txtDetails = new Gizmox.WebGUI.Forms.TextBox();
            this.tableLayoutPanel1 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.headeredPanel1 = new Gizmox.WebGUI.Forms.HeaderedPanel();
            this.headeredPanel2 = new Gizmox.WebGUI.Forms.HeaderedPanel();
            this.panel1 = new Gizmox.WebGUI.Forms.Panel();
            this.headeredPanel1.SuspendLayout();
            this.headeredPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(247, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = Gizmox.WebGUI.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(352, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtReason
            // 
            this.txtReason.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtReason.Location = new System.Drawing.Point(0, 0);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ScrollBars = Gizmox.WebGUI.Forms.ScrollBars.Both;
            this.txtReason.Size = new System.Drawing.Size(434, 173);
            this.txtReason.TabIndex = 4;
            // 
            // txtDetails
            // 
            this.txtDetails.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtDetails.Location = new System.Drawing.Point(0, 0);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ScrollBars = Gizmox.WebGUI.Forms.ScrollBars.Both;
            this.txtDetails.Size = new System.Drawing.Size(434, 173);
            this.txtDetails.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.headeredPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.headeredPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(436, 381);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // headeredPanel1
            // 
            this.headeredPanel1.Controls.Add(this.txtReason);
            this.headeredPanel1.CustomStyle = "HeaderedPanel";
            this.headeredPanel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.headeredPanel1.Location = new System.Drawing.Point(0, 0);
            this.headeredPanel1.Name = "headeredPanel1";
            this.headeredPanel1.Size = new System.Drawing.Size(436, 175);
            this.headeredPanel1.TabIndex = 0;
            this.headeredPanel1.Text = "Reason";
            // 
            // headeredPanel2
            // 
            this.headeredPanel2.Controls.Add(this.txtDetails);
            this.headeredPanel2.CustomStyle = "HeaderedPanel";
            this.headeredPanel2.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.headeredPanel2.Location = new System.Drawing.Point(0, 175);
            this.headeredPanel2.Name = "headeredPanel2";
            this.headeredPanel2.Size = new System.Drawing.Size(436, 175);
            this.headeredPanel2.TabIndex = 0;
            this.headeredPanel2.Text = "Details";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 31);
            this.panel1.TabIndex = 0;
            // 
            // frmPopup
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Size = new System.Drawing.Size(436, 381);
            this.Text = "frmPopup";
            this.FormClosing += new Gizmox.WebGUI.Forms.Form.FormClosingEventHandler(this.frmPopup_FormClosing);
            this.headeredPanel1.ResumeLayout(false);
            this.headeredPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TextBox txtReason;
        private TextBox txtDetails;
        private TableLayoutPanel tableLayoutPanel1;
        private HeaderedPanel headeredPanel1;
        private HeaderedPanel headeredPanel2;
        private Panel panel1;


    }
}