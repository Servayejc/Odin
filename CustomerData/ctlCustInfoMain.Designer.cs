using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace CustomerData
{
    partial class ctlCustInfoMain
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
            this.tpCustInfo = new Gizmox.WebGUI.Forms.TabPage();
            this.tpTaxReturns = new Gizmox.WebGUI.Forms.TabPage();
            this.tabPage2 = new Gizmox.WebGUI.Forms.TabPage();
            this.tcMain = new Gizmox.WebGUI.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpCustInfo
            // 
            this.tpCustInfo.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpCustInfo.Location = new System.Drawing.Point(4, 22);
            this.tpCustInfo.Name = "tpCustInfo";
            this.tpCustInfo.Size = new System.Drawing.Size(383, 280);
            this.tpCustInfo.TabIndex = 0;
            this.tpCustInfo.Text = "Customer Information";
            // 
            // tpTaxReturns
            // 
            this.tpTaxReturns.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpTaxReturns.Location = new System.Drawing.Point(0, 0);
            this.tpTaxReturns.Name = "tpTaxReturns";
            this.tpTaxReturns.Size = new System.Drawing.Size(383, 280);
            this.tpTaxReturns.TabIndex = 1;
            this.tpTaxReturns.Text = "Tax Returns";
            // 
            // tabPage2
            // 
            this.tabPage2.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(383, 280);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Contacts";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpCustInfo);
            this.tcMain.Controls.Add(this.tpTaxReturns);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(391, 306);
            this.tcMain.TabIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // ctlCustInfoMain
            // 
            this.Controls.Add(this.tcMain);
            this.Size = new System.Drawing.Size(391, 306);
            this.Text = "ctlCustInfoMain";
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tpCustInfo;
        private TabPage tpTaxReturns;
        private TabPage tabPage2;
        private TabControl tcMain;


    }
}