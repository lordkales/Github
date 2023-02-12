using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        /*ArrayList koleksiyon = new ArrayList();
        koleksiyon.Add(1);
        koleksiyon.Add("Burak");
        koleksiyon.Add(3.5);  */
        degerekle(5);
    }
    static void degerekle(int deger)
    {
        ArrayList koleksiyon = new ArrayList();
        koleksiyon.Add(deger);
    }
}