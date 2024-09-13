using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOD.NetDemo
{
    internal class DBUtil
    {
        public static int ExeStrdProcedureNonQuery(string spName,params SqlParameter [] parameters)
        {
            SqlConnection conn = new SqlConnection(Helper.ConnStr);
            SqlCommand cmd = new SqlCommand(spName,conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddRange(parameters);
            conn.Open();
            int n = cmd.ExecuteNonQuery();
            conn.Close();
            return n;
        }

        public static SqlDataReader ExeSPReader(string spName, params SqlParameter [] parameters)
        {
            SqlConnection conn = new SqlConnection(Helper.ConnStr);
            SqlCommand cmd = new SqlCommand(spName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddRange(parameters);
            conn.Open ();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);// this will make conn close whenn reader is closed
            return reader;
        }

        public static object ExecuteSPScalar(string spName, params SqlParameter [] parameters)
        {
            SqlConnection conn = new SqlConnection (Helper.ConnStr);
            SqlCommand cmd = new SqlCommand(spName, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddRange(parameters);
            conn.Open ();
            object o = cmd.ExecuteScalar();
            conn.Close();
            return o;
        }
    }
}
