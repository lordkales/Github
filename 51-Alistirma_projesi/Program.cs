internal class Program
{
    private static void Main(string[] args)
    {
        // Kullanıcıdan bir sayı alacağız, 1'den o sayıya kadar toplayıp tekrar sayıya bölen kod
        Console.WriteLine("Lütfen sayı giriniz");
        int sayi=Convert.ToInt32(Console.ReadLine());
        int toplam=0;
    
        for (int i = 1; i <= sayi; i++)
        {
            toplam=toplam+i;
            
        }
        double ort=toplam/sayi;
            if (ort<50)
            {
                Console.WriteLine("Ortalamanız 50'den küçük: "+ort);
            }
            else
            {
                Console.WriteLine("Ortalama 50'den büyük: "+ort);
            }
        

    }
}