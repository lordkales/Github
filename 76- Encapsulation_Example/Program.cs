internal class Program
{
    private static void Main(string[] args)
    {
        // Personelin TC kimlik numarasını al;
        // SET şartları: TC No'yu 11 krkter al, tüm krkterler sysal
        // GET şartı: İlk 5 karakteri göster
        Personel p1 = new Personel();
        p1.TCNO=Console.ReadLine();
        Console.WriteLine(p1.TCNO);
    }
    class Personel
    {
        private string tcno;

        public string TCNO 
        { 
            get
            {
                    return tcno.Substring(0,5);
            
            } 
            set
            {
                bool kontrol = true;
                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        
                        if (char.IsNumber(value[i])==false)
                        {
                            kontrol=false;
                            break;
                        }
                        else
                        {
                            //Döngü devam etsin bişey yapma
                        }
                    }
                    if (kontrol==false)
                    {
                        Console.WriteLine("HATALI TC GİRDİNİZ");
                    }
                    else
                    {
                        tcno=value; // Girilen değer 11 karakter ve tamamı sayı ise değişkene ata;
                    } 
                }
                else
                {
                    Console.WriteLine("LÜTFEN 11 HANELİ TC GİRİN");
                }
            }
        }
    }
}