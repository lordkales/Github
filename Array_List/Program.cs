using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList koleksiyon = new ArrayList();
        koleksiyon.Add("Ali");
        koleksiyon.Add("veli");
        koleksiyon.Add("mahmut");

        //koleksiyon.Remove("veli"); Elemanı siler
        //int tane = koleksiyon.Count; kaç tane eleman olduğunu sayar
        //bool kontrol = koleksiyon.Contains("Ali") koleksiyon dizimde Ali var mı kontrol et
        //int index = koleksiyon.Insert(2,"Ali") 2. indexe Ali ekler
        //koleksiyon.Reverse(); sondan başa ters çevirir
        //koleksiyon.Sort(); diziyi küçükten büyüğe sıralar

        int tane = koleksiyon.Count;

        foreach (var ad in koleksiyon)
        {
            Console.WriteLine(ad);
        }
        Console.WriteLine("Eleman sayısı: "+tane);
    }
}