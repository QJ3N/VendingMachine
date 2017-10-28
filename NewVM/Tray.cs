using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVM
{
    public class Tray
    {
        public Product Product { get; set; }
        public int Number { get; set; }
        public int TrayNumber { get; set; }

        public Tray(Product product, int number, int traynumber)
        {
            this.Product = product;
            this.Number = number;
            this.TrayNumber = traynumber;
        }
        public Tray()
        {
            Product = new Product();
            TrayNumber = 0;
            Number = 0;
        }
        public bool EmptyTray()
        {
            if (Number == 0)
            {
                return true;
            }
            else return false;
        }      
    }
}
