internal class Program
{
    private static void Main(string[] args)
    {
        // Kullanıcıdan aldığımız sayının karesini al
        // Sonuç 25'ten büyükse büyük, küçükse küçük yazdıran kodlar
        
        Console.Write("Lütfen sayı gir: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        int gelensonuc=karesi(sayi);
        if (gelensonuc>25)
        {
            Console.WriteLine("Sayınız: "+gelensonuc+"; 25'ten büyük");
        }
        else if (gelensonuc==25)
        {
            Console.WriteLine("Sayınız: "+gelensonuc+"; 25'e eşit");
        }
        else
        {
            Console.WriteLine("Sayınız: "+gelensonuc+"; 25'ten küçük");
        }
    }
    static int karesi(int sayi)
    {
        
        return sayi*sayi;
    }
}