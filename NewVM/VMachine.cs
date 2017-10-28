using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVM
{
    public delegate bool restock(VMachine a);
    public class VMachine
    {
        public event restock RestockTrays;
        public Tray tray1 { get; set; }
        public Tray tray2 { get; set; }
        public Tray tray3 { get; set; }
        public Tray tray4 { get; set; }
        public Tray tray5 { get; set; }
        public Box box { get; set; }
        public double bank { get; set; }
        public double currentmoney { get; set; }
        public VMachine()
        {
            tray1 = new Tray();
            tray2 = new Tray();
            tray3 = new Tray();
            tray4 = new Tray();
            tray5 = new Tray();
            box = new Box();
            currentmoney = 0;
            bank = 0;
        }
        public bool ProductIssue(Tray tray)
        {
            if (!tray.EmptyTray() && currentmoney >= tray.Product.Price)
            {
                currentmoney -= tray.Product.Price;
                tray.Number--;
                bank += tray.Product.Price;
                return true;
            }
            return false;

        }

        public void ReturnMoney()
        {
            currentmoney = 0;
        }
        public void UnloadingMoney(ServiceStation sr)
        {
            sr.allbank += bank;
            bank = 0;
        }
        public bool Download()
        {
            return RestockTrays(this);
        }
    }
}
