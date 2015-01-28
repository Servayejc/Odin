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

namespace CustomerData
{
    
    public partial class ctlCustInfoMain : UserControl
    {
        public event OnUpdateEvent OnUpdate;
        CustomerItem Customer;
        IModule Module;
        public ctlCustInfoMain(CustomerItem Customer, IModule Module)
        {
            this.Module = Module;
            this.Customer = Customer;
            InitializeComponent();
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedIndex == 0)
            {
                //customer info
                if (tpCustInfo.Controls.Count == 0)
                {
                    ctlCustomerInfo info = new ctlCustomerInfo(Module);
                    info.Dock = DockStyle.Fill;
                    info.OnUpdate += info_OnUpdate;
                    tpCustInfo.Controls.Add(info);
                    tpCustInfo.Update();
                    info.UpdateGV(Customer);
                }
                else
                {
                    ctlCustomerInfo info = tpCustInfo.Controls[0] as ctlCustomerInfo;
                    info.UpdateGV(Customer);
                }
            }
            else if (tcMain.SelectedIndex == 1)
            {
                //tax returns
                if (tpTaxReturns.Controls.Count == 0)
                {
                    ctlTaxReturInfo ctltaxreturns = new ctlTaxReturInfo(Customer, Module);
                    ctltaxreturns.Dock = DockStyle.Fill;
                    tpTaxReturns.Controls.Add(ctltaxreturns);
                }
                else
                {
                    ctlTaxReturInfo ctltaxreturns = tpTaxReturns.Controls[0] as ctlTaxReturInfo;
                    ctltaxreturns.UpdateGV();
                }
            }
            else if (tcMain.SelectedIndex == 2)
            { 
                //contacts
                //tax returns
                if (tpContacts.Controls.Count == 0)
                {
                    ctlContacts ctlcontact = new ctlContacts(Customer, Module);
                    ctlcontact.Dock = DockStyle.Fill;
                    tpContacts.Controls.Add(ctlcontact);
                    ctlcontact.UpdateGV(Customer);
                }
                else
                {
                    ctlContacts ctlcontact = tpContacts.Controls[0] as ctlContacts;
                    ctlcontact.UpdateGV(Customer);
                }
            
            }
        }

        void info_OnUpdate()
        {
            if (OnUpdate != null)
                OnUpdate();
        }

        private void ctlCustInfoMain_Load(object sender, EventArgs e)
        {
            tcMain.SelectedIndex = -1;
            tcMain.SelectedIndex = 0;
        }

        public void UpdateCust(CustomerItem Customer)
        {
            if (tpCustInfo.Controls.Count > 0)
            {
                ctlCustomerInfo info = tpCustInfo.Controls[0] as ctlCustomerInfo;
                info.UpdateGV(Customer);
            }

            if (tpTaxReturns.Controls.Count > 0)
            {
                ctlTaxReturInfo ctltaxreturns = tpTaxReturns.Controls[0] as ctlTaxReturInfo;
                ctltaxreturns.UpdateGV();
            }

            if (tpContacts.Controls.Count > 0)
            {
                ctlContacts ctlcontact = tpContacts.Controls[0] as ctlContacts;
                ctlcontact.UpdateGV(Customer);
            }         
        }
    }
}