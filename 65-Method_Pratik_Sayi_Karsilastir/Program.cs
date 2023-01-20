internal class Program
{
    private static void Main(string[] args)
    {
        // Kullanıcıdan aldığımız 2 sayıdan büyük olanı ekrana yazdıran uygulama
        Console.WriteLine("Lütfen Karşılaştırmak İstediğiniz 2 Sayı Girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        
        buyukmu(sayi1,sayi2);
    }
    static void buyukmu(int sayi1, int sayi2)
    {
        if (sayi1>sayi2)
        {
            Console.WriteLine("Büyük Sayı: "+sayi1);
        }
        else if(sayi1==sayi2)
        {
            Console.WriteLine("Sayılar Birbirine Eşittir");
        }
        
        else
        {
            Console.WriteLine("Büyük Sayı: "+sayi2);
        }
    }
}