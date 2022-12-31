internal class Program
{
    private static void Main(string[] args)
    {
        //Yazdığınız Sayıya Kadar Olan Tek Sayıları Göster
        Console.Write("Lütfen Bir Sayı Giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < sayi; i++)
        {
            if (i%2==1)
            {
                Console.WriteLine(i);
            }
        }

        //Yazdığınız Sayıya Kadar Tek Sayıların ve Çift Sayıların Toplamını Göster

        Console.WriteLine("Lütfen bir sayı giriniz:");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        int teksayi = 0;
        int ciftsayi = 0;

        for (int i = 0; i < sayi1; i++)
        {
            if (i%2==0)
            {
                ciftsayi = ciftsayi+i;
            }
            else
            {
                teksayi += i;
            }
        }
        Console.WriteLine("Çift Sayı Toplamı: "+ciftsayi);
        Console.WriteLine("Tek Sayı Toplamı: "+teksayi);

        // Break, Continue
    }
}