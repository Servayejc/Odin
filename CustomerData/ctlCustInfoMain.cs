#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Odin.DataClasses;

#endregion

namespace CustomerData
{
    public partial class ctlCustInfoMain : UserControl
    {
        CustomerItem m_Customer;
        public ctlCustInfoMain(CustomerItem Customer)
        {
            m_Customer = Customer;
            InitializeComponent();

            ctlCustomerInfo info = new ctlCustomerInfo(Customer);
            info.Dock = DockStyle.Fill;

            tpCustInfo.Controls.Add(info);
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedIndex == 1)
            {
                //tax returns
                if (tpTaxReturns.Controls.Count == 0)
                {
                    ctlTaxReturInfo ctltaxreturns = new ctlTaxReturInfo(m_Customer);
                    ctltaxreturns.Dock = DockStyle.Fill;
                    tpTaxReturns.Controls.Add(ctltaxreturns);
                }
            }
            else if (tcMain.SelectedIndex == 2)
            { 
                //contacts
            
            }
        }
    }
}