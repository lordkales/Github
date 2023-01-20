internal class Program
{
    private static void Main(string[] args)
    {
        // Rekürsif - Öz Yineleme (Kendi kendini tekrarlayabilen)
        // Kendi içinde kendisini çağırabilen/tetikleyen fonksiyonlardır
        // Özyinelemeli/Tekrarlamalı fonksiyon olarak da adlandırılır
        // Özellik, yapı vs değil "Fonksiyonun kullanım yaklaşımıdır"
        // Öngörülemeyen, derinliği tahmin edilemeyen, sonu bilinmeyen durumlarda döngüler yerine
        // tercih edilebilir.
    
        X();
    }
    static void rek()
    {
        /*for (int i = 1; i < 10; i++)
        {
            Console.WriteLine("Hello World");
            while (true)
            {
                rek();
            }
        }*/
    }
    static void X (int a =1)
    {
        Console.WriteLine("Merhaba");
        if (a<3)
        {
            X(++a);
        }
        Console.WriteLine("Dünya");
    }

}