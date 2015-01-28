#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Odin;
using Odin.DataClasses;

#endregion

namespace CustomerData
{
    public partial class ctlMainInterface : UserControl
    {
        public ctlMainInterface()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyDown(object objSender, KeyEventArgs objArgs)
        {
          
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private List<CustomerItem> LoadCustomers(string SearchValue)
        {
            try
            {
                SQLHelper sh = new SQLHelper();
                DataTable dt = sh.GetData(@"SELECT [Prenom]
                      ,[NomFamille]
                      ,[CodeClient]
                      ,[NAS]
                      ,[Ville]
                      ,[Rue]
                      ,[Numero]
                      ,[Province]
                      ,[Pays]
                      ,[CodePostal]
                  FROM [Odin].[dbo].[Customers]
                  where CodeClient = @CodeClient", new List<string> { "@CodeClient" }, new List<object> { SearchValue }, CommandType.Text);
                List<CustomerItem> Customers = new List<CustomerItem>();
                foreach (DataRow dr in dt.Rows)
                {
                    CustomerItem ci = new CustomerItem();
                    ci.CodeClient = dr["CodeClient"] != DBNull.Value ? dr["CodeClient"].ToString() : string.Empty;
                    ci.Prenom = dr["Prenom"] != DBNull.Value ? dr["Prenom"].ToString() : string.Empty;
                    ci.NomFamille = dr["NomFamille"] != DBNull.Value ? dr["NomFamille"].ToString() : string.Empty;
                    ci.NAS = dr["NAS"] != DBNull.Value ? dr["NAS"].ToString() : string.Empty;
                    ci.Ville = dr["Ville"] != DBNull.Value ? dr["Ville"].ToString() : string.Empty;
                    ci.Rue = dr["Rue"] != DBNull.Value ? dr["Rue"].ToString() : string.Empty;
                    ci.Numero = dr["Numero"] != DBNull.Value ? dr["Numero"].ToString() : string.Empty;
                    ci.Province = dr["Province"] != DBNull.Value ? dr["Province"].ToString() : string.Empty;
                    ci.Pays = dr["Pays"] != DBNull.Value ? dr["Pays"].ToString() : string.Empty;
                    ci.CodePostal = dr["CodePostal"] != DBNull.Value ? dr["CodePostal"].ToString() : string.Empty;
                    Customers.Add(ci);
                }

                return Customers;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtSearch_EnterKeyDown(object objSender, KeyEventArgs objArgs)
        {
            List<CustomerItem> Customers = LoadCustomers(txtSearch.Text);

            pnlResults.Dock = DockStyle.Fill;
            pnlResults.Visible = true;

            pnlOpenCustomers.Dock = DockStyle.None;
            pnlOpenCustomers.Visible = false;

            dgResults.Rows.Clear();

            foreach (CustomerItem cust in Customers)
            {                
                dgResults.Rows.Add(new object[]{cust.CodeClient,cust.Prenom, cust.NomFamille});
                dgResults.Rows[dgResults.Rows.Count - 1].Tag = cust;
            }
            
        }

        private void tlpMain_Click(object sender, EventArgs e)
        {

        }

        private void dgResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerItem cust = dgResults.Rows[e.RowIndex].Tag as CustomerItem;

            TabPage tp = new TabPage();
            tp.Name = cust.CodeClient + "~" + new Guid().ToString();
            tp.Text = cust.CodeClient + "(" + cust.Prenom + " " + cust.NomFamille + " )";

            ctlCustInfoMain ctlmain = new ctlCustInfoMain(cust);
            ctlmain.Dock = DockStyle.Fill;
            tp.Controls.Add(ctlmain);

            tcOpenCust.TabPages.Add(tp);

            pnlResults.Dock = DockStyle.None;
            pnlResults.Visible = false;
            
            pnlOpenCustomers.Dock = DockStyle.Fill;
            pnlOpenCustomers.Visible = true;

        }

    }
}