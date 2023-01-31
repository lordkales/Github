internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Adınızı Giriniz");
        string isim=Console.ReadLine();
        Console.WriteLine("Soyadınızı Giriniz");
        string soyad=Console.ReadLine();
        Console.WriteLine("Yaşınızı Giriniz");
        int yas=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Mesleğinizi Giriniz");
        string meslek=Console.ReadLine();
        
        kisi k1 = new kisi();
        k1.goster(isim,soyad,yas,meslek);

    }
    class kisi
    {
        public void goster(string _ad, string _soyad, int _yas, string _meslek)
        {
           Console.WriteLine("Adınız: "+_ad+" Soyadınız: "+_soyad+" Yaşınız: "+_yas+" Mesleğiniz: "+_meslek);
        }
    }
}