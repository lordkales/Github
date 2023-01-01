internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1'den 10'a kadar olan sayıları yaz:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("1'den 10'a kadar olan çift sayıları yaz:");
        for (int a =1; a<=10;a++)
        {
            if (a%2==0)
            {
                Console.WriteLine(a);
            }
            
        }
        // İÇ İÇE FOR DÖNGÜSÜ

        Console.WriteLine("1'den 10'a kadar her satırda artırarak yazdır");

        for (int a = 1;a<=10;a++)
        {
            for (int b=1; b<=a;b++)
            {
                Console.Write(b);
            }
            Console.WriteLine(" ");
        }

        // ÇARPIM TABLOSU YAPIMI
    
        Console.WriteLine("*** ÇARPIM TABLOSU ***");
        
        Console.WriteLine("     1 2 3 4 5 6 7 8 9 10 ");
        for (int altcizgi = 1; altcizgi <=22; altcizgi++)
        {
            Console.Write("_");
        }
        Console.WriteLine();
        for (int i = 1; i <=10; i++)
        {
            if(i<10)
            {
            Console.Write(i+" | ");
            }
            else
            {
                Console.Write(i+"|");
            }
            for (int j = 1; j <= 10; j++)
            {
                Console.Write(i*j+" ");
            }
            Console.WriteLine();
        }
    }
}