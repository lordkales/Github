internal class Program
{
    private static void Main(string[] args)
    {
        //Klavyeden girilen sayının negatif, pozitif veya sıfır olduğunu gösteren program
        Console.WriteLine("Yaz Bakalım Negatif mi Pozitif mi Bileyim");

        int sayi=Convert.ToInt32(Console.ReadLine());

        if(sayi<0)
        {
            Console.WriteLine("SAYI NEGATİF!");
        }
        else if(sayi==0)
        {
        Console.WriteLine("SAYI 0");
        }
        else if (sayi>0)
        {
            Console.WriteLine("SAYI POZİTİF");
        }
    }
}