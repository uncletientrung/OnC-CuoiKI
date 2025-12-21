using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace _2024_2025HK1_Winform
{
    internal class HangDAO
    {
        private static string connStr = "server=localhost;" +
                               "user=root;" +
                               "database=2024-2025hk1;" +
                               "password=;";
        private MySqlConnection conn;
        private void getConnection()
        {
            if(conn == null) conn=new MySqlConnection(connStr);
            if (conn.State == ConnectionState.Closed) conn.Open(); 
        }
        private void CloseConnection()
        {
            if(conn != null && conn.State==ConnectionState.Open) conn.Close();
        }
        public DataTable getAll(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                getConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi Select: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }
        public int executeNonQuery(string Query)
        {
            int rs = 0;
            try
            {
                getConnection();
                using (MySqlCommand cmd = new MySqlCommand(Query, conn))
                {
                    rs = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi Select: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
            return rs;
        }
    }
}
