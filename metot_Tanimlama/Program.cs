internal class Program
{
    private static void Main(string[] args)
    {
       int a =2, b=3;
       int returntoplam=Toplam(a,b);
       Console.WriteLine(returntoplam);

       metotlar ornek = new metotlar();
       ornek.ekranayazdir(Convert.ToString(returntoplam));
    }

    static int Toplam(int sayi1, int sayi2)
    {
        return sayi1+sayi2;
    }
}

class metotlar
{
    public void ekranayazdir(string veri)
    {
        Console.WriteLine(veri);
    }
}