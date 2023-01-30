internal class Program
{
    public static void Main(string[] args)
    {
        kedi kedi1=new kedi();
        kedi1.hayvanisim="Osman";
        kedi1.hayvancinsiyet="Erkek";
        kedi1.hayvanrengi="Boz";

        kedi1.hayvanbilgisigoster();

    }
    public class hayvan
    {
        public string hayvanisim;
        public string hayvancinsiyet;
        public string hayvanrengi;
        private int hayvanyasi;

        public void hayvanbilgisigoster()
        {
            Console.WriteLine("Hayvan ismi: "+hayvanisim);
            Console.WriteLine("Hayvan cinsiyeti: "+hayvancinsiyet);
            Console.WriteLine("Hayvan Rengi: "+hayvanrengi);
        }
    }
    public class kedi : hayvan
        {
            // HİÇBİR ŞEY YAZMIYORUM            
        }
}