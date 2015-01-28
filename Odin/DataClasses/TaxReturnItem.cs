using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Odin.DataClasses
{
    public class TaxReturnItem
    {
        private int m_TaxYear;

        public int TaxYear
        {
            get { return m_TaxYear; }
            set { m_TaxYear = value; }
        }
        private string m_status;

        public string Status
        {
            get { return m_status; }
            set { m_status = value; }
        }
        private DateTime m_datestatus;

        public DateTime Datestatus
        {
            get { return m_datestatus; }
            set { m_datestatus = value; }
        }
        private string m_UserName;

        public string UserName
        {
            get { return m_UserName; }
            set { m_UserName = value; }
        }
        private string m_Customers_Nas;

        public string Customers_Nas
        {
            get { return m_Customers_Nas; }
            set { m_Customers_Nas = value; }
        }

    }
}