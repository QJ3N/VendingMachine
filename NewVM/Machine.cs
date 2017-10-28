using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewVM
{
    public partial class Machine : Form
    {
        public VMachine vm;
        public ServiceStation sr;
        //form
        Panel p;
        Trays t;
        FormaForBox ffb;
        public Machine()
        {
            vm = new VMachine();
            sr = new ServiceStation();
            sr.DataAutomat(vm);
            vm.RestockTrays += sr.Supply;
            vm.Download();
            InitializeComponent();
        }

        private void pictureBoxPanel_Click(object sender, EventArgs e)
        {
           p = new Panel();
           p.vm = vm;
           string str = "";
           str += "Ваши деньги: " + vm.currentmoney + " грн.";
           p.textBoxEcran.Text = str;
           p.ShowDialog();
        }

        private void pictureBoxTrays_Click(object sender, EventArgs e)
        {
            t = new Trays();
            t.ShowAllTrays(vm);
            t.ShowDialog();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            ffb = new FormaForBox();
            ffb.vm = vm;
            for (int i = 0; i < vm.box.p.Count; i++)
                ffb.textBox1.Text += "Продукт: " + vm.box.p[i].Name + Environment.NewLine;
            ffb.ShowDialog();
        }
                  
    }
}
