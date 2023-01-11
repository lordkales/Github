//Klavyeden girilen sayının tek mi, çift mi olduğunu gösteren C# programını yazalım.
Console.WriteLine("YAZ BAKALIM TEK Mİ ÇİFT Mİ");
int sayi=Convert.ToInt32(Console.ReadLine());
if (sayi%2==0)
{
    Console.WriteLine("BULDUM!! SAYIN ÇİFT..!! YESSS.. DAHA ZOR DAHA??");
}
else{
    Console.WriteLine("AKLINDAN TUTTUĞUN SAYIIIII... TEK! BUNLARLA ISINMIYORUM BİLE..");
}