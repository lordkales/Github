internal class Program
{
    private static void Main(string[] args)
    {
       //Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 TL’den fazla ise
       //2.üründen %25 indirim yaparak ödenecek tutarı gösteren uygulamayı yapalım.

       Console.WriteLine("İNDİRİMLİ FİYAT HESAPLAMA");

       Console.WriteLine("1. Ürün Fiyatını Giriniz: ");
       int urun1=Convert.ToInt32(Console.ReadLine());

       Console.WriteLine("2. Ürün Fiyatını Giriniz: ");
       int urun2=Convert.ToInt32(Console.ReadLine());
       double toplam=urun1+urun2;

        if(toplam>=200)
        {
            double indirimli=urun1+(urun2-(urun2*0.25));
            Console.WriteLine("SEPET TUTARINIZ: "+indirimli+" TL");
        }
        else 
        {
            Console.WriteLine("SEPET TUTARINIZ: "+toplam+" TL");
        }
    }
}