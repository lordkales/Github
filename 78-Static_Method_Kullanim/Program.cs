internal class Program
{
    private static void Main(string[] args)
    {
        // STATIC KULLANIMI
        Personel.isimsoyisim();
        Personel.topla(2,3);
    }
    public class Personel
    {
        public static void isimsoyisim()
        {
            Console.WriteLine("Burak Akif Boylu");
        }
        public static void topla(int sayi1, int sayi2)
        {
            Console.WriteLine("İki Sayının Toplamı: "+(sayi1+sayi2));
        }
    }
}