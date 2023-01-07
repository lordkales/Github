internal class Program
{
    private static void Main(string[] args)
    {
       int [] sayilar = new int [4];
       sayilar [0]=10;
       sayilar [1]=20;
       sayilar [2]=30;
       sayilar[3]=40;

       for (int i = 0; i < sayilar.Length; i++)
       {
        Console.WriteLine(sayilar[i]);
       }

       string [] aile = {"Baba: Akif Yaşı: ","Anne: Tuğçe Yaşı: ","Yavrum: Ela Yaşı: "};
       int [] yaslari = {29,27,3};

       for (int i = 0; i < aile.Length; i++)
       {
        Console.WriteLine(aile[i]+yaslari[i]);
       }
    }
}