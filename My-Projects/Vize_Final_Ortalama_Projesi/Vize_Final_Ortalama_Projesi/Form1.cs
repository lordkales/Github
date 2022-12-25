using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize_Final_Ortalama_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize, final; 
                double ortalama;
            vize = Convert.ToInt32(textBox1.Text);
            final = Convert.ToInt32(textBox2.Text);
            ortalama = (vize * 0.4) + (final * 0.6);

            if (ortalama >= 50)
            {
                MessageBox.Show("Not: " + ortalama + "GEÇTİNİZ");
            }
            else
            {
                MessageBox.Show("Not: " + ortalama + "KALDINIZ");
            }
        }
    }
}
