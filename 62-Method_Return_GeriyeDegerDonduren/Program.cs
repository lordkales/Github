internal class Program
{
    private static void Main(string[] args)
    {
        // 1. Geriye değer döndürmesi
        // 2. return anahtar kelimesi metodu bitiren kelimedir.
        
     string geridonenadsoyad = adsoyad("Burak Akif","Boylu");
     Console.WriteLine(geridonenadsoyad);

     int geridonensonuc=toplama(1,2);
     Console.WriteLine(geridonensonuc);
    }

    static int toplama (int sayi1, int sayi2)

    {
        int sonuc;
        return sonuc=sayi1+sayi2;
    }
    static string adsoyad(string ad, string soyad)
    {
        return ad+" "+soyad;
    }
}