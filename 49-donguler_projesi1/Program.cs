internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.WriteLine("ÇARPIM TABLOSU");

        for (int ilksayi = 1; ilksayi <=10; ilksayi++)
        {
            for (int ikincisayi = 1; ikincisayi <=10; ikincisayi++)
            {
                Console.Write(ilksayi+ "x"+ikincisayi+" = "+(ilksayi*ikincisayi) );
            }
        }*/

        //Kullanıcı giriş sayfası uygulaması
        //Kullanıcı adı ve şifreyi doğru girerse tebrikler yazdır
        //yanlış girerse hak ver, 3 defa yanlış girerse 

        for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write(i * j + "\t");
    }
    Console.WriteLine();
}
    }
}