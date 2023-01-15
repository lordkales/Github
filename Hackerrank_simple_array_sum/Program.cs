internal class Program
{
    private static void Main(string[] args)
    {
        
        // ÇALIŞAN KOD

        /*int dizisayisi=Convert.ToInt32(Console.ReadLine());
        int [] ar = new int [dizisayisi];
        int toplam=0;
        
        for(int i=0; i<dizisayisi;i++)
        {
            ar[i]=Convert.ToInt32(Console.ReadLine());
            toplam=toplam+ar[i];
        }
        Console.WriteLine(toplam);*/

        // HACKERRANK'TE ÇALIŞAN KOD
        
        /*int toplam=0;
        
        for(int i=0; i<ar.Count;i++)
        {
            toplam=toplam+ar[i];
        }
        return toplam;*/

        // Day 7: Arrays

        
        int [] A= {1,2,3,4};
        Array.Reverse(A);
        foreach (var b in A)
        {
            Console.Write(b+" "); 
            
        }
    }
}