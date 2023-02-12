internal class Program
{
    private static void Main(string[] args)
    {
        /* *** INTERFACE ***

        ocak ocak = new ocak();
        Console.WriteLine(ocak.gunsaati());

        subat subat = new subat();
        Console.WriteLine(subat.gunsaati());

        mart mart= new mart();
        Console.WriteLine(mart.gunsaati());*/

    ocak ocak = new ocak();
    Console.WriteLine("Ocak Gün Saati: "+ocak.gunsaayi());
    Console.WriteLine("Ocak Gün Sayısı: "+ocak.aykacceker());
    Console.WriteLine("Ocak Kaçıncı Ay: "+ocak.kacinciay());

    }
}

/* *** INTERFACE ***

public interface AY
{
    int kacgundenolusur();
    int yilinkacinciayi();
    int gunsaati();
}
public class ocak : AY
{
    public int gunsaati()
    {
        return 24;
    }

    public int kacgundenolusur()
    {
        return 30;
    }

    public int yilinkacinciayi()
    {
        return 1;
    }
}
public class subat : AY
{
    public int gunsaati()
    {
        return 24;
    }

    public int kacgundenolusur()
    {
       return 28;
    }

    public int yilinkacinciayi()
    {
       return 2;
    }
}
public class mart : AY
{
    public int gunsaati()
    {
        return 24;
    }

    public int kacgundenolusur()
    {
        return 31;
    }

    public int yilinkacinciayi()
    {
        return 3;
    }
}*/
public abstract class AY
{
    public int gunsaayi()
    {
        return 24;
    }
    public abstract int kacinciay();
    public abstract int aykacceker(); 
}
public class ocak : AY
{
    public override int aykacceker()
    {
        return 30;
    }

    public override int kacinciay()
    {
        return 1;
    }
}
public class subat : AY
{
    public override int aykacceker()
    {
       return 28;
    }

    public override int kacinciay()
    {
        return 2;
    }
}