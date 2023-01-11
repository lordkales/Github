internal class Program
{
    private static void Main(string[] args)
    {
        //Kullanıcıdan girdiği iki sayı ve yapılacak işlem türü (toplama, çıkarma, çarpma, bölme) 
        //seçildiğinde sonucu hesaplayarak ekranda gösteren programı yazalım.
        Console.WriteLine("2 SAYI GİRİN!");

        Console.WriteLine("1. Sayınız: ");
        int sayi1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("2. Sayınız: ");
        int sayi2=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("YACAPAĞINIZ İŞLEMİ SEÇİN");
        Console.WriteLine("1. Toplama");
        Console.WriteLine("2. Çıkarma");
        Console.WriteLine("3. Bölme");
        Console.WriteLine("4. Çarpma");
        string secim =Console.ReadLine();

        if(secim=="1")
        {
            Console.WriteLine(sayi1+" + " +sayi2+" = "+(sayi1+sayi2));
        }
        else if (secim=="2")
        {
            Console.WriteLine(sayi1+" - " +sayi2+" = "+(sayi1-sayi2));
        }
        else if (secim=="3")
        {
            Console.WriteLine(sayi1+" / " +sayi2+" = "+(sayi1/sayi2));
        }
        else if (secim=="4")
        {
            Console.WriteLine(sayi1+" x " +sayi2+" = "+(sayi1*sayi2));
        }
        else
        {
        Console.WriteLine("Yanlış bir tuşa bastınız.");
        }
        
    }
}