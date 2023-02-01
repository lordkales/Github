using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
       ArrayList arraylist;
    }
    public class hayvan
    {
        public string hayvan_isim;
        public string hayvan_renk;
        public int hayvan_kilo;

    }
    public class kopek : hayvan
    {
        public int kopek_ayaksayisi;
        public string kopek_cinsiyet;

    }
    public class kedi : kopek
    {
        public string kedi_sesi;
        public void kedi_yazdir()
        {
            Console.WriteLine("Kedi Sesi: "+kedi_sesi);
            Console.WriteLine("Hayvan İsmi: "+hayvan_isim);
            Console.WriteLine("Hayvan Rengi: "+hayvan_renk);
            Console.WriteLine("Hayvan Kilo: "+hayvan_kilo);
            Console.WriteLine("Köpek Ayak Sayısı: "+kopek_ayaksayisi);
            Console.WriteLine("Köpek Cinsiyet: "+kopek_cinsiyet);
        }
    }
}