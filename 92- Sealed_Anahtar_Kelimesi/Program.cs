internal class Program
{
    private static void Main(string[] args)
    {
        // Sealed anahtar kelimesi nedir?
        // Bu classı kimse alamaz, class mühürlenmiş olur.

        musteri musteri=new musteri();
        musteri.personel_id=1;
        musteri.personel_isim="burak akif";
        musteri.personel_maas=30000;
        musteri.personel_soyisim="Boylu";

        musteri.personelbilgileri();
    
    }
    public class musteri : personel
    {

    }
    sealed class personel // sealed erişim belirleyici sayesinde hiçbir yerden miras alınamaz.
    {
        public int personel_id { get; set; }
        public string personel_isim { get; set; }
        public string personel_soyisim { get; set; }
        public int personel_maas { get; set; }

        public void personelbilgileri()
        {
            Console.WriteLine(personel_id);
            Console.WriteLine(personel_isim);
            Console.WriteLine(personel_maas);
            Console.WriteLine(personel_soyisim);
        }
    }
}