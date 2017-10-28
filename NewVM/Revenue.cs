using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVM
{
    public class Revenue
    {
        public DateTime date { get; set; }
        public double money { get; set; }
        public Revenue(DateTime date, double money)
        {
            this.date = date;
            this.money = money;
        }
    }
}
