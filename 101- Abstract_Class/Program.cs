internal class Program
{
    private static void Main(string[] args)
    {
        altsinif altsinif= new altsinif();
        altsinif.metot1();
        altsinif.metot2();
    }
}
public abstract class temelsinif
{
public void metot1()
{
    Console.WriteLine("metot1 çalıştı"); // metodun bodysi
}
public abstract void metot2(); // metodun imzası
}
public class altsinif : temelsinif
{
    public override void metot2()
    {
        Console.WriteLine("metot2 çalıştı");
    }
}