internal class Program
{
    private static void Main(string[] args)
    {
        araba a = new araba();
        a.renk="MAVİ";
        a.durum='0';
        a.fiyat=150000;
        a.hiz=240;
        a.motor=1.6;
        a.MARKA="HONDA";
        a.MODELYILI=2020;
        Console.WriteLine(a.renk);
        Console.WriteLine(a.durum);
        Console.WriteLine(a.fiyat);
        Console.WriteLine(a.hiz);
        Console.WriteLine(a.motor);
        Console.WriteLine(a.MARKA);
        Console.WriteLine(a.MODELYILI);

    }
    class araba
    {
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;
        private int modelyili;
        private string marka;

        public int MODELYILI { get{return modelyili;} set{modelyili=value;} }
        public string MARKA { get{return marka;} set{marka=value;} }
    }
}