internal class Program
{
    private static void Main(string[] args)
    {
        try
      {
        Console.WriteLine("*** NOT ORTALAMANI ÖĞREN! ***");
        Console.WriteLine("3 karne notunuzu giriniz");
        int a =int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int ortalama = (a+b+c)/3;
        Console.WriteLine("Ortalamanız: "+ortalama); 

        if(ortalama>=80 && ortalama<=100)
        {
            Console.WriteLine("Notunuz: A+");
        }
        
        else if (ortalama>=60 && ortalama<=79)
        {
            Console.WriteLine("Notunuz: A");
        }

        else if (ortalama>=40 && ortalama<=59)
        {
            Console.WriteLine("Notunuz: B+");
        }

        else if (ortalama<=39)
        {
            Console.WriteLine("Notunuz: F");
        }
      }
      catch(FormatException){
        Console.WriteLine("HATALI VERİ GİRDİNİZ");
      }
    }
}