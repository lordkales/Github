internal class Program
{
    private static void Main(string[] args)
    {
        // ATM uygulaması ile kullanıcıdan aldığımız değerler ile işlem yaptıralım
        // 1- Bakiye görüntüle
        // 2- Para çek
        // 3- Para yatır
        // 4- Çıkış yap
        // 1-2-3-4 değerleri dışındaysa hata ver

        Console.WriteLine("BOYLU BANKA'a Hoşgeldiniz!");
        Console.WriteLine("Lütfen İşleminizi Seçiniz");
        Console.WriteLine("1. Bakiye Görüntüleme");
        Console.WriteLine("2. Para Çekme");
        Console.WriteLine("3. Para Yatırma");
        Console.WriteLine("4. İptal");

        int bakiye = 1000;
        int secenek = Convert.ToInt32(Console.ReadLine());
        

        switch (secenek)
        {
            case 1:
            Console.WriteLine("Bakiyeniz: "+bakiye +" TL");
            break;
            

            case 2:
            Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
            int paracek = Convert.ToInt32(Console.ReadLine());
            if (paracek>bakiye)
            {
                Console.WriteLine("Bakiyeniz Yetersizdir, Lütfen Tekrar Deneyiniz");
            }
            else
            {
            Console.WriteLine("Para Çekme İşleminiz Tamamlandı");
            Console.WriteLine("Mevcut Bakiyeniz: "+(bakiye-paracek));
            }
            break;
            
            case 3:
            Console.WriteLine("Yatıracağınız Tutarı Giriniz: ");
            int parayatir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Para Yatırma İşleminiz Tamamlandı");
            Console.WriteLine("Mevcut Bakiyeniz: "+(bakiye+parayatir));
            break;

            case 4:
            Console.WriteLine("Bizi Tercih İçin Teşekkür Ederiz");
            Console.WriteLine("LÜTFEN KARTINIZI ALINIZ!");
            break;
            
            default:
            Console.WriteLine("HATALI GİRİŞ YAPTINIZ!!");
            break;
            
        }

    }
}