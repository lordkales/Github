internal class Program
{
    private static void Main(string[] args)
    {
        string [] renkler = new string [5];
        string [] hayvanlar = {"ayı","aslan","köpek"};
        Console.WriteLine(hayvanlar);

        int [] dizi;
        dizi = new int[5];

        //DİZİLERE DEĞER ATAMA

        renkler [0]="mavi";
        dizi [3]=10;

        Console.WriteLine(hayvanlar[0]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        //DÖNGÜLERLE DİZİ KULLANIMI
        //Klavyeden girilen n tane sayının ortalamasını alan program

        Console.Write("Lütfen dizinin eleman sayısını giriniz:");
        int diziuzunlugu = int.Parse(Console.ReadLine());
        int[] sayidizisi = new int [diziuzunlugu];

        for (int i = 0; i < diziuzunlugu; i++)
        {
         Console.Write("Lütfen {0}. sayıyı giriniz: ",i+1);
sayidizisi[i]=int.Parse(Console.ReadLine());
        }
        int toplam =0;
        foreach (var sayi in sayidizisi)
        toplam+=sayi;

        Console.WriteLine("Ortalama : "+    toplam/diziuzunlugu);
    }
}