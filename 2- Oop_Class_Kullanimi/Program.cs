internal class Program
{
    private static void Main(string[] args)
    {
        // FİELD NEDİR?
        // Nesne içerisinde veri depoladığımız alanlardır.
        // Sadece Class içerisindeki değişkenlerdir.
        // Herhangi bir türden olabilir.
        // Class dışında tanımlanan değişkenler field değildir.
        myclass m1 = new myclass(); // (******* NESNE OLUŞTURULDU ******)
        // m1.a=5; (***** NESNE İÇİNDEKİ A DEĞİŞKENİNE DEĞER ATANDI *****)
        // Fieldlar türüne özgü varsayılan değer alırlar (int=0 bool=false, char=/0)


        // PROPERTY NEDİR?
        // Nesne içerisinde özellik sağlar
        // Property özünde metottur. Yani algoritmik kodlarımızı inşa ettiğimiz metot.
        // Metotta parantez var, Property'de parantez yok.
        // Nesne içindeki field'ın dışarıya açılmasını ve kontrollü bir şekilde değer almasını sağlar
        

        // ENCAPSULATION NEDİR? ( KAPSÜLLEME )
        // Nesne içindeki fielddaki verilerin dışarıya kontrollü şekilde açılması ve kontrollü bir şekilde veri almasıdır.
        
      
    }
    
}
class myclass
{
    public string a;
}