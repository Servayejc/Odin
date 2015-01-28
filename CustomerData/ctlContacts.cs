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
        IModule Module;

        public ctlContacts(CustomerItem Customer, IModule Module)
        {
            this.Module = Module;
            this.Customer = Customer;
            InitializeComponent();
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            ContactItem Contact = new ContactItem();
            Contact.Customers_Nas = Customer.NAS;
            pop = new frmPopup(Module, Contact,  mode.newitem);
            pop.Text = "New event";
            pop.ClosePop += new OnPopClose(Close_Pop);
            pop.ShowDialog();
        }

        private void Close_Pop()
        {
            ContactItem contact = pop.Contact;
            SaveContact(contact, pop.DialogMode);
            pop.ClosePop -= Close_Pop;
            pop.Dispose();

           
        }

        private void SaveContact(ContactItem contact, mode FileMode)
        {
            SQLHelper sh = new SQLHelper();
            if (FileMode == mode.newitem)
                sh.ExecuteNonQuery("Insert Into Contacts (Customers_Nas, Reason, Details, DateContact, UserName) values (@Customers_Nas, @Reason, @Details, @DateContact, @UserName)", new List<string> { "@Customers_Nas", "@Reason", "@Details", "@DateContact", "@UserName" }, new List<object> { contact.Customers_Nas, contact.Reason, contact.Details, contact.DateContact, contact.UserName }, CommandType.Text);
            else
                sh.ExecuteNonQuery("Update Contacts Set Reason=@Reason, Details=@Details, DateContact=@DateContact, UserName=@UserName Where ContactID=@ContactID", new List<string> {  "@Reason", "@Details", "@DateContact", "@UserName", "@ContactID" }, new List<object> { contact.Reason, contact.Details, contact.DateContact, contact.UserName, contact.ContactID }, CommandType.Text);
            UpdateGV(Customer);
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
                gvContacts.Rows[gvContacts.Rows.Count - 1].Tag = ci;
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
                                          ,[UserName],ContactID
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
                ci.ContactID = dr["ContactID"] != DBNull.Value ? (Guid)dr["ContactID"] : Guid.Empty;
                Contacts.Add(ci);
            }

            return Contacts;
        }

        private void gvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pop = new frmPopup(Module, gvContacts.Rows[e.RowIndex].Tag as ContactItem, mode.edit); 
            pop.Text = "Edit event";
            pop.ClosePop += new OnPopClose(Close_Pop);
            pop.ShowDialog();
        }
    }
}