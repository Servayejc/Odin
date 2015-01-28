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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tlpMain = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.pnlControls = new Gizmox.WebGUI.Forms.HeaderedPanel();
            this.pictureBox1 = new Gizmox.WebGUI.Forms.PictureBox();
            this.btnLogout = new Gizmox.WebGUI.Forms.Button();
            this.tvMenuModule = new Gizmox.WebGUI.Forms.TreeView();
            this.ntModules = new Gizmox.WebGUI.Forms.NavigationTab();
            this.ntAdmin = new Gizmox.WebGUI.Forms.NavigationTab();
            this.ntMenu = new Gizmox.WebGUI.Forms.NavigationTabs();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ntModules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntMenu)).BeginInit();
            this.ntMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 250F));
            this.tlpMain.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpMain.Controls.Add(this.btnLogout, 1, 0);
            this.tlpMain.Controls.Add(this.pnlControls, 1, 1);
            this.tlpMain.Controls.Add(this.ntMenu, 0, 1);
            this.tlpMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(321, 286);
            this.tlpMain.TabIndex = 1;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.CustomStyle = "HeaderedPanel";
            this.pnlControls.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(250, 40);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(71, 246);
            this.pnlControls.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.pictureBox1.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("pictureBox1.Image"));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(250, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(71, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tvMenuModule
            // 
            this.tvMenuModule.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tvMenuModule.Location = new System.Drawing.Point(0, 0);
            this.tvMenuModule.Name = "tvMenuModule";
            this.tvMenuModule.Size = new System.Drawing.Size(242, 217);
            this.tvMenuModule.TabIndex = 0;
            this.tvMenuModule.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.tvMenuModule_AfterSelect);
            // 
            // ntModules
            // 
            this.ntModules.Controls.Add(this.tvMenuModule);
            this.ntModules.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.ntModules.Extra = false;
            this.ntModules.Location = new System.Drawing.Point(0, 0);
            this.ntModules.Name = "ntModules";
            this.ntModules.Size = new System.Drawing.Size(242, 217);
            this.ntModules.TabIndex = 0;
            this.ntModules.Text = "Modules";
            // 
            // ntAdmin
            // 
            this.ntAdmin.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.ntAdmin.Extra = false;
            this.ntAdmin.Location = new System.Drawing.Point(0, 0);
            this.ntAdmin.Name = "ntAdmin";
            this.ntAdmin.Size = new System.Drawing.Size(129, 89);
            this.ntAdmin.TabIndex = 1;
            this.ntAdmin.Text = "Administration";
            // 
            // ntMenu
            // 
            this.ntMenu.Controls.Add(this.ntModules);
            this.ntMenu.Controls.Add(this.ntAdmin);
            this.ntMenu.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.ntMenu.Location = new System.Drawing.Point(0, 40);
            this.ntMenu.Name = "ntMenu";
            this.ntMenu.SelectedIndex = 0;
            this.ntMenu.Size = new System.Drawing.Size(250, 246);
            this.ntMenu.TabIndex = 0;
            // 
            // frmMain
            // 
            this.Controls.Add(this.tlpMain);
            this.Size = new System.Drawing.Size(321, 286);
            this.Text = "Odin";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ntModules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ntMenu)).EndInit();
            this.ntMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.TableLayoutPanel tlpMain;
        private Gizmox.WebGUI.Forms.HeaderedPanel pnlControls;
        private Gizmox.WebGUI.Forms.PictureBox pictureBox1;
        private Gizmox.WebGUI.Forms.Button btnLogout;
        private Gizmox.WebGUI.Forms.NavigationTabs ntMenu;
        private Gizmox.WebGUI.Forms.NavigationTab ntModules;
        private Gizmox.WebGUI.Forms.TreeView tvMenuModule;
        private Gizmox.WebGUI.Forms.NavigationTab ntAdmin;
    }
}