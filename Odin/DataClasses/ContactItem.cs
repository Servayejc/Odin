using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Odin.DataClasses
{
    public class ContactItem
    {
        private string m_Reason;

        public string Reason
        {
            get { return m_Reason; }
            set { m_Reason = value; }
        }
        private string m_Details;

        public string Details
        {
            get { return m_Details; }
            set { m_Details = value; }
        }
        private DateTime m_DateContact;

        public DateTime DateContact
        {
            get { return m_DateContact; }
            set { m_DateContact = value; }
        }
        private string m_Customers_Nas;

        public string Customers_Nas
        {
            get { return m_Customers_Nas; }
            set { m_Customers_Nas = value; }
        }

        private string m_UserName;

        public string UserName
        {
            get { return m_UserName; }
            set { m_UserName = value; }
        }

        private Guid m_ContactID;

        public Guid ContactID
        {
            get { return m_ContactID; }
            set { m_ContactID = value; }
        }

    }
}