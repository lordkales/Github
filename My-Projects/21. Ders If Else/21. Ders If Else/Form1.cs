using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21.Ders_If_Else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ali")
            {
                label1.Text = "Doğru";


            }
            else
            {
                label1.Text = "Yanlış";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox2.Text);

            if (sayi == 5)
            {
                label2.Text = "Doğru";

            }
            else
            {
                label2.Text = "Yanlış";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi2= Convert.ToInt32(textBox3.Text);

            if (sayi2 % 2 == 0)
            {
                label3.Text = "Çift";
            }
            else
            {
                label3.Text = "Tek";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi2 = Convert.ToInt32(textBox4.Text);
            if (sayi2 > 10 && sayi2 % 2 == 0)
            {
                label4.Text = "Doğru";
            }
            else {
                label4.Text = "Yanlış";
                    }
        }
    }
}
