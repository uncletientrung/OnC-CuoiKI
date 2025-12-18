using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_2023HK1Cau3
{
    internal class database
    {
        private static string connStr = "server=localhost;" +
                                "user=root;" +
                                "database=2023-2024hk1;" +
                                "password=;";
        public static MySqlConnection conn;

        public static void getConnection() // Lấy kết nối 
        {
            if (conn == null) conn = new MySqlConnection(connStr);
            if (conn.State == ConnectionState.Closed) conn.Open();
        }
        public static void closeConnection() // Đóng kết nối
        {
            if (conn != null && conn.State == ConnectionState.Open) conn.Close();
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
                    result.Load(reader); // Load vào result sau khi đọc xong
                }
            }catch (Exception ex)
            {
                throw new Exception($"Lỗi Select: {ex.Message}");
            }
            finally
            {
                closeConnection();
            }
            return result;
        }
    }
}
