//Değişkenin sol kısmı ile sağ kısmı aynı türde olmak zorunda
Console.WriteLine("*** Int >>> Byte ***");

int a = 5;
byte b = (byte)5;
Console.WriteLine(b.GetType());
Console.WriteLine(a+b);


Console.WriteLine("*** String >>> Int ***");
string c ="9";
int d = Convert.ToInt32(c);
Console.WriteLine(d);

string e = "1";
string f = "2";
int g = int.Parse(e);
int h = int.Parse(f);

Console.WriteLine(g+h);

Console.WriteLine("*** Int >>> String ***");

int a1 = 5;
string b1 = a1.ToString();
Console.WriteLine(b1);

Console.WriteLine("*** Double >>> Int ***");
double a2 = 5.22;
int b3=Convert.ToInt32(a2);
Console.WriteLine(b3);
Console.WriteLine(b3.GetType());

Console.WriteLine("*** Kullanıcıdan Alınan String Değer >>> Int Dönüştür ***");

Console.WriteLine("YAŞINIZ: ");
string kullanici_yas = Console.ReadLine();
int kullanici_yas1 = Convert.ToInt32(kullanici_yas);
Console.WriteLine(kullanici_yas1);

//Yaş Ortalamasını Hesaplayan Program Denemem

Console.WriteLine("** İTİNAYLA NOT ORTALAMASI HESAPLANIR");
Console.WriteLine("3 SINAV NOTUNUZU YAZINIZ; ");

string sinav1 = Console.ReadLine();
int sinav12=Convert.ToInt32(sinav1);
string sinav2= Console.ReadLine();
int sinav21=Convert.ToInt32(sinav2);
string sinav3=Console.ReadLine();
int sinav31=Convert.ToInt32(sinav3);

Console.WriteLine("Ortalamanız: "+(sinav12+sinav21+sinav31)/3);

