internal class Program
{
    private static void Main(string[] args)
    {
        // STATIC KULLANIMI
        // Eğer sınıf içindeki metot yada değişken statik ise direkt class ismi üzerinden erişebiliriz. Obje oluşturmamıza gerek yoktur.
       personel.PERSONEL();
       personel.TOPLA(1,2);
    
    }
    public class personel
    {
        public static void PERSONEL()
        {
            Console.WriteLine("Burak");
        }
        public static void TOPLA(int a, int b)
        {
            Console.WriteLine(a+b);
        }

    }
    
}