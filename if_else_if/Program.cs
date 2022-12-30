internal class Program
{
    private static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;
    
        if (time<=18 && time >=8) 
        
        Console.WriteLine("İyi günler");
          
        else
        
            Console.WriteLine("İyi akşamlar");
        
        string sonuc = time<=18 ? "İyi günler" : "İyi akşamlar";
        Console.WriteLine(sonuc);
    }
}