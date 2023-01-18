internal class Program
{
    private static void Main(string[] args)
    {
        // Kullanıcının girdiği sayının tek mi çift mi olduğunu yazdıran kodlar
        Console.WriteLine("Lütfen bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int kalan=kontrol(sayi);

        if (kalan==0)
        {
            Console.WriteLine(sayi+" Sayısı Çift Sayıdır.");
        }
        else
        {
            Console.WriteLine(sayi+" Sayısı Tek Sayıdır.");
        }
        
    }
    static int kontrol(int sayi)
    {
        return sayi%2;
    }
}