internal class Program
{
    private static void Main(string[] args)
    {
        //1'den 10'a kadar sayıları ekrana yazdır.
        /*int a =1;
        while (a<=10)
        {
            Console.WriteLine(a);
            a++;
        }*/

        //100'den 1'e kadar olan çift sayıları büyükten küçüğe yazdır

        /*int b =100;
        while (b>=0)
        {
            Console.WriteLine(b);
            b-=2;
        }*/

<<<<<<< HEAD
        // Klavyeden girilen sayıdan geriye doğru birer saniye arayla sayan bir sayaç hazırlayalım

        /*int sayi = Convert.ToInt32(Console.ReadLine());
        
        while(sayi>=0)
        {
        Console.WriteLine(sayi);
        System.Threading.Thread.Sleep(1000);
        sayi--;
        }*/

        //O ile 100 arasındaki tek sayıları toplayarak sonucu ekranda gösteren programı yapalım

        /*int sayi=100;
        int toplam=0;
        while(sayi>0)
        {
            
            if (sayi%2==1)
            {
                toplam=toplam+sayi;
            }
            
         sayi--;
        }
        Console.WriteLine(toplam);*/

        //Klavyeden girilen sayının faktöriyelini hesaplayalım

        Console.WriteLine("Faktöriyeli Alınacak Sayıyı Yazın: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int fakt=1;

        while(sayi>1)
        {
            fakt=fakt*sayi;
            sayi--;
        }
        Console.WriteLine(fakt);
=======
        //1'den 10'a kadar sayıları ekrana yazdır. (do while ile)
        int a=1;
        do
        {
            Console.WriteLine(a);
            a++;
        } while (a<=10);

        //1'den 100'e kadar olan sayıların toplamı yazdır (do while ile)

        int toplam=0,b=1;
        
        do
        {
            toplam=toplam+b;
            b++;
        } while (b<=100);
        Console.WriteLine(toplam);
>>>>>>> 5e7375e22b67bb2b24f01b7fa6880093fbae5c28
    }
}