internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*** KARNE NOTU HESAPLAMA ***");
        try
       {
        Console.WriteLine("Not Ortalamanızı Girin: ");
        int not = int.Parse(Console.ReadLine());
        
        if(not<=30)
        {
            Console.WriteLine("Karne Notunuz 0");
        }
        if (not>=31 && not<=44)
        {
            Console.WriteLine("Karne Notunuz 1");
        }
        if(not>=45 && not<=54)
        {
        Console.WriteLine("Karne Notunuz 2");
        }
        if(not>=55 && not<=69)
        {
            Console.WriteLine("Karne Notunuz 3");
        }
        if(not>=70 && not<=84)
        {
            Console.WriteLine("Karne Notunuz 4");
        }
        if(not>=85 && not<=100)
        {
            Console.WriteLine("Karne Notunuz 5");
        }
       }
       catch(FormatException)
       {
        Console.WriteLine("HATALI VERİ GİRDİNİZ");
       }

    }
}