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
    public partial class FormaForBox : Form
    {
        public VMachine vm;
        public FormaForBox()
        {
            InitializeComponent();
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            vm.box.p.Clear();
            MessageBox.Show("Вы забрали товар!" , "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
