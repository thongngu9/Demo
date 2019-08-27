using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Add Library
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Ex09
{
    class KetNoiDuLieu
    {
        private SqlDataAdapter da;
        private SqlConnection cnn;

        public KetNoiDuLieu()
        {
            da = new SqlDataAdapter();
            cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectDbQLBanHang"].ConnectionString);
        }

        private SqlConnection openConnection()
        {
            if (cnn.State == ConnectionState.Closed || cnn.State == ConnectionState.Broken)
            {
                cnn.Open();
            }
            return cnn;
        }

        public DataTable executeShowQuery(String _query)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            dt = null;
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = _query;
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: {0}\nException: {1}", _query, ex.StackTrace.ToString());
                return null;
            }
            finally
            {
                //cnn.Close();
                //cnn.Dispose();
            }
            return dt;
        }

        public DataTable executeSelectQuery(String _query, SqlParameter[] sqlPara)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            dt = null;
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = _query;
                cmd.Parameters.AddRange(sqlPara);
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: {0}\nException: {1}", _query, ex.StackTrace.ToString());
                return null;
            }
            finally
            {
                //cnn.Close();
                //cnn.Dispose();
            }
            return dt;
        }

        public bool executeInsertQuery(String _query, SqlParameter[] sqlPara)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            dt = null;
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = _query;
                cmd.Parameters.AddRange(sqlPara);
                da.InsertCommand = cmd;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: {0}\nException: {1}", _query, ex.StackTrace.ToString());
                return false;
            }
            finally
            {
                //cnn.Close();
                //cnn.Dispose();
            }
            return true;
        }

        public bool executeUpdateQuery(String _query, SqlParameter[] sqlPara)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            dt = null;
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = _query;
                cmd.Parameters.AddRange(sqlPara);
                da.UpdateCommand = cmd;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write("Error - Connection.executeUpdateQuery - Query: {0}\nException: {1}", _query, ex.StackTrace.ToString());
                return false;
            }
            finally
            {
                //cnn.Close();
                //cnn.Dispose();
            }
            return true;
        }

        public bool executeDeleteQuery(String _query, SqlParameter[] sqlPara)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            dt = null;
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = _query;
                cmd.Parameters.AddRange(sqlPara);
                da.DeleteCommand = cmd;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write("Error - Connection.executeDeleteQuery - Query: {0}\nException: {1}", _query, ex.StackTrace.ToString());
                return false;
            }
            finally
            {
                //cnn.Close();
                //cnn.Dispose();
            }
            return true;
        }
    }
}
