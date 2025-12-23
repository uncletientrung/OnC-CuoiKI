using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_2025HK2
{
    public class Product
    {
        private string name;
        private int stock;
        public Product(string name, int stock)
        {
            this.name = name;
            this.stock = stock;
        }
        public bool Sell(int quantity)
        {
            if (quantity > 0 && quantity <= stock)
            {
                stock -= quantity;
                return true;
            }
            else return false;
        }
        public string GetName() { return name; }
        public int GetStock() { return stock; }
    }
    public class Bai2
    {
        public static void Main(string[] arg)
        {
            Product p = new Product("USB 32GB", 20);
            p.Sell(5);
            Console.WriteLine(p.GetName()  +" Còn lại: " + p.GetStock() + "Chiếc");
        }
        
    }
}
