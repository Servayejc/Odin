using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Odin
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUsername = new Gizmox.WebGUI.Forms.Label();
            this.txtUser = new Gizmox.WebGUI.Forms.TextBox();
            this.txtPass = new Gizmox.WebGUI.Forms.TextBox();
            this.lblPass = new Gizmox.WebGUI.Forms.Label();
            this.lblError = new Gizmox.WebGUI.Forms.Label();
            this.pblogo = new Gizmox.WebGUI.Forms.PictureBox();
            this.btnLogin = new Gizmox.WebGUI.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(42, 56);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(35, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(124, 56);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(124, 89);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(42, 89);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(55, 13);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Password";
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(42, 134);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(301, 39);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "<No Error>";
            this.lblError.Visible = false;
            // 
            // pblogo
            // 
            this.pblogo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Left | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.pblogo.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("pblogo.Image"));
            this.pblogo.Location = new System.Drawing.Point(55, 185);
            this.pblogo.Name = "pblogo";
            this.pblogo.RightToLeft = Gizmox.WebGUI.Forms.RightToLeft.No;
            this.pblogo.Size = new System.Drawing.Size(261, 166);
            this.pblogo.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.CenterImage;
            this.pblogo.TabIndex = 3;
            this.pblogo.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(241, 89);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pblogo);
            this.Size = new System.Drawing.Size(365, 360);
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblUsername;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label lblPass;
        private Label lblError;
        private PictureBox pblogo;
        private Button btnLogin;


    }
}