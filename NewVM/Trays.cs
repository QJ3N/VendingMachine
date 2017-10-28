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
    public partial class Trays : Form
    {
        public Trays()
        {
            InitializeComponent();
        }
        public void ShowTray1(VMachine vm)
        {
            textBoxTray1.Text = "";
            textBoxTray1.AppendText("Продукт: " + vm.tray1.Product.Name + Environment.NewLine);
            textBoxTray1.AppendText("Цена: " + vm.tray1.Product.Price.ToString() + Environment.NewLine);
            textBoxTray1.AppendText("Количество: " + vm.tray1.Number.ToString() + Environment.NewLine);
        }
        public void ShowTray2(VMachine vm)
        {
            textBoxTray2.Text = "";
            textBoxTray2.AppendText("Продукт: " + vm.tray2.Product.Name + Environment.NewLine);
            textBoxTray2.AppendText("Цена: " + vm.tray2.Product.Price.ToString() + Environment.NewLine);
            textBoxTray2.AppendText("Количество: " + vm.tray2.Number.ToString() + Environment.NewLine);
        }
        public void ShowTray3(VMachine vm)
        {
            textBoxTray3.Text = "";
            textBoxTray3.AppendText("Продукт: " + vm.tray3.Product.Name + Environment.NewLine);
            textBoxTray3.AppendText("Цена: " + vm.tray3.Product.Price.ToString() + Environment.NewLine);
            textBoxTray3.AppendText("Количество: " + vm.tray3.Number.ToString() + Environment.NewLine);
        }
        public void ShowTray4(VMachine vm)
        {
            textBoxTray4.Text = "";
            textBoxTray4.AppendText("Продукт: " + vm.tray4.Product.Name + Environment.NewLine);
            textBoxTray4.AppendText("Цена: " + vm.tray4.Product.Price.ToString() + Environment.NewLine);
            textBoxTray4.AppendText("Количество: " + vm.tray4.Number.ToString() + Environment.NewLine);
        }
        public void ShowTray5(VMachine vm)
        {
            textBoxTray5.Text = "";
            textBoxTray5.AppendText("Продукт: " + vm.tray5.Product.Name + Environment.NewLine);
            textBoxTray5.AppendText("Цена: " + vm.tray5.Product.Price.ToString() + Environment.NewLine);
            textBoxTray5.AppendText("Количество: " + vm.tray5.Number.ToString() + Environment.NewLine);
        }
        public void ShowAllTrays(VMachine vm)
        {
            ShowTray1(vm);
            ShowTray2(vm);
            ShowTray3(vm);
            ShowTray4(vm);
            ShowTray5(vm);
        }
    }

    
}
