using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _122.PictureBox_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi, kullanicisifre;
            kullaniciadi = txt_ad.Text;
            kullanicisifre = txt_sifre.Text;

            if(kullaniciadi.ToLower()=="burak"&&kullanicisifre.ToLower()=="123")
            {
                //farklı bir forma yönlendir 
                anasayfa anasayfa = new anasayfa();
                anasayfa.lbl_deger.Text = kullaniciadi.ToUpper();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı yada şifre hatalı", "Error", MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
    }
}
