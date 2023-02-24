using First_Project_Library_Automation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Project_Library_Automation
{
    public partial class AdminSayfasi : Form
    {
        List<Kisi> kisilerim;
        List<Kitap> kitaplarim;
        public AdminSayfasi(List<Kisi> kisilerim, List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;
        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.GetID(), kisi.GetIsim(), kisi.GetSoyisim(), kisi.GetOlusturmatarih(), kisi.GetKullaniciadi(), kisi.GetSıfre(), kisi.GetYetki());
            }

            foreach(Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getkitapid(), kitap.getkitapisim(), kitap.getkitapyazar(), kitap.getkitapdili(), kitap.getyayinevi(), kitap.gettur(), kitap.getadet(), kitap.getsayfasayisi(), kitap.getbasimyili());
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add(Convert.ToInt32(txt_id.Text), txt_isim.Text, txt_soyisim.Text, maskedTextBox1.Text, txt_kullaniciadi.Text, txt_sifre.Text, txt_yetki.Text);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        public void textleridoldur()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullaniciadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        public void textleridoldur2()
        {
            txt_kitapid.Text=dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kitapisim.Text=dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_kitapyazar.Text=dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_dil.Text=dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yayinevi.Text=dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_tur.Text=dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_adet.Text=dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_sayfa.Text=dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_basimyili.Text=dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleridoldur();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Cells[0].Value= txt_id.Text;
            dataGridView1.CurrentRow.Cells[1].Value= txt_isim.Text;
            dataGridView1.CurrentRow.Cells[2].Value= txt_soyisim.Text;
            dataGridView1.CurrentRow.Cells[3].Value= maskedTextBox1.Text;
            dataGridView1.CurrentRow.Cells[4].Value= txt_kullaniciadi.Text;
            dataGridView1.CurrentRow.Cells[5].Value= txt_sifre.Text;
            dataGridView1.CurrentRow.Cells[6].Value= txt_yetki.Text;

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is TextBox || groupBox1.Controls[i] is MaskedTextBox)
                {
                    groupBox1.Controls[i].Text = string.Empty;
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_kitapid.Text, txt_kitapisim.Text, txt_kitapyazar.Text, txt_dil.Text, txt_adet.Text, txt_yayinevi.Text, txt_tur.Text, txt_sayfa.Text, txt_basimyili.Text);
        }

        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }
        private void dataGridView2_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_kitapguncelle_Click(object sender, EventArgs e)
        {
            dataGridView2.CurrentRow.Cells[0].Value = txt_kitapid.Text;
            dataGridView2.CurrentRow.Cells[1].Value = txt_kitapisim.Text;
            dataGridView2.CurrentRow.Cells[2].Value = txt_kitapyazar.Text;
            dataGridView2.CurrentRow.Cells[3].Value = txt_dil.Text;
            dataGridView2.CurrentRow.Cells[4].Value = txt_yayinevi.Text;
            dataGridView2.CurrentRow.Cells[5].Value = txt_tur.Text;
            dataGridView2.CurrentRow.Cells[6].Value = txt_adet.Text;
            dataGridView2.CurrentRow.Cells[7].Value = txt_sayfa.Text;
            dataGridView2.CurrentRow.Cells[8].Value = txt_basimyili.Text;
        }

        private void btn_kitaptemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Groupbox_Kitap.Controls.Count; i++)
            {
                if (Groupbox_Kitap.Controls[i] is TextBox)
                {
                    Groupbox_Kitap.Controls[i].Text = string.Empty;
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleridoldur2();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            Kisi hedefkisi = null;
            int secilenkisiID = Convert.ToInt32(txt_ara.Text);

            foreach (Kisi kisi in kisilerim)
            {
                if (kisi.GetID()==secilenkisiID)
                {
                    hedefkisi = kisi;
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkisi.GetID(), hedefkisi.GetIsim(), hedefkisi.GetSoyisim(), hedefkisi.GetOlusturmatarih(), hedefkisi.GetKullaniciadi(), hedefkisi.GetSıfre(), hedefkisi.GetYetki());
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Kisi hedefkisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedefkisi.GetID(), hedefkisi.GetIsim(), hedefkisi.GetSoyisim(), hedefkisi.GetOlusturmatarih(), hedefkisi.GetKullaniciadi(), hedefkisi.GetSıfre(), hedefkisi.GetYetki());
            }
        }

        private void btn_kitapara_Click(object sender, EventArgs e)
        {
            Kitap hedefkitap = null;
            int secilenkitapid = Convert.ToInt32(txt_kitapara.Text);

            foreach (Kitap kitap in kitaplarim)
            {
                if (kitap.getkitapid()==secilenkitapid)
                {
                    hedefkitap = kitap;
                    break;
                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefkitap.getkitapid(), hedefkitap.getkitapisim(), hedefkitap.getkitapyazar(), hedefkitap.getkitapdili(), hedefkitap.getyayinevi(), hedefkitap.gettur(), hedefkitap.getadet(),hedefkitap.getsayfasayisi(),hedefkitap.getbasimyili());
        }

        private void btn_kitapyenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            foreach (Kitap hedefkitap in kitaplarim)
            {
             dataGridView2.Rows.Add(hedefkitap.getkitapid(), hedefkitap.getkitapisim(), hedefkitap.getkitapyazar(), hedefkitap.getkitapdili(), hedefkitap.getyayinevi(), hedefkitap.gettur(), hedefkitap.getadet(), hedefkitap.getsayfasayisi(), hedefkitap.getbasimyili());
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();

            MessageBox.Show("Çıkış Yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
