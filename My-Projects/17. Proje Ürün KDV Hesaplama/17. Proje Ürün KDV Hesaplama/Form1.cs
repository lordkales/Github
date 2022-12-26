using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17.Proje_Ürün_KDV_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urun;
            int fiyat, kdv8, kdv18;
            urun = textBox1.Text;
            fiyat = Convert.ToInt32(textBox2.Text);
            kdv8 = (fiyat * 8) / 100 + fiyat;
            kdv18 = (fiyat * 18) / 100 + fiyat;
            listBox1.Items.Add("Ürün: " + urun + " %8 KDV: " + kdv8 + " %18 KDV: " + kdv18);
        }
    }
}
