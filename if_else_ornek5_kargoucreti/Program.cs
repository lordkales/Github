internal class Program
{
    private static void Main(string[] args)
    {
       //Bir mağazada alınan ürünün fiyatı 100 Tl ve üzerinde ise 5 Tl olan kargo ücreti 
       //alınmamaktadır. Ürünün fiyatı girildiğinde toplam ödenmesi gereken tutarı gösteren 
       //programı yazalım.

       Console.WriteLine("SEPET HESAPLAMA");
       Console.WriteLine("Lütfen Ürün Fiyatını Giriniz: ");
       int fiyat = Convert.ToInt32(Console.ReadLine());

       if(fiyat>=100)
       {
        Console.WriteLine("Ürün Fiyatı: "+fiyat+" TL");
        Console.WriteLine("Kargo Ücretsiz");
        Console.WriteLine("Toplam Fiyat: "+fiyat+" TL");
       }
       else
       {
        Console.WriteLine("Ürün Fiyatı: "+fiyat+" TL");
        Console.WriteLine("Kargo Ücreti: 5 TL");
        Console.WriteLine("Toplam Fiyat: "+ (fiyat+5));
       }
    }
}