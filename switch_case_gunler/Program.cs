internal class Program
{
    private static void Main(string[] args)
    {
        //Klavyeden girilen sayının hangi güne ait olduğunu bulan program.

        Console.WriteLine("Haftanın Kaçıncı Gününü Öğrenmek İstersen Yaz");
        string gun=Console.ReadLine();

        switch (gun)
        {
            case "1":Console.WriteLine("Pazartesi");
            break;
            case "2":Console.WriteLine("Salı");
            break;
            case "3":Console.WriteLine("Çarşamba");
            break;
            case "4":Console.WriteLine("Perşembe");
            break;
            case "5":Console.WriteLine("Cuma");
            break;
            case "6":Console.WriteLine("Cumartesi");
            break;
            case "7":Console.WriteLine("Pazar");
            break;

            default:Console.WriteLine("HAFTADA 7 GÜN VAR, LÜTFEN TEKRAR DENE");
            break;
        }

        //Klavyeden girilen sayının hangi aya ait olduğunu gösteren program kodları
        Console.WriteLine("Kaçıncı Ayı Öğrenmek İstersen Yaz");
        string ay = Console.ReadLine();

        switch(ay)
        {
            case "1":Console.WriteLine("OCAK");
            break;
            case "2":Console.WriteLine("ŞUBAT");
            break;
            case "3":Console.WriteLine("MART");
            break;
            case "4":Console.WriteLine("NİSAN");
            break;
            case "5":Console.WriteLine("MAYIS");
            break;
            case "6":Console.WriteLine("HAZİRAN");
            break;
            case "7":Console.WriteLine("TEMMUZ");
            break;
            case "8":Console.WriteLine("AĞUSTOS");
            break;
            case "9":Console.WriteLine("EYLÜL");
            break;
            case "10":Console.WriteLine("EKİM");
            break;
            case "11":Console.WriteLine("KASIM");
            break;
            case "12":Console.WriteLine("ARALIK");
            break;

            default:
            Console.WriteLine("1 YILDA 12 AY VAR, TEKRAR DENE!");
            break;
        }

        //Kullanıcının girdiği iki sayı ve yapılacak işlem türleri (toplama=1, çıkarma=2, çarpma=3, bölme=4) gösterilen ve  seçilen işlemi yapan C# programını  switch-case ile yazın.

        Console.WriteLine("YAPACAĞINIZ İŞLEMİ GİRDİKTEN SONRA 2 SAYI GİRİN");
        Console.WriteLine("1. Toplama");
        Console.WriteLine("2. Çıkarma");
        Console.WriteLine("3. Çarpma");
        Console.WriteLine("4. Bölme");

        string islem=Console.ReadLine();
        Console.WriteLine("1. Sayıyı Girin: ");
        int sayi1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2. Sayıyı Girin: ");
        int sayi2=Convert.ToInt32(Console.ReadLine());

        switch(islem)
        {
            case "1":
            Console.WriteLine(sayi1+sayi2);
            break;

            case "2":
            Console.WriteLine(sayi1-sayi2);
            break;

            case "3":
            Console.WriteLine(sayi1*sayi2);
            break;

            case "4":
            Console.WriteLine(sayi1/sayi2);
            break;

            default:
            Console.WriteLine("Geçersin Seçim");
            break;
        }

    }
}