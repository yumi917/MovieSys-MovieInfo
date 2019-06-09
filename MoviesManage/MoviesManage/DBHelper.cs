using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManage
{
    public class DBHelper
    {
        //链接
        private static string sqlcon = "server=.;database=MovieDB;uid=sa;pwd=root";
        private static SqlConnection con = null;
        //判断是否链接
        private static void InitConnection()
        {
            if (con == null)
            {
                con = new SqlConnection(sqlcon);
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Broken)
            {
                con.Close();
                con.Open();
            }
        }
        //
        public static bool ExecuteNonQuery(string strsql)
        {
            try
            {
                //调用判断是否链接
                InitConnection();
                SqlCommand cmd = new SqlCommand(strsql, con);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }

        }
        //集合函数
        public static object GetObject(string strsql)
        {
            try
            {
                InitConnection();
                SqlCommand cmd = new SqlCommand(strsql, con);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        //
        public static SqlDataReader GetDataReader(string strsql)
        {
            try
            {
                InitConnection();
                SqlCommand cmd = new SqlCommand(strsql, con);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                con.Close();
                return null;
            }
            finally
            {
                //con.Close();
            }
        }
        //执行查询语句
        public static DataTable GetDataTable(string strSql)
        {
            try
            {
                InitConnection();
                SqlDataAdapter dat = new SqlDataAdapter(strSql, con);
                DataTable dt = new DataTable();
                dat.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
