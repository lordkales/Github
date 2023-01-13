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
    }
}