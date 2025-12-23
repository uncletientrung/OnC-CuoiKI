using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_2025HK2_Winform
{
    public class BookDAO
    {
        public String connStr="server=localhost;" +
                                "user=root;" +
                                "database=2024-2025hk2;" +
                                "password=;";
        public MySqlConnection conn;
        public void getConnection()
        {
            if(conn == null) conn = new MySqlConnection(connStr);
            if(conn.State == System.Data.ConnectionState.Closed) conn.Open();
        }
        public void closeConnection() {
            if(conn != null) conn.Close();
        }
        public DataTable getAll(string query)
        {
            DataTable result = new DataTable();
            try
            {
                getConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    result.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi Select: {ex.Message}");
            }
            finally
            {
                closeConnection();
            }
            return result;
        }
        public int executeNonQuery(string query)
        {
            int result = 0;
            try
            {
                getConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi {ex.Message}");
            }
            finally
            {
                closeConnection();
            }
            return result;
        }
    }
}
