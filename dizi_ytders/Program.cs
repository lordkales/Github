internal class Program
{
    private static void Main(string[] args)
    {
       int [] sayilar = new int [4];
       sayilar[0]=10;
       sayilar[1]=20;
       sayilar[2]=30;
       sayilar[3]=40;
       
       for (int i = 0; i < sayilar.Length; i++)
       {
        Console.WriteLine(sayilar[i]);
       }
       
       // Diğer Veri Tipleri ile Dizi Tanımlama
       string [] isimler = {"Ali","Veli"};
       double [] ondaliklilar={1.25,2.65,15.45};
       char [] karakter={'a','b','c'};

        Console.WriteLine("İSİMLER: ");
       for (int i = 0; i < isimler.Length; i++)
       {
        Console.WriteLine(isimler[i]);
       }
       Console.WriteLine("ONDALIKLILAR: ");
       for (int i = 0; i < ondaliklilar.Length; i++)
       {
        Console.WriteLine(ondaliklilar[i]);
       }
       Console.WriteLine("KARAKTER: ");
       for (int i = 0; i < karakter.Length; i++)
       {
        Console.WriteLine(karakter[i]);
       }

       // Dizinin elemanlarını klavyeden alma

       int [] sayilar12 = new int [3];

       for (int i = 0; i < sayilar12.Length; i++)
       {
        Console.Write("Dizinin "+(i+1)+". elemanı gir: ");
        sayilar12[i] = Convert.ToInt32(Console.ReadLine());
       }
       
       for (int i = 0; i < sayilar12.Length; i++)
       {
        Console.WriteLine(sayilar12[i]);
       }
    }
}