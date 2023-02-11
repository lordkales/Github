internal class Program
{
    private static void Main(string[] args)
    {
        // Intercafe'imizi implament eden classlarımızdan oluşturduğumuz örneği INTERFACE karşılayabilir
        
        mustericontroller mustericontroller = new mustericontroller();
        mustericontroller.musteriekle(new mysql());
        mustericontroller.musteriekle(new sqlserver());
    }
}
public interface IMusteri
{
    void ekle();
    void sil();
    void guncelle();
}
public class sqlserver : IMusteri
{
    public void ekle()
    {
        Console.WriteLine("Sql Server ekledi");
    }

    public void guncelle()
    {
        Console.WriteLine("Sql Server güncelledi");
    }

    public void sil()
    {
        Console.WriteLine("Sql Server sildi");
    }
}
public class mysql : IMusteri
{
    public void ekle()
    {
        Console.WriteLine("Mysql ekledi");
    }

    public void guncelle()
    {
        Console.WriteLine("Mysql güncelledi");
    }

    public void sil()
    {
        Console.WriteLine("Mysql sildi");
    }
}
public class mustericontroller
{
    public void musteriekle(IMusteri veritabani)
    {
        veritabani.ekle();
    }

}
