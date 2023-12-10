using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");

        Iphone iphone = new Iphone("987654321", "Iphone 11", "987654321", 64);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
