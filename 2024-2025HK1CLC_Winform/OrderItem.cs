using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_2025HK1CLC_Winform
{
    internal class OrderItem
    {
        public int orderItemId {  get; set; }
        public int orderId { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public OrderItem(int orderItemId, int orderId, string productName, int quantity, int price)
        {
            this.orderItemId = orderItemId;
            this.orderId = orderId;
            this.productName = productName;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
