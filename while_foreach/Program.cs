internal class Program
{
    private static void Main(string[] args)
    {
     //1'den başlayarak console'dan girilen sayıya kadar ortalama hesaplayıp yazdır

     //Console.WriteLine("Sayı Giriniz: ");
     //int sayi = int.Parse(Console.ReadLine());
     //int toplam=0;
     //int sayac=1;
     //while (sayac<=sayi)
     //{
     //    toplam+=sayac;
     //    sayac++;
     //}
     //Console.WriteLine(toplam/sayi);

     ////a'dan z'ye kadar tüm harfleri konsola yazdır

     //char harf = 'a';

     //while (harf <= 'z')
    {//
     //Console.Write(harf);
     //harf++;
    }

    //FOREACH
        Console.WriteLine("*** FOREACH ***");
        string[] arabamarkalari={"BMW", "FORD", "VOLVO", "MERCEDES", "TOYOTA"};
        foreach (var markalar in arabamarkalari)
        {
            Console.WriteLine(markalar);
        }
    }
}