internal class Program
{
    private static void Main(string[] args)
    {
       
        /*for (int i = 1; i <= 10; i++)
        {
            if (i==5)
            {
                break; //döngüyü kırar, döngünün dışına atar
            }
            Console.WriteLine(i);
        }

        for (int j = 1; j <= 10; j++)
        {
            if (j==5)
            {
                continue; //döngüyü sadece şart sağlıyorsa kırar, sonra döngüye tekrar devam
            }
            Console.WriteLine(j);
        }*/

        //1-100000 arası sayıların ekrana yaz bir tuşa basınca çık

        for (int i = 1; i <=100000; i++)
        {
            if (Console.KeyAvailable==false)
            {
                Console.WriteLine(i);
            }
            else
            {
                break;
            }
            
        }
    }
}