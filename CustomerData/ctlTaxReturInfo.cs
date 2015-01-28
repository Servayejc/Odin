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
    public partial class ctlTaxReturInfo : UserControl
    {
        CustomerItem Customer;
        IModule Module;

        public ctlTaxReturInfo(CustomerItem Customer, IModule Module)
        {
            this.Module = Module;
            this.Customer = Customer;
            InitializeComponent();

            UpdateGV();
        }

        public void UpdateGV()
        {
            gvStatusList.Rows.Clear();
            foreach (TaxReturnItem ti in GetTaxReturns(Customer))
            {
                gvStatusList.Rows.Add(new object[] { ti.TaxYear, ti.Status, ti.Datestatus, ti.UserName });
            }
        }

        public List<TaxReturnItem> GetTaxReturns(CustomerItem Customer)
        {
            SQLHelper sh = new SQLHelper();
            DataTable dt = sh.GetData(@"SELECT [TaxYear]
                                  ,[status]
                                  ,[datestatus]
                                  ,[UserName]
                                  ,[Customers_Nas]
                              FROM [Odin].[dbo].[ReturnInfo]
                              where [Customers_Nas] = @NAS order by datestatus", new List<string> { "@NAS" }, new List<object> { Customer.NAS }, CommandType.Text);

            List<TaxReturnItem> TaxReturns = new List<TaxReturnItem>();
            foreach (DataRow dr in dt.Rows)
            {
                TaxReturnItem tr = new TaxReturnItem();
                tr.Customers_Nas = dr["Customers_Nas"] != DBNull.Value ? dr["Customers_Nas"].ToString() : string.Empty;
                tr.Datestatus = dr["Datestatus"] != DBNull.Value ? (DateTime)dr["Datestatus"] : DateTime.MinValue;
                tr.Status = dr["Status"] != DBNull.Value ? dr["Status"].ToString() : string.Empty;
                tr.TaxYear = dr["TaxYear"] != DBNull.Value ? (int)dr["TaxYear"] : -1;
                tr.UserName = dr["UserName"] != DBNull.Value ? dr["UserName"].ToString() : string.Empty;
                TaxReturns.Add(tr);
            }

            return TaxReturns;
        }


    }
}