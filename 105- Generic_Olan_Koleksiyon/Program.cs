using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        /*List<int> rakamlar = new List<int>();
        rakamlar.Add(0);
        rakamlar.Add(1);
        rakamlar.Add(2);
        rakamlar.Add(3);
        rakamlar.Add(4);
        rakamlar.Add(5);
        rakamlar.Add(6);
        rakamlar.Add(7);
        rakamlar.Add(8);
        rakamlar.Add(9);

        foreach (int rakam in rakamlar)
        {
            Console.WriteLine(rakam);
        }*/

        List<Musteri> musteriler = new List<Musteri>();
        musteriler.Add(new Musteri(1,"Burak Akif","BOYLU","ornek@123.com"));
        musteriler.Add(new Musteri(2,"Feyza","BOYLU","deneme2@123.com"));
        musteriler.Add(new Musteri(3,"Ferhat Fatih","BOYLU","deneme3@123.com"));

        bool kontrol=musteriler.Contains(new Musteri(1,"Burak Akif","BOYLU","ornek@123.com"));
       

        /*musteriler.Clear();*/
        musteriler.RemoveAt(0);

        foreach (Musteri musteri in musteriler)
        {
            Console.WriteLine(musteri);
        }
    }
}
public class Musteri
{
    public int id { get; set; }
    public string isim { get; set; }
    public string soyisim{ get; set; }
    public string email { get; set; }

    public Musteri(int id, string isim, string soyisim,string email)
    {
        this.id=id;
        this.isim=isim;
        this.soyisim=soyisim;
        this.email=email;
    }

    public override string ToString()
    {
        return "id: "+this.id+" isim: "+this.isim+" soyisim: "+this.soyisim+" email: "+this.email;
    }
}