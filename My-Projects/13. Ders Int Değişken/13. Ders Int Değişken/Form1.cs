using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.Ders_Int_Değişken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kısakenar, uzunkenar, alan, cevre, not1, not2, not3,ortalama;
            kısakenar = 10;
            uzunkenar = 20;
            alan = kısakenar * uzunkenar;
            cevre = 2 * kısakenar + 2 * uzunkenar;
            not1 = 10;
            not2 = 100;
            not3 = 100;
            ortalama=(not1+not2+not3)/ 3;
            label1.Text = "Alan: " + alan + " Çevre: " + cevre;
            label2.Text = "Ortalama: " + ortalama;
         
        }
    }
}
