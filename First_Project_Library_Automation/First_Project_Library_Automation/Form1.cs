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
    public partial class Form1 : Form
    {
        List<Kisi> kisilerim = new List<Kisi>();
        List<Kitap> kitaplarım = new List<Kitap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciadi.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre;
            kullaniciadi = txt_kullaniciadi.Text;
            sifre = txt_sifre.Text;

            bool kontrol = false;

            foreach (Kisi kisi in kisilerim)
            {
                if (kullaniciadi.ToLower()==kisi.GetKullaniciadi()&&sifre.ToLower()==kisi.GetSıfre()&&kisi.GetYetki()=="admin")
                {
                    AdminSayfasi adminsayfasi = new AdminSayfasi(kisilerim,kitaplarım);
                    adminsayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                else if (kullaniciadi.ToLower() == kisi.GetKullaniciadi() && sifre.ToLower() == kisi.GetSıfre() && kisi.GetYetki() == "üye")
                {
                    UyeSayfasi uyesayfasi = new UyeSayfasi(kitaplarım);
                    uyesayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
            }
            if (kontrol == false)
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Yada Şifre!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1, "Burak Akif", "Boylu", DateTime.Now, "burak akif", "1", "admin"));
            kisilerim.Add(new Kisi(2, "Murat", "Boylu", DateTime.Now, "murat", "1", "üye"));
            kisilerim.Add(new Kisi(3, "Ferhat Fatih", "Boylu", DateTime.Now, "ferhat fatih", "1", "üye"));
            kisilerim.Add(new Kisi(4, "Ahmet Sinan", "Boylu", DateTime.Now, "ahmet sinan", "1", "üye"));

            kitaplarım.Add(new Kitap(1, "İçimizdeki Şeytan", "Sebahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "roman", 100, 250, 2020));
            kitaplarım.Add(new Kitap(2, "tutunamayanlar", "oğuz atay", "Türkçe", "İletişim yayınları", "roman", 350, 750, 2015));
            kitaplarım.Add(new Kitap(3, "uçurtma avcısı", "Khaled", "ingilizce", "everest yayıncılık", "roman", 100, 350, 2010));
        }
    }
}
