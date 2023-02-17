using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _116.MessageBox_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkış Yapılsın Mı?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc==DialogResult.Yes)
            {
                label2.Text = "Çıkış Yapılıyor";
            }
            else
            {
                label2.Text = "Çıkış Yapılmadı";
            }
        }
    }
}
