internal class Program
{
    private static void Main(string[] args)
    {
        kedi k = new kedi("Osman");
        k.konus();

        kopek kpk=new kopek("Karabaş");
        kpk.konus();

    }
}
public class hayvan
{
    private string isim { get; set; }

    public hayvan(string isim)
    {
        this.isim=isim;
    }

    public string Isim 
    { 
        get
        {
        return this.isim;
        }
        set
        {
        this.isim=value;
        } 
    }

    public virtual void konus()
    {
        Console.WriteLine("Hayvan Konuşuyor");
    }
}

public class kedi : hayvan
{
    public kedi (string isim) : base(isim)
    {
    
    }
    public override void konus()
    {
        Console.WriteLine(Isim+" Miyav");
    }
}
public class kopek : hayvan
{
    public kopek (string isim) : base(isim)
    {
    
    }
    public override void konus()
    {
        Console.WriteLine(Isim+" Hav Hav!");
    }
}