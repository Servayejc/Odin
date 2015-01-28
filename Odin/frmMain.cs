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
        public frmMain()
        {
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
                ModuleManager manager = new ModuleManager();
                manager.LoadModules();

                IModule module = manager.GetModuleByName("Customer Data");
                if (module != null)
                {
                    module.MainInterface.Dock = DockStyle.Fill;
                    pnlControls.Controls.Clear();
                    pnlControls.Controls.Add(module.MainInterface);
                }

            }
        }
    }
}