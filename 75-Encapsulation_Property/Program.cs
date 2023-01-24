internal class Program
{
    private static void Main(string[] args)
    {
        musteri mustericek = new musteri();
        mustericek.kilo_=75;
      
        Console.WriteLine(mustericek.kilo_);
    }
    public class musteri
    {
        private int kilo;

        public int kilo_
        { 
            get
            {
                return kilo;
            } 
            set
            {
                kilo=value;
            }
        }
    }
}