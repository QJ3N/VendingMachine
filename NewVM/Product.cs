using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVM
{
    public class Product
    {
        private string name { get; set; }
        private double price { get; set; }
        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public Product()
        {
            name = "";
            price = 0;
        }
    }
}
