#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Odin;
using Odin.DataClasses;

#endregion

namespace Billing
{
    public partial class ctlBillingMain : UserControl
    {
        IModule Module;
        CustomerItem Customer;

        public ctlBillingMain(IModule Module, CustomerItem Customer)
        {
            this.Module = Module;
            this.Customer = Customer;
            InitializeComponent();
        }

        private void tsTimeTracker_Click(object sender, EventArgs e)
        {
            hpMain.Text = "New Time Tracker";
            if (pnlTimeTracker.Controls.Count == 0)
            {
                ctlTimeTracker track = new ctlTimeTracker(Module, Customer);
                track.Dock = DockStyle.Fill;
                pnlCustom.Visible = false;
                pnlTimeTracker.Visible = true;
                pnlTimeTracker.Controls.Add(track);
            }
        }

        private void tsCustom_Click(object sender, EventArgs e)
        {
            hpMain.Text = "New Invoice";
        }
    }
}