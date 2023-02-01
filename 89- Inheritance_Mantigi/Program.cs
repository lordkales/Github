internal class Program
{
    private static void Main(string[] args)
    {
        kedi k1 = new kedi();
        k1.hayvan_cinsiyet="Erkek";
        k1.hayvan_ismi="Osman";
        k1.hayvan_rengi="Boz";
        k1.hayvanbilgisigoster();
        
    }
    public class hayvan
    {
        public string hayvan_ismi;
        public string hayvan_cinsiyet;
        public string hayvan_rengi;
        private int hayvan_yas;

        public void hayvanbilgisigoster()
        {
            Console.WriteLine("Hayvanın ismi: "+hayvan_ismi+" Hayvan Cinsiyeti: "+ hayvan_cinsiyet+" Hayvan Rengi: "+hayvan_rengi);
        }
    }

    class kedi : hayvan
    {

    }
}