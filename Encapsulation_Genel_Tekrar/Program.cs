internal class Program
{
    private static void Main(string[] args)
    {
        /*Aşağıdaki Örnek Uygulamada Class’ ta kapsülleme kullanılarak dikdörtgenin alan hesabı yapılmıştır. Dikdörtgen kenarlarına negatif bir değer verilirse program hata verecek ve sonlanacak şekilde kodlanmıştır.
        
        Console.WriteLine("Dikdörtgenin Alanı Programına Hoşgeldiniz!");
        dikdortgen d1 = new dikdortgen();
        Console.Write("Lütfen Kısa Kenar Giriniz: ");
        d1.Kisakenar=Convert.ToInt32(Console.ReadLine());
        bool kontrol;
        while (true)
        {
            if (d1.Kisakenar<=0)
            {
                kontrol=false;
                Console.WriteLine("Lütfen pozitif bir tamsayı girin!");
                break;
            }
            else
            {
                Console.Write("Lütfen Uzun Kenar Giriniz: ");
                d1.Uzunkenar=Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    if (d1.Uzunkenar<=0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Dikdörtgeninizin Alanı: "+d1.Kisakenar*d1.Uzunkenar+" Cm");
                        break; 
                    }
                }
            }
            break;
        }*/
        /*Bu örneğimizde ise ulke isimli bir sınıf oluşturacağız. ulke sınıfının özelliklerini adı, başkenti, nüfusu ve para birimi olarak ayarlayacağız. Bu sınıfa ait metotta ise bu bilgilerin yazdırılmasını sağlayan Yazdir isimli bir metot oluşturacağız.
        
        ulke u1 = new ulke();
        Console.WriteLine("Ülke Adını Yazınız: ");
        u1.Adı=Console.ReadLine();
        Console.WriteLine("Ülke Başkentini Yazınız: ");
        u1.Baskent=Console.ReadLine();
        Console.WriteLine("Ülke Nüfusunu Yazınız: ");
        u1.Nufus=Console.ReadLine();
        Console.WriteLine("Ülke Para Birimini Yazınız: ");
        u1.Parabirimi=Console.ReadLine();
        u1.bilgileriyazdir();*/
        
        //Bu örneğimizde aynı zamanda Hata fırlatma ve Hata yakalama işleminin nasıl yapıldığıyla ilgili bir örnekte verelim. Örneğimizde “Makina” isimli bir sınıf oluşturacağız. Bu sınıfın “isi” isimli bir “properties” i bulunmakta. “isi” özelliğini kapsülleyeceğiz. Aynı zamanda ısı 0’dan küçük ise veya 100′ den büyükse hata fırlatarak ana programda bu hatanın yakalanmasının nasıl gerçekleştiğini göreceğiz.

        makina m1= new makina();
        try
        {
            m1.Isi=Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine(m1.Isi);
        }
    }
}
/*public class dikdortgen
{
    private int kisakenar;
    private int uzunkenar;
    public int Kisakenar 
    { 
    get
    {
    return kisakenar;
    }
    set
    {
    this.kisakenar=value;
    } 
    }
    public int Uzunkenar
    { 
        get 
        { 
            return uzunkenar; 
        } 
        set
        {
            if (value<0)
            {
                 Console.WriteLine("Lütfen Pozitif Bir Tam Sayı Girin!");
            } 
            else
            {
                this.uzunkenar=value;
            }
        } 
    }
}*/

/*public class ulke
{
    private string adı;
    private string baskent;
    private string nufus;
    private string parabirimi;

    public string Adı 
    { 
        get
        {
            return adı;
        } 
        set
        {
            this.adı=value;
        }
    }
    public string Baskent { get{return baskent;} set{this.baskent=value;} }
    public string Nufus { get{return nufus;} set{this.nufus=value;} }
    public string Parabirimi { get{return parabirimi;} set{this.parabirimi=value;} }

    public void bilgileriyazdir()
    {
        Console.WriteLine("Ülke Adı: "+ adı);
        Console.WriteLine("Ülke Başkenti: "+ baskent);
        Console.WriteLine("Ülke Nüfusu: "+ nufus);
        Console.WriteLine("Ülke Para Birimi: "+ parabirimi);
    }
}*/

public class makina
{
    private int isi;

    public int Isi 
    { 
        get
        {
            return isi;
        } 
        set
        {
            if (value<=100 && value>0)
            {
                Console.WriteLine("İdeal ısı seviyesi..");
                isi=value;
            }
            else if (value<0)
            {
                isi = 0;
                throw new Exception("Sıcaklık çok düşük, minimum seviyeye optimize ediliyor...");
            }  
            else
            {
                isi=100;
                throw new Exception("Sıcaklık çok yüksek, maksimum seviyeye optimize ediliyor...");
            }
        } 
    }
}