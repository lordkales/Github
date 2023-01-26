using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList koleksiyon = new ArrayList();
        koleksiyon.Add("Burak");
        koleksiyon.Add("Akif");
        koleksiyon.Add("Boylu");

        //koleksiyon.Remove("Akif");
        //int count = koleksiyon.Count;
        //koleksiyon.Clear();
        //bool kontrol=koleksiyon.Contains("Yasin");
        //int index= koleksiyon.IndexOf("Akif");
        //koleksiyon.Insert(2,"Ercüment");
        //koleksiyon.Reverse();
        //koleksiyon.Sort();

        foreach (var item in koleksiyon)
        {
            Console.WriteLine(item);
        }
        
    }
}