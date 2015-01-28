using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace CustomerData
{
    partial class ctlMainInterface
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
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.tlpMain = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.txtSearch = new Gizmox.WebGUI.Forms.TextBox();
            this.pnlContent = new Gizmox.WebGUI.Forms.Panel();
            this.pnlOpenCustomers = new Gizmox.WebGUI.Forms.Panel();
            this.tcOpenCust = new Gizmox.WebGUI.Forms.TabControl();
            this.pnlResults = new Gizmox.WebGUI.Forms.Panel();
            this.dgResults = new Gizmox.WebGUI.Forms.DataGridView();
            this.dcClientCode = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dcFname = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dcLname = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.pnlContent.SuspendLayout();
            this.pnlOpenCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcOpenCust)).BeginInit();
            this.pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.White;
            this.tlpMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpMain.Controls.Add(this.pnlContent, 0, 1);
            this.tlpMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(391, 306);
            this.tlpMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 2, 0);
            this.tableLayoutPanel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(184, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(244, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.EnterKeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.txtSearch_EnterKeyDown);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlOpenCustomers);
            this.pnlContent.Controls.Add(this.pnlResults);
            this.pnlContent.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 35);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(391, 271);
            this.pnlContent.TabIndex = 0;
            // 
            // pnlOpenCustomers
            // 
            this.pnlOpenCustomers.Controls.Add(this.tcOpenCust);
            this.pnlOpenCustomers.Location = new System.Drawing.Point(184, 30);
            this.pnlOpenCustomers.Name = "pnlOpenCustomers";
            this.pnlOpenCustomers.Size = new System.Drawing.Size(152, 156);
            this.pnlOpenCustomers.TabIndex = 0;
            this.pnlOpenCustomers.Visible = false;
            // 
            // tcOpenCust
            // 
            this.tcOpenCust.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tcOpenCust.Location = new System.Drawing.Point(0, 0);
            this.tcOpenCust.Name = "tcOpenCust";
            this.tcOpenCust.ShowCloseButton = true;
            this.tcOpenCust.Size = new System.Drawing.Size(152, 156);
            this.tcOpenCust.TabIndex = 0;
            this.tcOpenCust.CloseClick += new System.EventHandler(this.tcOpenCust_CloseClick);
            this.tcOpenCust.SelectedIndexChanged += new System.EventHandler(this.tcOpenCust_SelectedIndexChanged);
            // 
            // pnlResults
            // 
            this.pnlResults.Controls.Add(this.dgResults);
            this.pnlResults.Location = new System.Drawing.Point(43, 30);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(100, 100);
            this.pnlResults.TabIndex = 0;
            this.pnlResults.Visible = false;
            // 
            // dgResults
            // 
            this.dgResults.AllowUserToAddRows = false;
            this.dgResults.AllowUserToDeleteRows = false;
            this.dgResults.AllowUserToOrderColumns = true;
            this.dgResults.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.dcClientCode,
            this.dcFname,
            this.dcLname});
            this.dgResults.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgResults.Location = new System.Drawing.Point(0, 0);
            this.dgResults.Name = "dgResults";
            this.dgResults.Size = new System.Drawing.Size(100, 100);
            this.dgResults.TabIndex = 0;
            this.dgResults.CellClick += new Gizmox.WebGUI.Forms.DataGridViewCellEventHandler(this.dgResults_CellClick);
            // 
            // dcClientCode
            // 
            this.dcClientCode.DefaultCellStyle = dataGridViewCellStyle7;
            this.dcClientCode.HeaderText = "Client Code";
            this.dcClientCode.Name = "dcClientCode";
            this.dcClientCode.ReadOnly = true;
            // 
            // dcFname
            // 
            this.dcFname.DefaultCellStyle = dataGridViewCellStyle8;
            this.dcFname.HeaderText = "First Name";
            this.dcFname.Name = "dcFname";
            this.dcFname.ReadOnly = true;
            // 
            // dcLname
            // 
            this.dcLname.DefaultCellStyle = dataGridViewCellStyle9;
            this.dcLname.HeaderText = "Last Name";
            this.dcLname.Name = "dcLname";
            this.dcLname.ReadOnly = true;
            // 
            // ctlMainInterface
            // 
            this.AutoSize = true;
            this.Controls.Add(this.tlpMain);
            this.Size = new System.Drawing.Size(391, 306);
            this.Text = "ctlMainInterface";
            this.pnlContent.ResumeLayout(false);
            this.pnlOpenCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcOpenCust)).EndInit();
            this.pnlResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txtSearch;
        private Panel pnlContent;
        private Panel pnlOpenCustomers;
        private TabControl tcOpenCust;
        private Panel pnlResults;
        private DataGridView dgResults;
        private DataGridViewTextBoxColumn dcClientCode;
        private DataGridViewTextBoxColumn dcFname;
        private DataGridViewTextBoxColumn dcLname;
    }
}