using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _2024_2025HK1CLC_Winform
{
    internal class BUS
    {
        private DAO dao;
        private DataTable dtClient;
        private DataTable dtOrderItem;
        private DataTable dtOrder;
        private BindingList<OrderItem> ListOrderItem;
        public BUS()
        {
            dao = new DAO();
            string query = "SELECT * FROM clients";
            dtClient = dao.getAll(query);
            string query2 = "SELECT * FROM orderitems";
            dtOrderItem = dao.getAll(query2);
            string query3 = "SELECT * FROM orders";
            dtOrder = dao.getAll(query3);
            ListOrderItem = dao.getAllOrderItemLinQ();
        }
        public DataTable getAllClients()
        {
            return dtClient;
        }
        public DataTable getAllOrderItems()
        {
            return dtOrderItem;
        }
        public DataTable getAllOrders()
        {
            return dtOrder;
        }
        public Boolean addClient(string Name, string Email, string Phone)
        {
            int maClient = 1;
            if(dtClient.Rows.Count > 0)
            {
                maClient = dtClient.AsEnumerable().Max( r=> int.Parse(r[0].ToString())) +1;
            }
            string query = $"INSERT INTO clients(ClientId, ClientName, Email, Phone) VALUES " +
                $"({maClient}, '{Name}', '{Email}', '{Phone}')";
            int result = dao.executeNonQuery(query);
            if (result > 0)
            {
                dtClient.Rows.Add(maClient, Name, Email, Phone); 
                return true;
            }

            return false;
        }
        public Boolean removeClient(int maClient)
        {
            foreach(DataRow dr in dtOrder.Rows)
            {
                if ((int)dr["clientId"] == maClient)
                {
                    return false;
                }
            }
            string query = $"DELETE FROM clients WHERE ClientId = {maClient}";
            int result = dao.executeNonQuery(query);
            if (result > 0)
            {
                DataRow rowDelete = dtClient.AsEnumerable()
                                            .FirstOrDefault(r => (int)r["ClientId"] == maClient);
                if (rowDelete != null)
                {
                    dtClient.Rows.Remove(rowDelete);
                }
                return true;
            }
            return false ;
        }
        public bool updateClient(int maClient, string Name, string Email, string Phone)
        {
            string query = $"UPDATE clients SET ClientName = '{Name}', Email = '{Email}', Phone = '{Phone}' " +
                           $"WHERE ClientId = {maClient}";
            int result = dao.executeNonQuery(query);
            if (result > 0)
            {
                DataRow row = dtClient.AsEnumerable()
                                      .FirstOrDefault(r => (int)r["ClientId"] == maClient);
                if (row != null)
                {
                    row["ClientName"] = Name;
                    row["Email"] = Email;
                    row["Phone"] = Phone;
                }
                return true;
            }

            return false;
        }
        public BindingList<OrderItem> getOrderItemsLinq()
        {
            return ListOrderItem;
        }
        public Boolean AddItem(OrderItem item)
        {
            Boolean result = dao.addOrderItem(item) != 0;
            if(result)
            {
                ListOrderItem.Add(item);
            }
            return result;
        }
        public Boolean DeleteItem(int orderItemId)
        {
            Boolean result = dao.removeOrderItem(orderItemId) != 0;
            if (result)
            {
                var item = ListOrderItem.FirstOrDefault(x => x.orderItemId == orderItemId);
                ListOrderItem.Remove(item);
            }
            return result;
        }
        public Boolean UpdateItem(OrderItem item)
        {
            Boolean result = dao.updateOrderItem(item) != 0;
            var itemA = ListOrderItem.FirstOrDefault(i => i.orderItemId == item.orderItemId);
            if (itemA != null && result)
            {
                itemA.productName = item.productName;
                itemA.quantity = item.quantity;
                itemA.price = item.price;
            }
            return result;
        }
    }
}
