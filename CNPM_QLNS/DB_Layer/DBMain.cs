using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ReportingServices.Diagnostics.Internal;

namespace CNPM_QLNS.DB_Layer
{
     class DBMain
    {
        string ConnStr = (@"Data Source=.;Initial Catalog=QLNS_CNPM;Integrated Security=True");
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DBMain()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public System.Data.DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, SqlParameter[] parameters)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            comm.Parameters.Clear();
            if (parameters != null)
            {
                foreach (SqlParameter param in parameters)
                {
                    comm.Parameters.Add(param);
                }
            }
            da = new SqlDataAdapter(comm);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, SqlParameter[] parameterValues)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            if (parameterValues != null)
            {
                foreach (SqlParameter param in parameterValues)
                {
                    comm.Parameters.Add(param);
                }
            }
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            conn.Close();
            return f;
        }
    }
}
