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
    public delegate void OnUpdateEvent();
    public partial class ctlCustomerInfo : UserControl
    {
        IModule Module;
        public event OnUpdateEvent OnUpdate;
        private CustomerItem Customer;
        bool Loading = false;
        public ctlCustomerInfo(IModule Module)
        {
            Loading = true;
            this.Module = Module;
            InitializeComponent(); 
        }

        private void ctlCustomerInfo_Load(object sender, EventArgs e)
        {
            Loading = true;
        }

        public void UpdateGV(CustomerItem Customer)
        {
            Loading = true;
            this.Customer = Customer;
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
            Loading = false;
        }

        public void GetCustomer()
        {
            Customer.CodePostal = dgCust.Rows[7].Cells[1].Value.ToString();
            Customer.NomFamille = dgCust.Rows[2].Cells[1].Value.ToString();
            Customer.Prenom = dgCust.Rows[1].Cells[1].Value.ToString();
            Customer.Numero = dgCust.Rows[4].Cells[1].Value.ToString();
            Customer.Rue = dgCust.Rows[5].Cells[1].Value.ToString();
            Customer.Ville = dgCust.Rows[6].Cells[1].Value.ToString();
            Customer.Province = dgCust.Rows[8].Cells[1].Value.ToString();
            Customer.Pays = dgCust.Rows[9].Cells[1].Value.ToString();
        }

        private void dgCust_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgCust_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!Loading)
            {
                GetCustomer();

                SQLHelper sh = new SQLHelper();
                sh.ExecuteNonQuery(@"Update Customers set CodePostal=@CodePostal,NomFamille=@NomFamille,
                                Prenom=@Prenom,Numero=@Numero,
                                Rue=@Rue,Ville=@Ville,
                                  Province=@Province,Pays=@Pays where NAS=@NAS",
                                   new List<string> { "@CodePostal", "@NomFamille", "@Prenom", "@Numero", "@Rue", "@Ville", "@Province", "@Pays", "@NAS" },
                                   new List<object> { Customer.CodePostal, Customer.NomFamille, Customer.Prenom, Customer.Numero, Customer.Rue, Customer.Ville, Customer.Province, Customer.Pays, Customer.NAS }, CommandType.Text);
                sh.ExecuteNonQuery(@"Insert Into UpdateStatuses  (NAS,TaxYear,FileName) Values (@NAS,@TaxYear,@FileName)",
                                   new List<string> { "@NAS", "@TaxYear", "@FileName" },
                                   new List<object> { Customer.NAS, 2014, Customer.FileName }, CommandType.Text);
                if (OnUpdate != null)
                    OnUpdate();
            }
        }
    }
}