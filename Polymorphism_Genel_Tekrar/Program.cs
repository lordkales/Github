internal class Program
{
    private static void Main(string[] args)
    {

        /*kedi k = new kedi("Osman");
        k.konus();

        kopek kpk=new kopek("Karabaş");
        kpk.konus();*/

        temizlikrobotu t = new temizlikrobotu("Temizlikçi");
        t.yap();

        yemekrobotu y = new yemekrobotu("Yemek ");
        y.yap();

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
public class robot
    {
        public string ad { get; set; }

        public robot (string ad)
        {
            this.ad=ad;
        }
        public string Ad 
        { 
            get
            {
                return ad;
            } 
            set
            {
                this.ad=value;
            } 
        }
        public virtual void yap()
        {
            Console.WriteLine(Ad+"Yapılıyor.");
        }
    }
    public class temizlikrobotu : robot
    {
        public temizlikrobotu(string ad) : base(ad)
        {

        }
       public override void yap()
        {
            Console.WriteLine(Ad+"Temizleniyor");
        }
       
    }
    public class yemekrobotu : robot
    {
        public yemekrobotu(string ad):base(ad)
        {

        }
        public override void yap()
        {
            Console.WriteLine(Ad+"Yapılıyor..");
        } 
    }