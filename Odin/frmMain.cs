#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

#endregion

namespace Odin
{
    public partial class frmMain : Form
    {
        string User;
        public frmMain(string User)
        {
            this.User = User;
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!this.Context.IsLoggedOn)
            {
                this.Context.Transfer(new frmLogin());
            }
            else
            {
                ModuleGlobal mg = new ModuleGlobal();
                mg.User = User;
                ModuleManager manager = new ModuleManager();
                manager.LoadModules(mg);

                foreach (IModule module in manager.AvailableModules)
                {
                    tvMenuModule.Nodes.Add(new TreeNode { Tag = module, Name = module.ModuleID.ToString(), Text = module.ModuleName });
                    if (module.Order == 1)
                    {
                        tvMenuModule.SelectedNode = tvMenuModule.Nodes[tvMenuModule.Nodes.Count - 1];
                    }                        
                }
               
               

            }
        }

        private void tvMenuModule_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                UserControl ctl = ((IModule)e.Node.Tag).MainInterface;
                ctl.Dock = DockStyle.Fill;           
                pnlControls.Controls.Clear();
                pnlControls.Controls.Add(ctl);
                pnlControls.Text = ((IModule)e.Node.Tag).ModuleName;
            } 
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Context.IsLoggedOn = false;
            this.Context.Transfer(new frmLogin());
        }
    }
}