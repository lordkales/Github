internal class Program
{
    private static void Main(string[] args)
    {
        int [] sayilar = new int [2];

        for(int i=0; i <sayilar.Length;i++)
        {
            Console.Write("Dizinin "+(i)+". sayısını giriniz: ");

            sayilar[i]=Convert.ToInt32(Console.ReadLine());
        }
        for (int i=0; i<sayilar.Length;i++)
        {
            Console.WriteLine(sayilar[i]);
        }
    }
}