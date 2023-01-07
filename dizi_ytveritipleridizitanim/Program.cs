internal class Program
{
    private static void Main(string[] args)
    {
        //string
        //double
        //char veri tiplerinde dizileri kullanalım

        string [] isimler ={"Akif","Tuğçe","Ela","Murat","Hülya"};

        for (int i=0; i<isimler.Length; i++)
        {
            Console.WriteLine(isimler[i]);
        }

        double [] ondaliklisayi={10.2,5.3,2.7};

        for (int i=0; i<ondaliklisayi.Length;i++)
        {
            Console.WriteLine(ondaliklisayi[i]);
        }

        char [] karakter ={'a','b','c','d'};

        for (int i = 0; i < karakter.Length; i++)
        {
            Console.WriteLine(karakter[i]);
        }
    }
}