internal class Program
{
    private static void Main(string[] args)
    {
        int ay = DateTime.Now.Month;
        
        switch (ay)
        {
            case 1:
                Console.WriteLine("Ocak Ayındasınız");
                break;
            case 12:
            Console.WriteLine("Aralık Ayındasınız");
            break;

        }
    }
}