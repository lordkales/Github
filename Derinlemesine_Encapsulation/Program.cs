internal class Program
{
    private static void Main(string[] args)
    {
        // Nesnelerimizdeki field'ların kontrollü bir şekilde dışa açılmasıdır.
        // Nesnelerimizi başkalarının yanlış kullanımlarından korumak için kontrolsülz değişime kapatmak

       example a= new example();
       a.setwallet(5);
       Console.WriteLine(a.getwallet());

       example2 b = new example2();
       b.Wallet2=7;
       Console.WriteLine(b.Wallet2);
    }
    // ****************METOT İLE ENCAPSULATION************
   public class example
   {
    private int wallet;

    public int getwallet()
    {
        return this.wallet;
    }
    public void setwallet(int value)
    {
    this.wallet=value;
    }
   }

   // *************** PROPERTY İLE ENCAPSULATION ****************
    public class example2
    {
        private int wallet2;
        
        public int Wallet2
        {
        get { return wallet2; }
        set { wallet2 = value; }
        }
    }
   
}