internal class Program
{
    private static void Main(string[] args)
    {
        //Öğrencinin ögrencino, ad, soyad, vize1, vize2, final, okulismi adında private değişkenler
        //Yapıcı metot kullanarak değişkenlere değer atanacak
        //ogrencibilgilerigöster() metodu bilgileri gösterecek
        //ogrenciortalamasıbul() metodu olacak
        //okulgetir() metodu olacak

        //Seçime göre işlem yapılacak
        //1. Öğrenci bilgileri göster
        //2. Öğrenci ortalaması göster
        //3. Öğrencinin okulunu göster
        //4. Çıkış yap

        Console.WriteLine("1. Öğrenci Bilgilerini Göster");
        Console.WriteLine("2. Öğrenci Ortalamasını Göster");
        Console.WriteLine("3. Öğrenci Okul Adını Göster");
        Console.WriteLine("4. Çıkış Yap");
        
        ogrenci ogrenci1=new ogrenci(1081,50,40,70,"Burak Akif","BOYLU","Yazılım Uzmanlık Eğitim Kurumu");
        bool kontrol=true;
        while (kontrol)
        {
            Console.Write("Lütfen seçim yapın: ");
            int secim=Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
               case 1:
               ogrenci1.ogrencibilgilerigöster();
               break;

               case 2:
               double gelennot=ogrenci1.ogrenciortalamasıbul();
               Console.WriteLine("Not Ortalaması: " +gelennot);
               break;

               case 3:
               ogrenci1.okulgetir();
               break;

               case 4:
               Console.WriteLine("Çıkış Yapıldı");
               kontrol=false;
               break;

               default:
               Console.WriteLine("Hatalı Seçim Yaptınız, Lütfen Tekrar Deneyin!");
               break;
            } 
        }
        
    }
    public class ogrenci
    {
        private int ogrencino, vize1,vize2,final;
        private double ortalamanot;
        private string ad,soyad,okulismi;

        public ogrenci(int ogrencino_, int vize1_, int vize2_, int final_, string ad_, string soyad_, string okulismi_)
        {
            ogrencino=ogrencino_;
            vize1=vize1_;
            vize2=vize2_;
            final=final_;
            ad=ad_;
            soyad=soyad_;
            okulismi=okulismi_;
        }

        public void ogrencibilgilerigöster()
        {
            Console.WriteLine("Öğrencinin adı: "+ad);
            Console.WriteLine("Öğrencinin soyadı: "+soyad);
            Console.WriteLine("Öğrencinin adı: "+ogrencino);
        }
        public double ogrenciortalamasıbul()
        {
            ortalamanot=(vize1*0.20)+(vize2*0.20)+(final*0.60);
            return ortalamanot;
        }
        public void okulgetir()
        {
            Console.WriteLine("Okul ismi: "+okulismi);
        }
        
    }
}