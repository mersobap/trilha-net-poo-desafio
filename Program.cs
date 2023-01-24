using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Criando um celular Nokia
Smartphone smart01 = new Nokia("9 1234-5678", "Nokia Z10", "1234567890", 64);

smart01.Ligar();
smart01.ReceberLigacao();
smart01.InstalarAplicativo("Facebook");

Console.WriteLine("-------------------------------------");
// Criando um celular iPhone
Smartphone smart02 = new Iphone("9 9876-5432", "iPhone X", "9876543210", 128);
smart02.Ligar();
smart02.ReceberLigacao();
smart02.InstalarAplicativo("Telegram");