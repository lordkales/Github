internal class Program
{
    private static void Main(string[] args)
    {
        // Personelin TC kimlik numarasını al;
        // SET şartları: TC No'yu 11 krkter al, tüm krkterler sysal
        // GET şartı: İlk 5 karakteri göster
        
        string tcyaz = Console.ReadLine();

        personel gelentc = new personel();
        gelentc.Tcno=tcyaz;
       
    }
public class personel
    {
        
        private string tcno;
        public string Tcno
        {
            get
            { 
                return tcno;
            }
            
            set 
            { 
                bool Kontrol=false;
                if (value.Length==11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayimi=char.IsNumber(value[i]);
                        if (sayimi)
                        {
                            // Birşey yapma
                        }
                        else
                        {
                            Kontrol=true;
                            break;
                        }
                    }
                    if (Kontrol)
                    {
                        Console.WriteLine("Lütfen TC No kontrol edin!");
                    }
                    else
                    {
                        tcno=value;
                    }
                    
                } 
                else
                {
                    Console.WriteLine("Girdiğiniz TC 11 karakter değil");  
                }
            }
        }
    }
}