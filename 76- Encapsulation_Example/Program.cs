internal class Program
{
    private static void Main(string[] args)
    {
        // Personelin TC kimlik numarasını al;
        // SET şartları: TC No'yu 11 krkter al, tüm krkterler sysal
        // GET şartı: İlk 5 karakteri göster

        personel gelenpersonel = new personel();
        int tcyaz=Convert.ToInt32(Console.ReadLine());
        gelenpersonel.girilentc=tcyaz;

        Console.WriteLine(gelenpersonel.girilentc);
        
        
    }

    public class personel
    {
        private string kimlik;

        public string girilentc 
        { 
            get
            {
            return kimlik;
            }

            set
            {
                if (value.Length==11)
                {
                    
                }
                else
                {
                    Console.WriteLine("HATALI KİMLİK NO");
                }
            }
        
        
        }
    }
}