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
    public partial class ctlCustomerInfo : UserControl
    {
        IModule Module;    
           
        public ctlCustomerInfo(IModule Module)
        {
             this.Module = Module;
            InitializeComponent(); 
        }

        private void ctlCustomerInfo_Load(object sender, EventArgs e)
        {
               
        }

        public void UpdateGV(CustomerItem Customer)
        {
            dgCust.Dock = DockStyle.None;
            dgCust.Rows.Clear();
            dgCust.Rows.Add(new object[] { "Client Code", Customer.CodeClient });
            dgCust.Rows.Add(new object[] { "First Name", Customer.Prenom });
            dgCust.Rows.Add(new object[] { "Last Name", Customer.NomFamille });
            dgCust.Rows.Add(new object[] { string.Empty, string.Empty });
            dgCust.Rows.Add(new object[] { "Street Number", Customer.Numero });
            dgCust.Rows.Add(new object[] { "Street", Customer.Rue });
            dgCust.Rows.Add(new object[] { "City", Customer.Ville });
            dgCust.Rows.Add(new object[] { "Postal Code", Customer.CodePostal });
            dgCust.Rows.Add(new object[] { "Province", Customer.Province });
            dgCust.Rows.Add(new object[] { "Country", Customer.Pays });
            dgCust.Dock = DockStyle.Fill;

            foreach (DataGridViewColumn dc in dgCust.Columns)
            {
                dc.Width = dgCust.Width / 2;
            }
        }
    }
}