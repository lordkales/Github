using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
       /*string gir = Console.ReadLine();
       gunler gun;
       if (gir=="2")
       {
        gun=gunler.çarşamba;
        Console.WriteLine("Çarşamba");
       }
       else if (gir=="0")
       {
        gun=gunler.pazartesi;
        Console.WriteLine("Pazartesi");
       }*/
    musteri musteri= new musteri(1,"Burak Akif","BOYLU","Erkek","deneme@123.com");
    MusteriDurum durum= musteri.musteriekle(musteri);
    if(durum==MusteriDurum.kayıtbaşarılı)
    {
        Console.WriteLine("Başarılı Eklendi");
    }
    }
}
/*public enum gunler
{
    pazartesi,salı,çarşamba,perşembe,cuma,cumartesi,pazar
}*/
public class musteri
 {
    public int id { get; set; }
    public string  isim { get; set; }
    public string soyisim { get; set; }
    public string Cinsiyet { get; set; }
    public string emailadresi { get; set; }

    public musteri(int id, string isim, string soyisim, string cinsiyet, string email)
    {
        this.id=id;
        this.isim=isim;
        this.soyisim=soyisim;
        this.Cinsiyet=cinsiyet;
        this.emailadresi=email;
    }

    public static ArrayList musteriler = new ArrayList();

    public MusteriDurum musteriekle(musteri M1);
    {
        musteriler.Add(M1);
        return MusteriDurum.kayıtbaşarılı;
       
    }
 }
 public enum MusteriDurum
 {
    kayıtbaşarılı,kayıtbaşarısız,bağlantıhatası
 }