internal class Program
{
    private static void Main(string[] args)
    {
        // Kullanıcının girdiği sayının tek mi çift mi olduğunu yazdıran kodlar

        Console.WriteLine("TEK ÇİFT BULMA ROBOTUNA HOŞGELDİNİZ!! ");
        Console.Write("Lütfen bir sayı giriniz: ");
        int sayi=Convert.ToInt32(Console.ReadLine());
        int gelensonuc=sonuc(sayi);

        if (gelensonuc==0)
        {
            Console.WriteLine("SAYI ÇİFT");
        }
        else
        {
            Console.WriteLine("SAYI TEK");
        }
        
    }
    static int sonuc(int sayi)
    {
        return sayi%2;
    }
}