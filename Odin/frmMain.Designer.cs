namespace Odin
{
    partial class frmMain
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
            this.tlpMain = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.pnlControls = new Gizmox.WebGUI.Forms.HeaderedPanel();
            this.ntMenu = new Gizmox.WebGUI.Forms.NavigationTabs();
            this.ntModules = new Gizmox.WebGUI.Forms.NavigationTab();
            this.tvMenuModule = new Gizmox.WebGUI.Forms.TreeView();
            this.ntAdmin = new Gizmox.WebGUI.Forms.NavigationTab();
            ((System.ComponentModel.ISupportInitialize)(this.ntMenu)).BeginInit();
            this.ntMenu.SuspendLayout();
            this.ntModules.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 250F));
            this.tlpMain.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlControls, 1, 0);
            this.tlpMain.Controls.Add(this.ntMenu, 0, 0);
            this.tlpMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(321, 286);
            this.tlpMain.TabIndex = 1;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.CustomStyle = "HeaderedPanel";
            this.pnlControls.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(250, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(71, 286);
            this.pnlControls.TabIndex = 0;
            // 
            // ntMenu
            // 
            this.ntMenu.Controls.Add(this.ntModules);
            this.ntMenu.Controls.Add(this.ntAdmin);
            this.ntMenu.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.ntMenu.Location = new System.Drawing.Point(0, 0);
            this.ntMenu.Name = "ntMenu";
            this.ntMenu.SelectedIndex = 0;
            this.ntMenu.Size = new System.Drawing.Size(250, 286);
            this.ntMenu.TabIndex = 0;
            // 
            // ntModules
            // 
            this.ntModules.Controls.Add(this.tvMenuModule);
            this.ntModules.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.ntModules.Extra = false;
            this.ntModules.Location = new System.Drawing.Point(0, 0);
            this.ntModules.Name = "ntModules";
            this.ntModules.Size = new System.Drawing.Size(242, 257);
            this.ntModules.TabIndex = 0;
            this.ntModules.Text = "Modules";
            // 
            // tvMenuModule
            // 
            this.tvMenuModule.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tvMenuModule.Location = new System.Drawing.Point(0, 0);
            this.tvMenuModule.Name = "tvMenuModule";
            this.tvMenuModule.Size = new System.Drawing.Size(242, 257);
            this.tvMenuModule.TabIndex = 0;
            this.tvMenuModule.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.tvMenuModule_AfterSelect);
            // 
            // ntAdmin
            // 
            this.ntAdmin.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.ntAdmin.Extra = false;
            this.ntAdmin.Location = new System.Drawing.Point(0, 0);
            this.ntAdmin.Name = "ntAdmin";
            this.ntAdmin.Size = new System.Drawing.Size(242, 257);
            this.ntAdmin.TabIndex = 1;
            this.ntAdmin.Text = "Administration";
            // 
            // frmMain
            // 
            this.Controls.Add(this.tlpMain);
            this.Size = new System.Drawing.Size(321, 286);
            this.Text = "Odin";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ntMenu)).EndInit();
            this.ntMenu.ResumeLayout(false);
            this.ntModules.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.TableLayoutPanel tlpMain;
        private Gizmox.WebGUI.Forms.HeaderedPanel pnlControls;
        private Gizmox.WebGUI.Forms.NavigationTabs ntMenu;
        private Gizmox.WebGUI.Forms.NavigationTab ntModules;
        private Gizmox.WebGUI.Forms.TreeView tvMenuModule;
        private Gizmox.WebGUI.Forms.NavigationTab ntAdmin;
    }
}