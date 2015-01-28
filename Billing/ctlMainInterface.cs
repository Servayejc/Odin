#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Common.Resources;
using Gizmox.WebGUI.Forms;
using Odin;
using Odin.DataClasses;

#endregion

namespace Billing
{
    public partial class ctlMainInterface : UserControl
    {
        IModule Module;
        public ctlMainInterface(IModule Module)
        {
            this.Module = Module;
            InitializeComponent();           
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
                      ,[CodePostal], [FileName]
                  FROM [Odin].[dbo].[Customers]
                  where CodeClient like @Search OR 
                       Prenom Like @Search OR
                        NomFamille Like @Search OR
                        NAS = @Search OR
                        Ville Like @Search OR
                        Rue Like @Search OR
                        Numero Like @Search OR
                        Province Like @Search OR
                        Pays Like @Search OR
                        CodePostal Like @Search OR
                        (Prenom + ' ' + NomFamille) Like @Search",
                         new List<string> { "@Search" },
                         new List<object> { SearchValue }, CommandType.Text);
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
                    ci.FileName = dr["FileName"] != DBNull.Value ? dr["FileName"].ToString() : string.Empty;
                    Customers.Add(ci);
                }

                return Customers;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void UpdateCustomer(CustomerItem Customer)
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
                      ,[CodePostal], [FileName]
                  FROM [Odin].[dbo].[Customers]
                  where NAS = @Search",
                     new List<string> { "@Search" },
                     new List<object> { Customer.NAS }, CommandType.Text);

            CustomerItem ci = new CustomerItem();
            foreach (DataRow dr in dt.Rows)
            {
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
                ci.FileName = dr["FileName"] != DBNull.Value ? dr["FileName"].ToString() : string.Empty;
                Customer = ci;

            }

            bool found = false;
            int idx = -1;
            foreach (TabPage tab in tcOpenCust.TabPages)
            {
                idx++;
                if (tab.Name.StartsWith(Customer.CodeClient + "~"))
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                tcOpenCust.TabPages[idx].Text = Customer.CodeClient + " (" + Customer.Prenom + " " + Customer.NomFamille + ")";
                if (tcOpenCust.TabPages[idx].Controls[0] != null)
                {
                    //((ctlCustInfoMain)tcOpenCust.TabPages[idx].Controls[0]).UpdateCust(Customer);
                }
            }


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
                dgResults.Rows.Add(new object[] { cust.CodeClient, cust.Prenom, cust.NomFamille });
                dgResults.Rows[dgResults.Rows.Count - 1].Tag = cust;
            }

        }

        private void dgResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerItem cust = dgResults.Rows[e.RowIndex].Tag as CustomerItem;

            bool found = false;
            int idx = -1;
            foreach (TabPage tab in tcOpenCust.TabPages)
            {
                idx++;
                if (tab.Name.StartsWith(cust.CodeClient + "~"))
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                TabPage tp = new TabPage();
                tp.Name = cust.CodeClient + "~" + Guid.NewGuid().ToString();
                tp.Text = cust.CodeClient + " (" + cust.Prenom + " " + cust.NomFamille + ")";
                tp.Tag = cust;

                ctlBillingMain bill = new ctlBillingMain(Module, cust);
                bill.Dock = DockStyle.Fill;
                tp.Controls.Add(bill);

                ShowClients();

                tcOpenCust.TabPages.Add(tp);

                tcOpenCust.SelectedIndex = tcOpenCust.TabPages.Count - 1;
            }
            else
            {
                ShowClients();
                tcOpenCust.SelectedIndex = idx;
                UpdateCustomer(cust);
            }

        }

        void ctlmain_OnUpdate()
        {
            UpdateCustomer(((CustomerItem)tcOpenCust.SelectedItem.Tag));
        }

        private void ShowClients()
        {
            pnlResults.Dock = DockStyle.None;
            pnlResults.Visible = false;

            pnlOpenCustomers.Dock = DockStyle.Fill;
            pnlOpenCustomers.Visible = true;
        }

        private void tcOpenCust_CloseClick(object sender, EventArgs e)
        {
            tcOpenCust.TabPages[tcOpenCust.SelectedIndex].Controls[0].Dispose();
            tcOpenCust.TabPages.RemoveAt(tcOpenCust.SelectedIndex);
        }

        private void tcOpenCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCustomer(((TabControl)sender).SelectedTab.Tag as CustomerItem);
        }

    }
}