internal class Program
{
    private static void Main(string[] args)
    {
        // SAYILARI MERDİVEN ŞEKLİNDE YAZMA

        /*Console.WriteLine("MERDİVEN SAYI YAZMA");
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }*/


        //DOMATESİN 12 AY BOYUNCA FİYATININ ORTALAMASINI HESAPLAMA

        /*Console.WriteLine("--- DOMATESİN YILLIK ORTALAMA FİYATI ---");
        double toplam=0, fiyat, ortalama;
        for (int i = 1; i <= 12; i++)
        {
            Console.Write("{0}.ay domatesin fiyatı: ",i);
            fiyat=double.Parse(Console.ReadLine());
            toplam=fiyat+toplam;
        }
        ortalama=toplam/12;
        ortalama=Math.Round(ortalama,2);
        Console.WriteLine("ORTALAMA: "+ortalama);*/
        

        //Öğrenci Dersleri
        double not, ortalama;
        for (int ogrenci = 1; ogrenci <=2; ogrenci++)
        {
            double toplamnot=0;
            for (int ders = 1; ders <= 3; ders++)
            {
                Console.WriteLine(ogrenci+". öğrencinin "+ders+". notu: ");
                not=double.Parse(Console.ReadLine());
                toplamnot=not+toplamnot;
            }
            ortalama=toplamnot/3;
            Console.WriteLine("ORTALAMA: "+ortalama);
        }
    }
}