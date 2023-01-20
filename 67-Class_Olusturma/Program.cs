internal class Program
{
    private static void Main(string[] args)
    {
    Araba arabaci=new Araba(4,"Renault","Gri");
    
    Console.WriteLine("Arabanın Kapı Sayısı: "+arabaci.kapisayisi);
    Console.WriteLine("Arabanın Modeli: "+arabaci.arabamodeli);
    Console.WriteLine("Arabanın Rengi: "+arabaci.arabarengi);

    arabaci.arabayikilitle();
    arabaci.motorucalistir();

    Console.WriteLine("Arabanın Modeli: " + arabaci.arabamodeli);
    Console.WriteLine("Arabanın Rengi: "+arabaci.arabarengi);
    Console.WriteLine("Arabanın Kapı Sayısı: "+arabaci.kapisayisi);
    }
}
public class Araba
{
    public int kapisayisi;
    public string arabamodeli;
    public string arabarengi;

    public Araba(int _kapisayisi, string _arabamodeli, string _arabarengi)
    {
        kapisayisi=_kapisayisi;
        arabamodeli=_arabamodeli;
        arabarengi=_arabarengi;
    }

    public void arabayikilitle()
    {
        Console.WriteLine("KAPILAR KİLİTLENDİ");
    }
    public void motorucalistir()
    {
        Console.WriteLine("Motor Çalıştı");
    }
}