using System;
using System.Data;
using System.Data.Sql;
using Microsoft.SqlServer.Server;
using System.Collections;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace AccountDetails
{
    public class Det
    {
        [Microsoft.SqlServer.Server.SqlFunction(DataAccess = DataAccessKind.Read, SystemDataAccess = SystemDataAccessKind.Read)]
        public static SqlString details(SqlString acn)
        {
            SqlConnection connection = new SqlConnection("context connection = true");
            
                SqlString sr = new SqlString();
                connection.Open();
                SqlCommand cmd = new SqlCommand("select salesorderid from sales.salesorderheader where accountnumber = '"+acn.ToString()+"'", connection);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    sr = sr.ToString() + " " + dr[0].ToString();
                }
                dr.Close();
                connection.Close();
                return sr;
            
        }
    }
}
