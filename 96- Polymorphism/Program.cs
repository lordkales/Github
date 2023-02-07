internal class Program
{
    private static void Main(string[] args)
    {
        /*hayvan hayvan = new hayvan("Hayvan");
        hayvan.konus();

        kedi kedi = new kedi("Osmiş");
        kedi.konus();

        kopek kopek = new kopek ("Maya");
        kopek.konus();*/

        hayvanlarikonustur(new hayvan("Hayvan"));
        hayvanlarikonustur(new kedi("Osman"));
        hayvanlarikonustur(new kopek("Maya"));
    }

    public static void hayvanlarikonustur(hayvan hayvan)
    {
        hayvan.konus();
    }
}
public class hayvan
{
    public string isim { get; set; }

    public hayvan(string isim)
    {
        this.isim=isim;
    }

    public string getIsim()
    {
        return this.isim;
    }
    public void setIsim(string isim)
    {
        this.isim=isim;
    }

    public virtual void konus()
    {
        Console.WriteLine(getIsim()+" Konuşuyor");
    }
}
public class kedi : hayvan
{
    public kedi(string isim) : base(isim)
    {
        
    }
    public override void konus()
    {
        Console.WriteLine(getIsim()+" Miyavvvv..");
    }
}
public class kopek: hayvan
{
    public kopek(string isim) : base(isim)
    {

    }
    public override void konus()
    {
        Console.WriteLine(getIsim()+" Hav Hav!");
    }
}