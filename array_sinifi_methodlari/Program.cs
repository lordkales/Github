internal class Program
{
    private static void Main(string[] args)
    {
        //SORT (SIRALA)
        int [] sayidizisi = {5,20,12,45,74,24,96};
        foreach (var sayi in sayidizisi)
        Console.WriteLine(sayi);

        Console.WriteLine("sıralı yazdır");
        Array.Sort(sayidizisi);

        foreach (var sayi in sayidizisi)
        Console.WriteLine(sayi);

        //CLEAR
        Console.WriteLine("ARRAY CLEAR");
        //sayidizisi elemanlarını kullanarak 2. indexten başlayıp 3 elemanı 0'lar
        Array.Clear(sayidizisi,2,3);

        foreach (var sayi in sayidizisi)
        Console.WriteLine(sayi);

        //REVERSE(TERS ÇEVİRME AYNALAMA)

        Console.WriteLine(" **** ARRAY REVERSE **** ");
        Array.Reverse(sayidizisi);

        foreach (var sayi in sayidizisi)
        Console.WriteLine(sayi);

        //indexof
        // dizi içerisinde bulunan bir elemanın kaçıncı indexde olduğunu gösterir, eleman
        // yoksa -1 döner

        Console.WriteLine(" **** indexof **** ");
        Console.WriteLine(Array.IndexOf(sayidizisi,74));

        //Resize (Diziye eleman ekleme)

        Console.WriteLine(" **** ARRAY RESIZE **** ");
        Array.Resize<int>(ref sayidizisi,8);
        sayidizisi[7]=(14);
        foreach(var sayi in sayidizisi)
        Console.WriteLine(sayi);
        
        Console.WriteLine("TEKRAR SIRALA");
        Array.Sort(sayidizisi);
        foreach(var sayi in sayidizisi)
        Console.WriteLine(sayi);


    }
}