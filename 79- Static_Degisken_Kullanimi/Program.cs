internal class Program
{
    private static void Main(string[] args)
    {
       // STATIC DEĞİŞKEN KULLANIMI
       
       calisan adam=new calisan();
       adam.adi="Burak Akif";
       adam.soyadi="BOYLU";
       adam.calisanid=1;

       calisan.maas=32000;

       Console.WriteLine("ÇALIŞAN ID: "+adam.calisanid);
       Console.WriteLine("ÇALIŞAN AD: "+adam.adi);
       Console.WriteLine("ÇALIŞAN SOYAD: "+adam.soyadi);
       Console.WriteLine("ÇALIŞAN MAAŞ: "+calisan.maas);
    }
    public class calisan
    {
        //public int calisanid;
        //public string adi;
        //public string soyadi;
        //public static int maas;

        // PRORERTY OLARAK TANIMLANABİLİR

        public int calisanid { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public static int maas { get; set; }
    }
}