internal class Program
{
    private static void Main(string[] args)
    {
        //Bir üniversitede öğrencilerin ortalamaları 50 ve üzerinde ise dersten başarılı 
        //sayılmaktadırlar. Öğrencinin vize notu ortalamaya %40, final notu %60 etki ettiği 
        //bildiğine göre öğrencilerin ders başarı durumlarını hesaplayan programı yapalım.

        Console.WriteLine("*** ORTALAMA HESAPLAMA *** ");
        
        Console.WriteLine("Vize Notunuz: ");
        int vize=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Final Notunuz: ");
        int final=Convert.ToInt32(Console.ReadLine());

        int ortalama = (vize * 40 / 100)+(final * 60 / 100);

        if (ortalama>=50 && ortalama<=100)
        {
            Console.WriteLine("Ortalamanız: "+ ortalama+" GEÇTİNİZ");
        }
        else
        {
            Console.WriteLine("Ortalamanız: "+ ortalama+" KALDINIZ");
        }
    }
}