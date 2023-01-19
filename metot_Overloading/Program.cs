internal class Program
{
    private static void Main(string[] args)
    {
        // Out parametreler

        string sayi = "999";

        bool sonuc = int.TryParse(sayi, out int outsayi );
        if (sonuc)
        {
            Console.WriteLine("BAŞARILI");
            Console.WriteLine(outsayi);
        }
        else
        {
            Console.WriteLine("BAŞARISIZ");
        }

        // Method Overloading

        Console.WriteLine(multiply(2,3));   
        Console.WriteLine(multiply(4,5,6));   
    }
    static int multiply(int number1, int number2)
    {
        return number1*number2;
    }
    static int multiply(int number1, int number2, int number3)
    {
        return number1*number2*number3;
    }

}