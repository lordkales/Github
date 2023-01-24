internal class Program
{
    private static void Main(string[] args)
    {
        // seter geter metoları ile encapsulation
        // seter ile değer gönder
        // geter ile değeri çek 
        
        ogrenci ogrenci1 = new ogrenci();
        ogrenci1.setisim("Burak Akif");
        Console.WriteLine(ogrenci1.getisim());
    }
    public class ogrenci
    {
        private string isim;

        public void setisim(string isim_)
    {
        isim=isim_;
    }
    public string getisim()
    {
        return isim;
    }
    }
    


}