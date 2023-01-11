internal class Program
{
    private static void Main(string[] args)
    {
        //Kullanıcıdan 3 not al, ortalamasını bul
        //eğer ortalama 80-100 arasındaysa A+
        //60-80 arasındaysa A
        //40-60 arasındaysa B+
        //40'dan küçükse F yazdıran programın kodlarını yazın.

    
        Console.WriteLine("Lütfen 1. Notunuzu Giriniz: ");
        int birincinot=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen 2. Notunuzu Giriniz: ");
        int ikincinot=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen 3. Notunuzu Giriniz: ");
        int ucuncunot=Convert.ToInt32(Console.ReadLine());

        int ortalama=(birincinot+ikincinot+ucuncunot)/3;

        if(ortalama>=80)
        {
            Console.WriteLine("A+");
        }
        else if (ortalama<80 && ortalama>=60)
        {
            Console.WriteLine("A");
        }
        else if (ortalama>=40 && ortalama<60 )
        {
            Console.WriteLine("B+");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}