Console.WriteLine("ATAMA VE İŞLEMLİ ATAMA");
// Atama ve İşlemli Atama
int x = 5;
int y = 10;

y=y+2;

Console.WriteLine(y);

y+=3;
Console.WriteLine(y);
y/=5;
Console.WriteLine(y);

x*=3;
Console.WriteLine(x);

Console.WriteLine("MANTIKSAL OPERATÖRLER");
//Mantıksal Operatörler
bool evet = true;
bool hayir = false;

if(evet || hayir);
Console.WriteLine("Karar verdim ama söyleyemem");

if(evet&&hayir);
Console.WriteLine("kararsızım");

if(evet||!hayir);
Console.WriteLine("EVET");

if(hayir||!evet);
Console.WriteLine("HAYIR");

Console.WriteLine("İLİŞKİSEL OPERATÖRLER");
//İlişkisel Operatörler
// <, >, <=, >=, ==, !=
int a =10;
int b =5;
bool sonuc = a<b;

Console.WriteLine(sonuc);

sonuc = a>b;
Console.WriteLine(sonuc);

sonuc = a!=b;
Console.WriteLine(sonuc);

sonuc= a==b;
Console.WriteLine(sonuc);

Console.WriteLine("ARİTMETİK OPERATÖRLER");
// Aritmetik Operatörler
// (+, -, *, /, %, ++, --)
int sayi1 = 10;
int sayi2 = 5;
int sonuc1 = sayi1/sayi2;
Console.WriteLine(sonuc1);

sonuc1=sayi1*sayi2;
Console.WriteLine(sonuc1);

sonuc1 = sayi1++;
Console.WriteLine(sonuc1);

// % Mood Almak
int sonuc2=20%19;
Console.WriteLine(sonuc2);
