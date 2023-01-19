internal class Program
{
    private static void Main(string[] args)
    {
        // PARAMETRE ALAN, GERİYE DEĞER DÖNDÜRMEYEN METOT

        toplama(1,2);
        carpma(1,2,3);
        bolme(10,5);
        cikarma(10,2);
    }

    static void toplama(int sayi1, int sayi2)
    {
        Console.WriteLine("SAYILARIN TOPLAMI: "+(sayi1+sayi2));
    }

    static void carpma(int sayi1, int sayi2, int sayi3)
    {
        Console.WriteLine("SAYILARIN ÇARPIMI: "+(sayi1*sayi2*sayi3));
    }

    static void bolme(int sayi1, int sayi2)
    {
        Console.WriteLine("SAYILARIN BÖLÜMÜ: "+(sayi1/sayi2));
    }

    static void cikarma(int sayi1, int sayi2)
    {
        Console.WriteLine("ÇIKARMA SONUCU: "+(sayi1-sayi2));
    }
}