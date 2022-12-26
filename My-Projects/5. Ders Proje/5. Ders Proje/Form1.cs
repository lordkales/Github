using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Ders_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text;
            label5.Text = textBox2.Text;
            label6.Text = textBox3.Text;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

        }
    }
}
