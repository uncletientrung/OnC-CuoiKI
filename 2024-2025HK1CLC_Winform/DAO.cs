using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_2025HK1CLC_Winform
{
    internal class DAO
    {
         private static string connStr = "server=localhost;" +
                                "user=root;" +
                                "database=2024-2025clc;" +
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
                using(MySqlCommand cmd = new MySqlCommand( query, conn))
                {
                    result = cmd.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                throw new Exception($"Lỗi {ex.Message}");
            }
            finally
            {
                closeConnection();
            }
            return result;
        }
        public BindingList<OrderItem> getAllOrderItemLinQ()
        {
            using (var db = new ConnectLinq())
            {
                var list = db.OrderItems.ToList();
                return new BindingList<OrderItem>(list);
            }
        }
        public int removeOrderItem(int maOrderItem)
        {
            int result = 0;
            using (var db = new ConnectLinq())
            {
                var item = db.OrderItems.FirstOrDefault( i => i.orderItemId == maOrderItem);
                db.OrderItems.Remove(item);
                result = db.SaveChanges();
            }
            return result;
        }
        public int addOrderItem(OrderItem item)
        {
            int result = 0;
            using (var db = new ConnectLinq())
            {
                db.OrderItems.Add(item);
                result = db.SaveChanges();
            }
            return result;
        }
        public int updateOrderItem(OrderItem itemupdate)
        {
            int result = 0;
            using (var db = new ConnectLinq())
            {
                var item = db.OrderItems.FirstOrDefault(i => i.orderItemId == itemupdate.orderItemId);
                if (item != null)
                {

                    item.productName = itemupdate.productName;
                    item.quantity = itemupdate.quantity;
                    item.price = itemupdate.price;
                    result = db.SaveChanges();
                }
                ;
            }
            return result;
        }
    }
}
