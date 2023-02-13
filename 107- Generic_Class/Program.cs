internal class Program
{
    private static void Main(string[] args)
    {
        Repository<musteri> repositorymusteri = new Repository<musteri>();
        repositorymusteri.Getir();
        musteri musteri = new musteri();
        musteri.id=1;
        musteri.ismi="Burak Akif";
        musteri.cinsiyet="erkek";
    
        repositorymusteri.ekle(new musteri());

        Repository<urun> repositoryurun = new Repository<urun>();
        repositoryurun.Getir();
        urun urun = new urun();
        urun.urunid=1;
        urun.urunismi="Ram";
        urun.urunfiyati=300;
        repositoryurun.ekle(urun);
    }
}
public class musteri
{
    public int id { get; set; }
    public string ismi { get; set; }
    public string soyisim { get; set; }
    public string cinsiyet { get; set; }
    public DateTime dogumtarihi { get; set; }
    public string email { get; set; }

}
public class urun
{
public int urunid { get; set; }
public string urunismi { get; set; }
public double urunfiyati { get; set; }

}
public class Repository<T>
{
    public List <T> Getir()
    {
        return null;
    }
    public void ekle(T data)
    {

    }
}