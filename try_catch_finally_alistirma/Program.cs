//try
//{
//int x =5;
//int y = 0;
//x =x/y;
//}
//catch
//{
//    Console.WriteLine("sıfıra bölme yapılamaz");
//}

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("1. Notu girin: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("2. notu girin: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Ortalama: " + x / y);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Sıfıra bölme yapılamaz" + ex);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Sınır Değer Dışında Sayı Girdiniz:" + ex);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş Değer Girdiniz: " + ex);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Yanlış Format Girdiniz" + ex);
        }
    }
}