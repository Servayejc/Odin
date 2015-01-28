using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace CustomerData
{
    partial class ctlCustomerInfo
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
            this.dgCust = new Gizmox.WebGUI.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCust)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCust
            // 
            this.dgCust.AllowUserToAddRows = false;
            this.dgCust.AllowUserToDeleteRows = false;
            this.dgCust.AllowUserToOrderColumns = true;
            this.dgCust.ColumnHeadersVisible = false;
            this.dgCust.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgCust.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgCust.Location = new System.Drawing.Point(0, 0);
            this.dgCust.Name = "dgCust";
            this.dgCust.RowHeadersVisible = false;
            this.dgCust.Size = new System.Drawing.Size(391, 306);
            this.dgCust.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn1.HeaderText = ".";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn2.HeaderText = ".";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ctlCustomerInfo
            // 
            this.Controls.Add(this.dgCust);
            this.Size = new System.Drawing.Size(391, 306);
            this.Text = "ctlCustomerInfo";
            this.Load += new System.EventHandler(this.ctlCustomerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgCust;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;


    }
}