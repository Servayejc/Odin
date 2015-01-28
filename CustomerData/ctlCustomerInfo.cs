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
    public partial class ctlCustomerInfo : UserControl
    {
        CustomerItem Customer;
        public ctlCustomerInfo(CustomerItem Customer)
        {
            this.Customer = Customer;
            InitializeComponent();                       

        }

        private void ctlCustomerInfo_Load(object sender, EventArgs e)
        {
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

            foreach (DataGridViewColumn dc in dgCust.Columns)
            {
                dc.Width = dgCust.Width / 2;                          
            }
           
        }


    }
}