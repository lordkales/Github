using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19.Sinema_Bufe_Satis_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, bilet, cay,toplam;
            misir = Convert.ToInt32(textBox1.Text);
            su = Convert.ToInt32(textBox2.Text);
            bilet=Convert.ToInt32(textBox3.Text);
            cay = Convert.ToInt32(textBox4.Text);
            
            toplam=misir * 4 + su * 1 + cay * 2 + bilet * 8;
            label10.Text = Convert.ToString(toplam+" TL");

            kasatutar = kasatutar + toplam;
            label12.Text = Convert.ToString(kasatutar+ " TL");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            label10.Text = "0.00 TL";
            textBox1.Focus();
        }
    }
}
