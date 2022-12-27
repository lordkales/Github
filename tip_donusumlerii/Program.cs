// Implicit Conversion (Bilinçsiz Dönüşüm)

byte a = 5;
sbyte b =30;
short c = 10;

int d=a+b+c;
Console.WriteLine(d);

long h= d;
Console.WriteLine(h);

float i = h;
Console.WriteLine(i);

// Explicit Conversion (Bilinçli Dönüşüm)

Console.WriteLine("***** Explicit Conversion ***** ");

int x=4;
byte y=(byte)x;

Console.WriteLine(y);

int z=100;
byte t=(byte)z;

Console.WriteLine(t);

int u=5;
byte e =(byte)u;
Console.WriteLine(e);

// ToString Methodu 

Console.WriteLine("***** ToString Methodu *****");

int xx =5;
string yy =xx.ToString();
Console.WriteLine(yy);

// Sytem.Convert
Console.WriteLine("***** Sytem.Convert *****");

string s1="10", s2="20";
int sayi1, sayi2;
int toplam;

sayi1=Convert.ToInt32(s1);
sayi2=Convert.ToInt32(s2);

toplam=sayi1+sayi2;
Console.WriteLine(toplam);

// Parse

Console.WriteLine("***** Parse *****");
string metin1="10", metin2="20.23";
int rakam1;
double double1;

rakam1=Int32.Parse(metin1);
double1=Double.Parse(metin2);
Console.WriteLine("rakam1 :"+rakam1);
Console.WriteLine("double1 :"+double1);

