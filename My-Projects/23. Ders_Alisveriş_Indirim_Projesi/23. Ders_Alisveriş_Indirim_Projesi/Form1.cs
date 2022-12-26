using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23.Ders_Alisveriş_Indirim_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;
            kitapadet = Convert.ToInt16(textBox1.Text);

            if (kitapadet >= 0&&kitapadet<=20)
            {
                toplam = (kitapadet * 10) - (kitapadet * 10 * 0.20);
                label3.Text = toplam + " TL";
            }
            if (kitapadet >= 21 && kitapadet <= 40)
            {
                toplam = (kitapadet * 10) - (kitapadet * 10 * 0.4);
                label3.Text = toplam + " TL";
            }
            if (kitapadet >= 41)
            {
                toplam = (kitapadet * 10) - (kitapadet * 10 * 0.5);
                    label3.Text = toplam + " TL";
                
            }
        }
    }
}
