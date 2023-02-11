internal class Program
{
    private static void Main(string[] args)
    {
        IMusteri musteri= new musteri();
        musteri.ekle();
        musteri.getir();
        musteri.guncelle();
        musteri.sil();
        
    }
}
public interface IMusteri
{
    void ekle();
    void sil();
    void guncelle();
    void getir();
}
public class musteri : IMusteri
{
    public void ekle()
    {
        Console.WriteLine("Müşteri Eklendi");
    }

    public void getir()
    {
       Console.WriteLine("Müşteri getirildi");
    }

    public void guncelle()
    {
        Console.WriteLine("Müşteri güncellendi");
    }

    public void sil()
    {
       Console.WriteLine("Müşteri silindi");
    }
}