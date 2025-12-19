using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_2025HK1CLC_Winform
{
    partial class ChiTietDonHang : Form
    {
        private BindingList<OrderItem> listOrderItem;
        private BUS bus = new BUS();
        public ChiTietDonHang()
        {
            InitializeComponent();
            dgv.Columns.Add("orderItemId", "Mã order Item");
            dgv.Columns.Add("orderId", "Mã order");
            dgv.Columns.Add("productName", "Product Name");
            dgv.Columns.Add("quantity", "Quantity");
            dgv.Columns.Add("price", "Price");
            dgv.Columns.Add("total", "Total");

            LoadData();
            dgv.CellClick += (obj, e) =>
            {
                DataGridViewRow rowCurrent = dgv.CurrentRow;
                txName.Text = rowCurrent.Cells[2].Value.ToString();
                txPrice.Text = rowCurrent.Cells[4].Value.ToString();
                txQuantity.Text = rowCurrent.Cells[3].Value.ToString();
            };
            btnAdd.Click += (obj, e) =>
            {
                Add();
            };
            btnUpdate.Click += (obj, e) =>
            {
                updateItem();
            };
            btnRemove.Click += (obj, e) =>
            {
                Delete();
            };
        }
        public void LoadData()
        {
            dgv.Rows.Clear();
            listOrderItem = bus.getOrderItemsLinq();
            foreach (OrderItem item in listOrderItem)
            {
                if(item.orderId == 1)
                {
                    int total = item.price * item.quantity;
                    dgv.Rows.Add(item.orderItemId, item.orderId, item.productName, item.quantity,
                        item.price, total);
                }
                
            }
        }
        public void Add()
        {
            if(txName.Text.Length > 0 && txPrice.Text.Length > 0 && txQuantity.Text.Length >0)
            {
                string name  = txName.Text;
                int price = int.Parse(txPrice.Text);
                int quantity = int.Parse(txQuantity.Text);
                int maSP = 1;
                if(listOrderItem.Count >0) maSP = listOrderItem.Max(i => i.orderItemId) + 1;
                OrderItem itemNew= new OrderItem(maSP, 1, name, price, quantity);
                Boolean Rs= bus.AddItem(itemNew);
                if (Rs)
                {
                    LoadData();
                    txName.Clear();
                    txPrice.Clear();
                    txQuantity.Clear();
                }
            }
        }
        public void Delete()
        {
            DataGridViewRow rowCurrent = dgv.CurrentRow;
            int maSP = int.Parse(rowCurrent.Cells[0].Value.ToString());
            Boolean reuslt = bus.DeleteItem(maSP);
            if (reuslt)
            {
                LoadData();
                txName.Clear();
                txPrice.Clear();
                txQuantity.Clear();
            }
        }
        public void updateItem()
        {
            if (txName.Text.Length > 0 && txPrice.Text.Length > 0 && txQuantity.Text.Length > 0)
            {
                string name = txName.Text;
                int price = int.Parse(txPrice.Text);
                int quantity = int.Parse(txQuantity.Text);
                DataGridViewRow rowCurrent = dgv.CurrentRow;
                int maSP = int.Parse(rowCurrent.Cells[0].Value.ToString());
                OrderItem itemUpdate = listOrderItem.FirstOrDefault(i => i.orderItemId == maSP);
                itemUpdate.productName = name;
                itemUpdate.price = price;
                itemUpdate.quantity = quantity;
                Boolean reuslt = bus.UpdateItem(itemUpdate);
                if (reuslt)
                {
                    LoadData();
                    txName.Clear();
                    txPrice.Clear();
                    txQuantity.Clear();
                }
            }
        }


    }
}
