internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Şekil uygulamasına hoşgeldiniz");
        while (true)
        {
            Console.WriteLine("İşlem seçiniz: ");
            Console.WriteLine("1- Dikdörtgen İşlemleri: ");
            Console.WriteLine("2- Üçgen İşlemleri");
            Console.WriteLine("3- Kare İşlemleri");
            Console.WriteLine("Q ya basarak çıkınız"); 

            string secim = Console.ReadLine();

            if (secim=="q")
            {
                break;
            }
            else if (secim=="1")
            {
                while (true)
                {
                Console.WriteLine("1- Alan Hesapla");
                Console.WriteLine("2- Dikdörtgen Bilgileri Göster");
                Console.WriteLine("3- Dikdörtgenden çıkış yap");

                string secimdikdortgen=Console.ReadLine();

                if (secimdikdortgen=="1")
                {
                    Console.WriteLine("Kısa Kenarı Giriniz: ");
                    int kisakenar=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Uzun Kenarı Giriniz: ");
                    int uzunkenar=Convert.ToInt32(Console.ReadLine());

                    dikdortgen dikdortgen = new dikdortgen("Dikdörtgen",kisakenar,uzunkenar);
                    dikdortgen.sekilhesapla();
                }
                else if (secimdikdortgen=="2")
                {
                    Console.WriteLine("Kısa Kenarı Giriniz: ");
                    int kisakenar=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Uzun Kenarı Giriniz: ");
                    int uzunkenar=Convert.ToInt32(Console.ReadLine());

                    dikdortgen dikdortgen = new dikdortgen("Dikdörtgen",kisakenar,uzunkenar);
                    dikdortgen.sekilbilgilerigosster();
                }
                else if (secimdikdortgen=="q")
                {
                    Console.WriteLine("Dikdörtgen İşlemlerinden Çıkılıyor");
                    break;
                }
                }
            }
            else if (secim=="2")
            {
                while (true)
                {
                Console.WriteLine("1- Üçgenin Alan Hesapla");
                Console.WriteLine("2- Üçgenin Bilgileri Göster");
                Console.WriteLine("3- Üçgenden çıkış yap");

                string secimucgen=Console.ReadLine();
                while (true)
                {
                    if (secimucgen=="1")
                    {
                        Console.WriteLine("Üçgenin Taban Alanını Giriniz: ");
                    }
                }
                }
            }
        }
    }
}
public class sekil // base class
{
    public string isim { get; set; }
    public sekil (string isim)
    {
        this.isim=isim;
    }

    public string getIsim()
    {
        return this.isim;
    }
    
    public virtual void sekilhesapla()
    {
        Console.WriteLine("Şeklin Alanı Hesaplanıyor");
    }
    public virtual void sekilbilgilerigosster()
    {
        Console.WriteLine(getIsim()+" nin bilgileri");
    }
}

public class dikdortgen : sekil
{
    public int kisakenar { get; set; }
    public int uzunkenar { get; set; }

    public  dikdortgen(string isim, int kisakenar, int uzunkenar) : base(isim)
    {
        this.kisakenar=kisakenar;
        this.uzunkenar=uzunkenar;
    }
    public override void sekilhesapla()
    {
        base.sekilhesapla();
        Console.WriteLine(getIsim()+"in alanı: "+(kisakenar*uzunkenar));
    }
    public override void sekilbilgilerigosster()
    {
        base.sekilbilgilerigosster();
        Console.WriteLine("Şeklin İsmi: "+getIsim());
        Console.WriteLine(getIsim()+"in kisa kenarı: "+this.kisakenar);
        Console.WriteLine(getIsim()+"nin uzun kenarı: "+this.uzunkenar);
    }
}

public class ucgen : sekil
{
    public int tabanalani { get; set; }
    public int yukseklik { get; set; }

    public ucgen (string isim, int tabanalani, int yukseklik) : base(isim)
    {
        this.tabanalani=tabanalani;
        this.yukseklik=yukseklik;
    }
    public override void sekilhesapla()
    {
        base.sekilhesapla();
        Console.WriteLine(getIsim()+"in Alanı: "+(tabanalani*yukseklik)/2);
    }
    public override void sekilbilgilerigosster()
    {
        base.sekilbilgilerigosster();
        Console.WriteLine("Şeklin İsmi: "+getIsim());
        Console.WriteLine(getIsim()+"in taban alanı: "+this.tabanalani);
        Console.WriteLine(getIsim()+"in yüksekliği: "+this.yukseklik);
    }
}
public class kare : sekil
{
    public int kenar { get; set; }

    public kare(string isim, int kenar): base (isim)
    {
        this.kenar=kenar;
    }
    public override void sekilhesapla()
    {
        base.sekilhesapla();
        Console.WriteLine(getIsim()+"nin alanı: "+(kenar*kenar));
    }
    public override void sekilbilgilerigosster()
    {
        base.sekilbilgilerigosster();
        Console.WriteLine("Şeklin İsmi: "+getIsim());
        Console.WriteLine(getIsim()+"in kenarı: "+this.kenar);
    }
}