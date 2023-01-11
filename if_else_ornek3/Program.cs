internal class Program
{
    private static void Main(string[] args)
    {
        //Örnek 3: Belirlenen kullanıcı adı ve şifre doğru girildiğinde “Giriş Başarılı”, 
        //yanlış girildiğinde “Girdiğiniz kullanıcı adı veya şifre hatalı” mesajı veren Console uygulamasını yapalım.

        Console.WriteLine("*** KULLANICI BİLGİLERİNİZİ GİRİNİZ");
        Console.WriteLine("Kullanıcı Adınızı Giriniz: ");
        string kullaniciadi= Console.ReadLine();

        Console.WriteLine("Şifrenizi Giriniz: ");
        string sifre = Console.ReadLine();

        if(kullaniciadi=="Burak Akif Boylu" && sifre=="12345")
        {
        Console.WriteLine("GİRİŞ BAŞARILI");
        }
        else{
            Console.WriteLine("HATALI KULLANICI ADI YADA ŞİFRE GİRDİNİZ");
        }
    }
}