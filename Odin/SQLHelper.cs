using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Odin
{    
    public class SQLHelper
    {
        public string cnnString = "Data Source=192.99.224.150;Initial Catalog=Odin;Persist Security Info=True;User ID=Odin;Password=1234567A";

        public DataTable GetData(string SQL, List<string> Params, List<object> ParamValues, CommandType cmdType)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(cnnString);
                SqlCommand cmd = new SqlCommand(SQL, cnn);
                int i = 0;
                foreach (string p in Params)
                {
                    cmd.Parameters.Add(new SqlParameter(p,ParamValues[i]));
                    i++;
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch(Exception ex)
            {

                return null;
            }
        }

        public void ExecuteNonQuery(string SQL, List<string> Params, List<object> ParamValues, CommandType cmdType)
        {           
                SqlConnection cnn = new SqlConnection(cnnString);
                SqlCommand cmd = new SqlCommand(SQL, cnn);
                int i = 0;
                foreach (string p in Params)
                {
                    cmd.Parameters.Add(new SqlParameter(p, ParamValues[i]));
                    i++;
                }

                cmd.ExecuteNonQuery();
        }
    }
}