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
    public partial class ctlContacts : UserControl
    {
        frmPopup pop;
        CustomerItem Customer;
        public ctlContacts(CustomerItem Customer)
        {
            this.Customer = Customer;
            InitializeComponent();
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            pop = new frmPopup();
            pop.Text = "New event";
            pop.ClosePop += new OnPopClose(Close_Pop);
            pop.ShowDialog();
        }

        private void Close_Pop()
        {
            
        }

        public void UpdateGV(CustomerItem Customer)
        {

            List<ContactItem> Contacts = GetContacts(Customer);
            gvContacts.Rows.Clear();
            foreach (ContactItem ci in Contacts)
            {
                gvContacts.Rows.Add(new object[] { ci.Reason.Length >= 25 ? ci.Reason.Substring(0, 25) : ci.Reason, ci.Details.Length >= 25 ? ci.Details.Substring(0, 25) : ci.Details, ci.UserName, ci.DateContact });
                gvContacts.Rows[gvContacts.Rows.Count - 1].Cells[0].ToolTipText = ci.Reason;
                gvContacts.Rows[gvContacts.Rows.Count - 1].Cells[1].ToolTipText = ci.Details;
            }

            foreach (DataGridViewColumn dc in gvContacts.Columns)
            {
                dc.Width = gvContacts.Width / 4;
            }


        }

        private List<ContactItem> GetContacts(CustomerItem Customer)
        {
            SQLHelper sh = new SQLHelper();
            DataTable dt = sh.GetData(@"SELECT [Reason]
                                          ,[Details]
                                          ,[DateContact]
                                          ,[Customers_Nas]
                                          ,[UserName]
                                      FROM [Odin].[dbo].[Contacts]
                                      WHERE [Customers_Nas] = @Customers_Nas order by DateContact desc", new List<string> { "@Customers_Nas" }, new List<object> { Customer.NAS }, CommandType.Text);
            List<ContactItem> Contacts = new List<ContactItem>();
            foreach (DataRow dr in dt.Rows)
            {
                ContactItem ci = new ContactItem();
                ci.Customers_Nas = dr["Customers_Nas"] != DBNull.Value ? dr["Customers_Nas"].ToString() : string.Empty;
                ci.DateContact = dr["DateContact"] != DBNull.Value ? (DateTime)dr["DateContact"] : DateTime.MinValue;
                ci.Details = dr["Details"] != DBNull.Value ? dr["Details"].ToString() : string.Empty;
                ci.Reason = dr["Reason"] != DBNull.Value ? dr["Reason"].ToString() : string.Empty;
                ci.UserName = dr["UserName"] != DBNull.Value ? dr["UserName"].ToString() : string.Empty;
                Contacts.Add(ci);
            }

            return Contacts;
        }
    }
}