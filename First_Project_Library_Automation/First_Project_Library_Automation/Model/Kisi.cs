using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project_Library_Automation.Model
{
    public class Kisi
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmatarih { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }


        public Kisi()
        {

        }

        public Kisi(int id, string isim, string soyisim, DateTime olusturmatarih,string kullaniciadi,string sifre, string yetki)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.olusturmatarih = olusturmatarih;
            this.kullaniciadi = kullaniciadi;
            this.sifre = sifre;
            this.yetki = yetki;

        }

        public void SetID (int id)
        {
            this.id = id;
        }
        public int GetID()
        {
            return this.id;
        }

        public void SetIsim (string isim)
        {
            this.isim = isim;
        }
        public string GetIsim()
        {
            return this.isim;
        }

        public void SetSoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }
        public string GetSoyisim()
        {
            return this.soyisim;
        }

        public void SetOlusturmatarihi (DateTime olusturmatarih)
        {
            this.olusturmatarih = olusturmatarih;
        }
        public DateTime GetOlusturmatarih()
        {
            return this.olusturmatarih;
        }
        public void SetKullaniciadi(string kullaniciadi)
        {
            this.kullaniciadi = kullaniciadi;
;        }
        public string GetKullaniciadi()
        {
            return this.kullaniciadi;
        }

        public void SetSifre(string sifre)
        {
            this.sifre = sifre;
        }
        public string GetSıfre()
        {
            return this.sifre;
        }

        public void SetYetki(string yetki)
        {
            this.yetki = yetki;
        }
        public string GetYetki()
        {
            return this.yetki;
        }

        public override string ToString()
        {
            return "İsim - Soyisim: " + this.isim + " " + this.soyisim;
        }

    }
}
