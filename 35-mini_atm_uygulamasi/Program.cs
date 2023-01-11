internal class Program
{
    private static void Main(string[] args)
    {
        //Kullanıcıya hangi işlemi yapacağı sor
        //1 Bakiye Görüntüleme
        //2 Para Çekme
        //3 Para Yatırma
        //4 Çıkış Yap

        int bakiye = 1000;

        Console.WriteLine("ATM'ye hoşgeldiniz");
        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
        Console.WriteLine("1 Bakiye Görüntüleme");
        Console.WriteLine("2 Para Çekme");
        Console.WriteLine("3 Para Yatırma");
        Console.WriteLine("4 Çıkış Yap");

        string secim = Console.ReadLine();
        if (secim=="1")
        {
            Console.WriteLine("Bakiyeniz: "+bakiye);
        }
        else if(secim=="2")
        {
            Console.WriteLine("Çekmek istediğiniz tutarı girin: ");
            int paracek=Convert.ToInt32(Console.ReadLine());
            if (paracek<=bakiye)
            {
                Console.WriteLine("Kalan Tutar: "+(bakiye-paracek));
            }
            else
            {
                Console.WriteLine("Bakiyenizden fazla para çekemezsiniz");
            }
            
        }
        else if (secim=="3")
        {
            Console.WriteLine("Yatırılacak Tutarı Girin: ");
            int parayatir=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hesap Bakiyeniz: "+(parayatir+bakiye));
        }
        else if (secim =="4")
        {
            Console.WriteLine("ATM'den çıkış yapıldı, iyi günler");
        }
        else 
        {
            Console.WriteLine("Lütfen Bir Seçim Yapın");
        }
    }
}