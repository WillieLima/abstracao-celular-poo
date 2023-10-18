using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456", "modelo 1", "1a1a1a1a", 64);
nokia.Ligar(12345678);
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("654321", "modelo 2", "a1a1a1a1a1", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

