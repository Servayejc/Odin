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
    public partial class ctlTimeTracker : UserControl
    {
        public ctlTimeTracker(IModule Module, CustomerItem Customer)
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            btnFinalize.Enabled = true;
            btnStart.Enabled = true;
        }
    }
}