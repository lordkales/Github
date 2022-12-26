using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cember_Alan_Hesaplama_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ycap, alan, cevre;
            double pi;
            ycap = Convert.ToInt32(textBox1.Text);
            
            pi = 3.14;
            alan = Convert.ToInt32(pi)*(ycap*ycap);
            cevre = 2 * Convert.ToInt32(pi) * ycap;
            listBox1.Items.Add("Alan: " + alan+" Çevre: "+cevre);

        }
    }
}
