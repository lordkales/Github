internal class Program
{
    private static void Main(string[] args)
    {
        // Çalışan, Yazılımcı, Yönetici sınıfları olacak
        // Yazılımcı ve Yönetici sınıfı Çalışan sınıfını miras alacak
        // Daha sonra Main metodundan kullanılacak
        

        while (true)
        {
        Console.WriteLine("Çalışan Uygulamasına Hoşgeldiniz..");
        Console.WriteLine("1- Yazılımcı İşlemleri");
        Console.WriteLine("2- Yönetici İşlemleri");
        Console.WriteLine("Çıkış için 'Q' basın");

        string secilenislem=Console.ReadLine();
        
          if (secilenislem=="q")
        {
            Console.WriteLine("Programdan çıkılıyor.");
            break;
        }  
        else if (secilenislem=="1")
        {
            yazilimci yazılımcı = new yazilimci(1,"Burak Akif","BOYLU","C#");
            

            while (true)
            {
            Console.WriteLine("Yazılımcı işlemi seçiniz: ");
            Console.WriteLine("1- Format At");
            Console.WriteLine("2- Yazılımcı Bilgilerini Göster");
            Console.WriteLine("Çıkış için 'Q' basınız");

            string yazilimciislem = Console.ReadLine();
                if (yazilimciislem=="1")
                {
                    Console.Write("İşletim Sistemi Giriniz: ");
                    string isletimsistemi = Console.ReadLine();
                    yazılımcı.formatat(isletimsistemi);

                }

                else if (yazilimciislem=="2")
                {
                    yazılımcı.bilgilerigoster();
                }

                else if (yazilimciislem=="q")
                {
                    Console.WriteLine("Yazılımcı İşlemlerinden çıkılıyor...");
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz!");
                }
            }
        }

        else if (secilenislem=="2")
        {
            yonetici yönetici = new yonetici(2,"Murat","BOYLU",5);
            

            while (true)
            {
            Console.WriteLine("Yönetici işlemi seçiniz: ");
            Console.WriteLine("1- Zam Yap");
            Console.WriteLine("2- Yöneticinin Bilgilerini Göster");
            Console.WriteLine("Çıkış için 'Q' basınız");
            
            string yoneticiislem=Console.ReadLine();

                if (yoneticiislem=="q")
                {
                    Console.WriteLine("Yönetici İşlemlerinden Çıkılıyor..");
                    break;
                }

                else if (yoneticiislem=="1")
                {
                    Console.Write("Zam Miktarını Giriniz:");
                    int zammiktari=Convert.ToInt32(Console.ReadLine());
                    yönetici.zamyap(zammiktari);
                    
                    Console.WriteLine(zammiktari+"TL Zam Yapıldı");
                }

                else if (yoneticiislem=="2")
                {
                    yönetici.bilgilerigoster();
                }

                else
                {
                    Console.WriteLine("Lütfen Gerçerli Bir İşlem Seçiniz!");
                }
            }   
        }
        else
        {
            Console.WriteLine("Lütfen Çalışan Uygulaması İçin Geçerli Bir İşlem Seçiniz!");
        }
        }
        
    }
    public class calisan
    {
        private int id;
        private string isim;
        private string soyisim;

        public calisan(int _id, string _isim, string _soyisim)
        {
            this.id=_id;
            this.isim=_isim;
            this.soyisim=_soyisim;
        }
        
        public int getID()
        {
            return this.id;
        }
        public void setID(int _id)
        {
            this.id=_id;
        }

        public string getisim()
        {
            return this.isim;
        }
        public void setisim(string _isim)
        {
            this.isim=_isim;
        }
        
        public string getsoyisim()
        {
            return this.soyisim;
        }
        public void setsoyisim(string _soyisim)
        {
            this.soyisim=_soyisim;
        }

        public void bilgilerigoster()
        {
            Console.WriteLine("Id: "+this.id);
            Console.WriteLine("İsim: "+this.isim);
            Console.WriteLine("Soyisim: "+this.soyisim);
        }
    }

    public class yazilimci : calisan
    {
        private string diller;
        public yazilimci(int _id, string _isim, string _soyisim, string _diller):base(_id,_isim,_soyisim) //Miras aldığım classın yapıcı metodunu temsil eder. yazılımcı sınıfından nesne türetildiği zaman yapıcı metod 3 parametre alacak, aldığı bu 3 parametreyi çalışan sınıfının yapıcı metoduna göndermek istiyorum.
        {
            this.diller=_diller;
        }
        public void formatat(string isletimsistemi)
        {
            Console.WriteLine(getisim()+" şuan "+isletimsistemi+" işletim sistemine format atıyor.");
        }
    } 
    public class yonetici : calisan
    {
        private int sorumlukisisayisi;
        public yonetici(int _id, string _isim, string _soyisim, int _sorumlukisisayisi) : base(_id,_isim,_soyisim)
        {
            this.sorumlukisisayisi=_sorumlukisisayisi;
        }
        
        public void zamyap(int zammiktari)
        {
            Console.WriteLine(getisim()+" "+zammiktari+" TL çalışanlara zam yapıyor");
        }
    }
}