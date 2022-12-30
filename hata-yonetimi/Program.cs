try
{
Console.WriteLine("Sayı Girin: ");
int sayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sayı Budur: " + sayi);
}
catch(Exception ex)
{
Console.WriteLine(ex.Message.ToString());
}
finally
{
    Console.WriteLine("Tamamlandı");
}

//Null Değer Hatasını İnceleyelim;

Console.WriteLine("Null Değer Hatasını İnceleyelim;");

try
{
    //int a = int.Parse("ali");
    int a = int.Parse("-20000000000");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş Değer Girdiniz: "+ ex);
}
catch(FormatException ex)
{
    Console.WriteLine("Format Hatası");
}
catch(OverflowException ex)
{
    Console.WriteLine("Küçük yada büyük değer girdiniz.");
}
finally{
    Console.WriteLine("işlem tamamlandı");
}
