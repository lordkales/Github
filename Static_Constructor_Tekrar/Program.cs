internal class Program
{
    private static void Main(string[] args)
    {
        new myclass();
        new myclass();
    }

    class myclass
    {
        public myclass()
        {
           // Bu sınıftan  nesne üretilirken ilk tetiklenecek olan metottur.  
           Console.WriteLine("Myclass Constructor tetiklenmiştir");
        }

        static myclass()
        {
        // Bu sınıftan ilk nesne üretilirken ilk tetiklenecek olan metottur. 
        // Üretilen ilk nesnenin dışında bir daha tetiklenmez
         Console.WriteLine("Myclass Static Constructor tetiklenmiştir");
         // Static const. ın tetiklenebilmesi için illa ilk nesne üretimi yapılmasına gerek yoktur. İlgili sınıf içerisinde herhangi bir static yapılanmanın da tetiklenmesi static cost. tetiklenmesini sağlayacaktır.
         
        }
        
        
    }
}