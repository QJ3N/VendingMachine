using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVM
{
    public class Delivery
    {
        public DateTime date { get; set; }
        public int tray { get; set; }
        public Product product { get; set; }
        public int number { get; set; }
        public Delivery(DateTime date, int tray, int number, Product product)
        {
            this.date = date;
            this.tray = tray;
            this.number = number;
            this.product = product;
        }
    }
}
