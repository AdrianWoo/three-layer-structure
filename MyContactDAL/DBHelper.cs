using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MyContactDAL
{
    public class DBHelper
    {
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public DataTable GetDataTable(string strsql)
        {
            try
            {
                DataTable dt = this.GetDataSet(strsql).Tables[0];
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable GetDataTable(string strsql, SqlParameter[] param)
        {
            try
            {
                DataTable dt = this.GetDataSet(strsql, param).Tables[0];
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public DataSet GetDataSet(string strsql)
        {
            using (conn)
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(strsql, conn);
                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds);
                    return ds;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public DataSet GetDataSet(string strsql, SqlParameter[] param)
        {
            using (conn)
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(strsql, conn);
                comm.Parameters.AddRange(param);
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds);
                    return ds;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }
        public object GetSingle(string strsql)
        {
            using (conn)
            {
                using (SqlCommand comm = new SqlCommand(strsql, conn))
                {
                    conn.Open();
                    try
                    {
                        return comm.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }

            }
        }
        public object GetSingle(string strsql, SqlParameter[] param)
        {
            using (conn)
            {
                using (SqlCommand comm = new SqlCommand(strsql, conn))
                {
                    conn.Open();
                    try
                    {
                        comm.Parameters.AddRange(param);
                        return comm.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        public int ExecuteNonQuery(string strsql)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(strsql, conn))
                {
                    try
                    {
                        return comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
        public int ExecuteNonQuery(string strsql, SqlParameter[] param)
        {
            using (conn)
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(strsql, conn))
                {
                    try
                    {
                        comm.Parameters.AddRange(param);
                        return comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}
