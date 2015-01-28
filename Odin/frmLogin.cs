#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

#endregion

namespace Odin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginManager manager = new LoginManager(txtUser.Text, txtPass.Text);

            if (manager.IsValid)
            {
                this.Context.IsLoggedOn = true;
                this.Context.Transfer(new frmMain(txtUser.Text));
            }
            else
            {
                lblError.Text = "Invalid Credentials, Please try again.";
                lblError.Visible = true;                    
            }
            
        }

        private void txtPass_EnterKeyDown(object objSender, KeyEventArgs objArgs)
        {
            btnLogin_Click(objSender, new EventArgs());
        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }
    }
}