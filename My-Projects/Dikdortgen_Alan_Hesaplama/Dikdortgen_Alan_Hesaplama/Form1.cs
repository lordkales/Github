using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dikdortgen_Alan_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisa, uzun, alan, cevre;
            kisa = Convert.ToInt32(textBox1.Text);
            uzun = Convert.ToInt32(textBox2.Text);

            alan = kisa * uzun;
            cevre = 2 * kisa + 2 * uzun;

            listBox1.Items.Add("Alan: " + alan + " " + "Çevre: " + cevre);
        }
    }
}
