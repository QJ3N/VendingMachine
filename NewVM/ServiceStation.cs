using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVM
{
    public class ServiceStation
    {
        public List<Delivery> listdelivery { get; set; }
        public List<Revenue> listrevenue { get; set; }
        public double allbank { get; set; }
        public ServiceStation()
        {
            listdelivery = new List<Delivery>();
            listrevenue = new List<Revenue>();
            allbank = 0;
        }
        public bool Check(Tray tray)
        {
            if (tray.EmptyTray())
            {
                tray.Number = 5;
                listdelivery.Add(new Delivery(DateTime.Now, tray.TrayNumber, tray.Number, tray.Product));
                return true;
            }
            else return false;
        }
        public bool Supply(VMachine vm)
        {
            bool bl = false;
            if (Check(vm.tray1))
                bl = true;
            if (Check(vm.tray2))
                bl = true;
            if (Check(vm.tray3))
                bl = true;
            if (Check(vm.tray4))
                bl = true;
            if (Check(vm.tray5))
                bl = true;
            return bl;
        }
        public void DataAutomat(VMachine vm)
        {
            vm.tray1 = new Tray(new Product("Mars", 14), 0, 1);
            vm.tray2 = new Tray(new Product("Lays", 20), 0, 2);
            vm.tray3 = new Tray(new Product("Bounty", 17), 0, 3);
            vm.tray4 = new Tray(new Product("Snickers", 16), 0, 4);
            vm.tray5 = new Tray(new Product("M&M's", 30), 0, 5);
        }
    }
}
