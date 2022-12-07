using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_20_VolokhovBL_U
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accessories1 a1 = new Accessories1();
            a1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zadanie2 a1 = new Zadanie2();
            a1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadanie3 a1 = new Zadanie3();
            a1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Zadanie4 a1 = new Zadanie4();
            a1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zadanie5 a1 = new Zadanie5();
            a1.ShowDialog();
        }
    }
}
