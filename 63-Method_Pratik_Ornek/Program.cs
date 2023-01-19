internal class Program
{
    private static void Main(string[] args)
    {
        // Kullanıcıdan aldığımız sayının karesini al
        // Sonuç 25'ten büyükse büyük, küçükse küçük yazdıran kodlar

        Console.Write("Lütfen bir sayı giriniz: ");
        int sayi=Convert.ToInt32(Console.ReadLine());
        int donenkare=alkaresini(sayi);

        if (donenkare>25)
        {
            Console.WriteLine("Sayınız: "+donenkare+ "; 25'ten büyüktür.");
        }
        else if (donenkare==25)
        {
            Console.WriteLine("Sayınız: 25'tir. ");
        }
        else
        {
            Console.WriteLine("Sayınız: "+donenkare+ "; 25'ten küçüktür.");
        }
          
        
    }
    static int alkaresini(int sayi)
    {
        return sayi*sayi;
    }
}