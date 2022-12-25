int sayi1 = 1;
string rakam ="2";
string yanyanayazdir = rakam + sayi1.ToString();

Console.WriteLine(yanyanayazdir); //çıktı 21

int toplam=sayi1+Convert.ToInt32(rakam);
Console.WriteLine(toplam); //çıktı 3

string datetime=DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime);

string datetime1=DateTime.Now.ToString("HH:mm");
Console.WriteLine(datetime1);
