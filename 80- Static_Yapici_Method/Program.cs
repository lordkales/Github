internal class Program
{
    private static void Main(string[] args)
    {
        kullanici k1 = new kullanici(1,"Burak Akif","Boylu");

        k1.bilgilerigoster();
        k1.zamyap(500);
        
    }
    public class kullanici
    {
        private int kullaniciID { get; set; }
        private string isim { get; set; }
        private string soyisim { get; set; }
        private static int maas { get; set; }

        
        static kullanici()
        {
            maas=32000;
        }

        public kullanici(int _kullaniciid, string _isim, string _soyisim)
        {
            kullaniciID=_kullaniciid;
            isim=_isim;
            soyisim=_soyisim;
        }

        public void bilgilerigoster()
        {
            Console.WriteLine("Kullanıcı Bilgileri");
            Console.WriteLine("ID: "+kullaniciID);
            Console.WriteLine("İsim: "+isim);
            Console.WriteLine("Soyisim: "+soyisim);
            Console.WriteLine("Maaş: "+maas);
        }

        public void zamyap(int zammiktari)
        {
            Console.WriteLine("Kullanıcıya Zam Yapılıyor.");
            Console.WriteLine("Yeni Maaş: "+(maas+zammiktari));
        }
    }
}