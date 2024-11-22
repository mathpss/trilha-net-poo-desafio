using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia (numero: "995959595", modelo: "Modelo1", imei: "111111", memoria: 128);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "987878787", modelo: "Modelo2", imei: "222222", memoria: 32);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Tinder");

// nokia.Modelo //<- testando se realmente a propriedade está protegida 
