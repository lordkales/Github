internal class Program
{
    private static void Main(string[] args)
    {
        int mumsayisi = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < mumsayisi; i++)
        {
            int mumgir = Convert.ToInt16(Console.ReadLine());
            int buyukmum = Math.Max(mumgir,mumsayisi);
        }
        
        /*int [] mum = new int [3];
        int mumboyu = Convert.ToInt32(Console.ReadLine());
        int uzunmum = mumboyu.max();*/
        

    }
}