internal class Program
{
    private static void Main(string[] args)
    {
        // SAYILARI MERDİVEN ŞEKLİNDE YAZMA

       /*Console.WriteLine("*** MERDİVEN SAYI YAZ ***");

       for (int i = 1; i <=10; i++)
       {
        for (int j = 1; j <=i; j++)
        {
            Console.Write(j);
        }
        Console.WriteLine();
       }*/


        //DOMATESİN 12 AY BOYUNCA FİYATININ ORTALAMASINI HESAPLAMA

        /*Console.WriteLine("Domates Ortalama Fiyat");

        double toplam = 0;
        double ortalama;
        
        for (int ay = 1; ay <=12; ay++)
        {
            double fiyat = Convert.ToDouble(Console.ReadLine());
            toplam=toplam+fiyat;
        }
        ortalama=toplam/12;
        Console.WriteLine(ortalama);*/


        //Örneğin bir sınıfta 3 tane öğrencimiz olsun. Her biri 4 ders alsın. Tüm öğrencilerin notlarını klavyeden almak isteyelim.

        Console.WriteLine("Notlarınızı Girin: ");
        
        for (int ogrenci = 1; ogrenci <=3; ogrenci++)
        { 
            double not, ortalama=0, toplamnot=0;
            Console.WriteLine(ogrenci+". öğrenci: ");
            for (int sinav = 1; sinav <=4; sinav++)
            {
                not=Convert.ToInt32(Console.ReadLine());
                toplamnot=toplamnot+not;
                ortalama=toplamnot/4;
            }
            
            Console.WriteLine(ogrenci+". öğrenci ortalama: "+ortalama);
        }













        /*//Öğrenci Dersleri
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
        }*/
    }
}