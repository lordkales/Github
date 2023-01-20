internal class Program
{
    private static void Main(string[] args)
    {
        // Kullanıcının girdiği sayının tek mi çift mi olduğunu yazdıran kodlar
       Console.WriteLine("Lütfen bir sayı giriniz: ");

       int sayi = Convert.ToInt32(Console.ReadLine());
       
       kontrol(sayi);
        
    }

    static void kontrol (int sayi)
    {
        if (sayi%2==0)
        {
            Console.WriteLine("Sayınız Çift");
        }
        else
        {
            Console.WriteLine("Sayınız Tek");
        }
        
    }
}