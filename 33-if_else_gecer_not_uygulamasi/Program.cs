internal class Program
{
    private static void Main(string[] args)
    {
        // öğrencinin notu 50'den büyükse geçti, 50'den küçükse kaldı yazınız.
        int not = 75;
        
        if (not>50)
        {
            Console.WriteLine("Geçtiniz");
        }
        else{
            Console.WriteLine("Kaldınız");
        }
    }
}