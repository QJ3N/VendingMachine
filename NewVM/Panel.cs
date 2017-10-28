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
    
    public partial class Panel : Form
    {

        public VMachine vm;
        public Panel()
        {
            InitializeComponent();
        }

        private void pictureBoxReaderB_Click(object sender, EventArgs e)
        {
            AddBanknote am = new AddBanknote();
            try
            {
                string a = "";
                if (DialogResult.OK == am.ShowDialog())
                {
                    for (int i = 0; i < am.GroupBanknote.Controls.Count; i++)
                    {
                        if (((RadioButton)am.GroupBanknote.Controls[i]).Checked == true)
                        {
                            a = (am.GroupBanknote.Controls[i]).Text;
                            break;
                        }
                    }
                    switch (a)
                    {
                        case "1":
                            vm.currentmoney += 1;
                            break;
                        case "2":
                            vm.currentmoney += 2;
                            break;
                        case "5":
                            vm.currentmoney += 5;
                            break;
                        case "10":
                            vm.currentmoney += 10;
                            break;
                        case "20":
                            vm.currentmoney += 20;
                            break;
                        case "50":
                            vm.currentmoney += 50;
                            break;
                        case "100":
                            vm.currentmoney += 100;
                            break;
                        case "200":
                            vm.currentmoney += 200;
                            break;
                        case "500":
                            vm.currentmoney += 500;
                            break;
                    }
                    textBoxEcran.Text = "Ваши деньги: " + vm.currentmoney.ToString() + " грн.";
                }
            }
            catch (Exception t)
            {
                Error(t);
            }

        }

        private void pictureBoxReaderC_Click(object sender, EventArgs e)
        {
            AddCoin am = new AddCoin();
            try
            {
                string a = "";
                if (DialogResult.OK == am.ShowDialog())
                {
                    for (int i = 0; i < am.groupCoins.Controls.Count; i++)
                    {
                        if (((RadioButton)am.groupCoins.Controls[i]).Checked == true)
                        {
                            a = (am.groupCoins.Controls[i]).Text;
                            break;
                        }
                    }
                    switch (a)
                    {
                        case "0,25":
                            vm.currentmoney += 0.25;
                            break;
                        case "0,50":
                            vm.currentmoney += 0.5;
                            break;
                        case "1":
                            vm.currentmoney += 1;
                            break;
                    }
                    textBoxEcran.Text = "Ваши деньги: " + vm.currentmoney.ToString() + " грн.";
                }
            }
            catch (Exception t)
            {
                Error(t);
            }
        }
        private void Error(Exception t)
        {
            MessageBox.Show("Error: " + t.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxNumberTray.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNumberTray.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxNumberTray.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxNumberTray.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxNumberTray.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxNumberTray.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxNumberTray.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxNumberTray.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxNumberTray.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxNumberTray.Text += "0";
        }

        void getProduct(Tray tr)
        {
            if (tr.Number > 1)
            {
                tr.Number--;
                vm.box.p.Add(tr.Product);
                MessageBox.Show("Вы купили товар", "Товар", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else MessageBox.Show("Недостаточно товара", "Товар", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxNumberTray.Text == "1")
            {
                if (vm.currentmoney >= vm.tray1.Product.Price)
                {
                    getProduct(vm.tray1);
                    vm.currentmoney -= vm.tray1.Product.Price;
                    textBoxEcran.Text = "Ваши деньги: " + vm.currentmoney.ToString() + " грн.";
                }
                else MessageBox.Show("Недостаточно денег для покупки", "Товар", MessageBoxButtons.OK, MessageBoxIcon.Warning);            
            }
            else if (textBoxNumberTray.Text == "2")
            {
                if (vm.currentmoney >= vm.tray2.Product.Price)
                {
                    getProduct(vm.tray2);
                    vm.currentmoney -= vm.tray2.Product.Price;
                    textBoxEcran.Text = "Ваши деньги: " + vm.currentmoney.ToString() + " грн.";
                }
                else MessageBox.Show("Недостаточно денег для покупки", "Товар", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
            }
            else if (textBoxNumberTray.Text == "3")
            {
                if (vm.currentmoney >= vm.tray3.Product.Price)
                {
                    getProduct(vm.tray3);
                    vm.currentmoney -= vm.tray3.Product.Price;
                    textBoxEcran.Text = "Ваши деньги: " + vm.currentmoney.ToString() + " грн.";
                }
                else MessageBox.Show("Недостаточно денег для покупки", "Товар", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
            }
            else if (textBoxNumberTray.Text == "4")
            {
                if (vm.currentmoney >= vm.tray4.Product.Price)
                {
                    getProduct(vm.tray4);
                    vm.currentmoney -= vm.tray4.Product.Price;
                    textBoxEcran.Text = "Ваши деньги: " + vm.currentmoney.ToString() + " грн.";
                }
                else MessageBox.Show("Недостаточно денег для покупки", "Товар", MessageBoxButtons.OK, MessageBoxIcon.Warning);   

            }
            else if (textBoxNumberTray.Text == "5")
            {
                if (vm.currentmoney >= vm.tray5.Product.Price)
                {
                    getProduct(vm.tray5);
                    vm.currentmoney -= vm.tray5.Product.Price;
                    textBoxEcran.Text = "Ваши деньги: " + vm.currentmoney.ToString() + " грн.";
                }
                else MessageBox.Show("Недостаточно денег для покупки", "Товар", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
            }
            else MessageBox.Show("Не верный номер лотка", "Товар", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (textBoxNumberTray.Text.Length >= 1)
                textBoxNumberTray.Text = textBoxNumberTray.Text.Substring(0, textBoxNumberTray.Text.Length - 1);
        }


    }
}
