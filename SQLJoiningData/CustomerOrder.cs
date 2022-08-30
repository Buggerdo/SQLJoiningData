using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLJoiningData
{
    internal class CustomerOrder
    {
        public string CustomerName { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public CustomerOrder(string customerName, string item, decimal price, int quantity)
        {
            CustomerName = customerName;
            Item = item;
            Price = price;
            Quantity = quantity;
        }
    }
}
