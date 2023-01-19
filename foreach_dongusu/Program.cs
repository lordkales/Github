internal class Program
{
    private static void Main(string[] args)
    {
        /*string [] isimler = {"akif","tuğçe","ela"};
        
        foreach (string ad in isimler)
        {
            Console.WriteLine(ad);
        }

        int [] sayi={1,2,3,4,5};

        foreach (int say in sayi)
        {
            Console.WriteLine(say);
        }

        double [] ondalikss= {1.2,2.6};
        foreach (double  on in ondalikss)
        {
            Console.WriteLine(on);
        }*/

        /*int [] sayilar ={1,2,3,4,5,6,7,8,9,10,20,30,40,50,60,70,80,90,100,5,6,7,5,6,7,4,5,6,7,8,6,5,6,7,6};

        Console.Write("Yazdığın sayı dizide var mı? Sayını Yaz: ");
        int tahmin = Convert.ToInt32(Console.ReadLine());
        int tane=0;
        for (int i = 0; i < sayilar.Length; i++)
        {
            if (tahmin==sayilar[i])
            {
                tane++;
            }
        }
        if (tane==0)
        {
            Console.WriteLine("DİZİDE MEVCUT DEĞİL");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayi dizide "+tane+ " adet vardır");
        }*/
                

        // Kullanıcıdan 10 sayı al
        // Kaç tane tek kaç tane çift sayı var yaz
        // Çiftlerin toplamı teklerin toplamını yaz
        // Çiftlerin toplamı mı teklerin toplamı mı büyük ekrana yazdır

        Console.WriteLine("10 adet sayı girin");
        int [] sayi = new int [10];
        int tek=0;
        int cift=0;
        int cifttoplam=0;
        int tektoplam=0;

        for (int i = 0; i < sayi.Length; i++)
        {
            sayi[i]= Convert.ToInt32(Console.ReadLine());

            if (sayi[i]%2==0)
            {
                cift++;
                cifttoplam=cifttoplam+sayi[i];
            }
            else{
                tek++;
                tektoplam=tektoplam+sayi[i];
            }
        }
        Console.WriteLine(cift+" tane çift sayı var");
        Console.WriteLine(tek +" tane tek sayı var");
        Console.WriteLine("Çift sayıların toplamı: "+cifttoplam);
        Console.WriteLine("Tek sayıların toplamı: "+tektoplam);

        if (cifttoplam>tektoplam)
        {
            Console.WriteLine("ÇİFT SAYILARIN TOPLAMI TEK SAYILARIN TOPLAMINDAN BÜYÜK");
        }
        else
        {
            Console.WriteLine("TEK SAYILARIN TOPLAMI ÇİFT SAYILARIN TOPLAMINDAN BÜYÜK");
        }
        

    }
}