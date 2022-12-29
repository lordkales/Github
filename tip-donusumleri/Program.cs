//  Implicit Conversion (Bilinçsiz Dönüşüm)
//  Düşük kapasiteli değişkenin kendinden daha yüksek kapasiteli değişkene atanması
Console.WriteLine("*** Implicit Conversion ***");
byte a=5;
sbyte b=10;
short c=15;

int d=a+b+c;
Console.WriteLine("D: "+ d);

long h =d;
Console.WriteLine("h: "+ h);

float i=h;
Console.WriteLine("i: "+ i);

string e = "akif";
char f = 'f';
object g=e+f+d;

Console.WriteLine(g);


//  Explicit Conversion (Bilinçli Dönüşüm)
Console.WriteLine("***Explicit Conversion***");

int a1 =5;
byte c1 =(byte)a1;
Console.WriteLine("a1:" + c1);

int z = 100;
byte c2 = (byte)z;
Console.WriteLine("z: "+c2);

float z1 = 10.3f;
byte c3 =(byte)z1;
Console.WriteLine("z1: "+c3);

// *** ToString ***

Console.WriteLine("*** ToString ***");

int x3=10;
string y3 = x3.ToString();
Console.WriteLine("y3: "+y3);

string x4 = 10.6f.ToString();
Console.WriteLine(x4);

Console.WriteLine("Not Ortalaması Hesaplama Programı");
Console.WriteLine("1. Notunuzu Giriniz:");
string not1= Console.ReadLine();
int n1 = Convert.ToInt32(not1);

Console.WriteLine("2. Notunuzu Giriniz:");
string not2 = Console.ReadLine();
int n2=Convert.ToInt32(not2);

Console.WriteLine("3. Notunuzu Giriniz:");
string not3 = Console.ReadLine();
int n3=Convert.ToInt32(not3);

Console.WriteLine("Ortalamanız: "+ (n1+n2+n3)/3);