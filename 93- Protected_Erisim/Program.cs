internal class Program
{
    private static void Main(string[] args)
    {
        papatya p1 = new papatya();
        p1.papatyabilgileri();
    }

    public class bitki
    {
        public int bitkiid { get; set; }
        protected string bitkiadi { get; set; }
        public string bitkirengi { get; set; }
    }
    public class papatya : bitki
    {
        public void papatyabilgileri()
        {
            bitkiid=1;
            bitkiadi="papatya";
            bitkirengi="Ortasında sarı top, etrafında beyaz yapraklar";
            System.Console.WriteLine("Bitki ID: "+bitkiid);
            System.Console.WriteLine("Bitki Adı: "+bitkiadi);
            System.Console.WriteLine("Bitki Rengi: "+bitkirengi);
        }
    }
}