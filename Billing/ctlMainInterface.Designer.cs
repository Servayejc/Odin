using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Billing
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
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.pnlOpenCustomers = new Gizmox.WebGUI.Forms.Panel();
            this.dgResults = new Gizmox.WebGUI.Forms.DataGridView();
            this.dcClientCode = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dcFname = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dcLname = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.pnlResults = new Gizmox.WebGUI.Forms.Panel();
            this.pnlContent = new Gizmox.WebGUI.Forms.Panel();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.txtSearch = new Gizmox.WebGUI.Forms.TextBox();
            this.tableLayoutPanel1 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.tcOpenCust = new Gizmox.WebGUI.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.pnlResults.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcOpenCust)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOpenCustomers
            // 
            this.pnlOpenCustomers.Location = new System.Drawing.Point(184, 30);
            this.pnlOpenCustomers.Name = "pnlOpenCustomers";
            this.pnlOpenCustomers.Size = new System.Drawing.Size(152, 156);
            this.pnlOpenCustomers.TabIndex = 0;
            this.pnlOpenCustomers.Controls.Add(tcOpenCust);
            this.pnlOpenCustomers.Visible = false;
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
            this.dcClientCode.DefaultCellStyle = dataGridViewCellStyle1;
            this.dcClientCode.HeaderText = "Client Code";
            this.dcClientCode.Name = "dcClientCode";
            this.dcClientCode.ReadOnly = true;
            // 
            // dcFname
            // 
            this.dcFname.DefaultCellStyle = dataGridViewCellStyle2;
            this.dcFname.HeaderText = "First Name";
            this.dcFname.Name = "dcFname";
            this.dcFname.ReadOnly = true;
            // 
            // dcLname
            // 
            this.dcLname.DefaultCellStyle = dataGridViewCellStyle3;
            this.dcLname.HeaderText = "Last Name";
            this.dcLname.Name = "dcLname";
            this.dcLname.ReadOnly = true;
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
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlOpenCustomers);
            this.pnlContent.Controls.Add(this.pnlResults);
            this.pnlContent.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 35);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(652, 496);
            this.pnlContent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(344, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(393, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(256, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.EnterKeyDown += new Gizmox.WebGUI.Forms.KeyEventHandler(this.txtSearch_EnterKeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 52.76073F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 7.055215F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 40.03067F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(652, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlContent, 0, 1);
            this.tableLayoutPanel2.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(652, 531);
            this.tableLayoutPanel2.TabIndex = 1;
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
            // ctlMainInterface
            // 
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Size = new System.Drawing.Size(652, 531);
            this.Text = "ctlMainInterface";
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.pnlResults.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcOpenCust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlOpenCustomers;
        private DataGridView dgResults;
        private DataGridViewTextBoxColumn dcClientCode;
        private DataGridViewTextBoxColumn dcFname;
        private DataGridViewTextBoxColumn dcLname;
        private Panel pnlResults;
        private Panel pnlContent;
        private Label label1;
        private TextBox txtSearch;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TabControl tcOpenCust;





    }
}