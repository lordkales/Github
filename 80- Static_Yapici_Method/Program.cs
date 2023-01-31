internal class Program
{
    private static void Main(string[] args)
    {
    personel p1 = new personel(1,"burak","boylu");
    p1.bilgilerigoster();
    p1.zamyap(5000);
    }
    public class personel
    {
        private int kullaniciid { get; set; }
        private string isim { get; set; }
        private string soyisim {get; set;}
        private static int maas { get; set; }

        static personel()
        {
        maas=30000;
        }
        public personel(int _kullaniciid, string _isim, string _soyisim)
        {
            kullaniciid=_kullaniciid;
            isim=_isim;
            soyisim=_soyisim;
        }
        public void bilgilerigoster()
        {
            Console.WriteLine("Kullanıcı ID: "+kullaniciid);
            Console.WriteLine("Kullanıcı İsim: "+isim);
            Console.WriteLine("Kullanıcı Soyisim: "+soyisim);
            Console.WriteLine("Maaş: "+maas);
        }
        public void zamyap(int zam)
        {
            Console.WriteLine("Zam Yapıldı");
            Console.WriteLine("Şuanki maaşı: "+(maas+zam));
        }
    }
}