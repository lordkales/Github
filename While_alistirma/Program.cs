internal class Program
{
    private static void Main(string[] args)
    {
        //1'den 10'a kadar sayıları ekrana yazdır.
        int a =1;
        while (a<=10)
        {
            Console.WriteLine(a);
            a++;
        }

        //100'den 1'e kadar olan çift sayıları büyükten küçüğe yazdır

        int b =100;
        while (b>=0)
        {
            Console.WriteLine(b);
            b-=2;
        }
    }
}