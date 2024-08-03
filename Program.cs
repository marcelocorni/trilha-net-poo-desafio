using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Testes com Nokia e Iphone\n");
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Smartphone iphone = new Iphone("987654321", "iPhone 12", "987654321", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
