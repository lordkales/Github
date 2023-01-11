internal class Program
{
    private static void Main(string[] args)
    {
        // Beden Kitle indeksi = Kilo/Boy*Boy
        // Beden kitle indeksi 18'e eşit veya düşükse ZAYIF
        // 18 ile 25 arasındaysa NORMAL
        // 25'ten büyükse OBEZ yazdıran programın kodlarını yazınız.

        Console.WriteLine("Beden Kitle İndeksi Hesaplamaya Hoşgeldiniz!");

        Console.WriteLine("Boyunuzu metre cinsinden giriniz");
        double boy = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Kilonuzu kg cinsinden yazınız:");
        int kilo = Convert.ToInt32(Console.ReadLine());
        
        double kitleindeksi=kilo/(boy*boy);

        if (kitleindeksi<=18)
        {
            Console.WriteLine("Kitle İndeksiniz: "+kitleindeksi+ " olduğundan ZAYIF kategorisine girmektesiniz.");
        }
        else if (kitleindeksi>18 && kitleindeksi<25)
        {
            Console.WriteLine("Kitle İndeksiniz: "+ kitleindeksi+ " olduğundan NORMAL kategorisine girmektesiniz.");
        }
        else if (kitleindeksi>25)
        {
            Console.WriteLine("Kitle İndeksiniz: "+ kitleindeksi+ " olduğundan OBEZ kategorisine girmektesiniz.");
        }

    }
}