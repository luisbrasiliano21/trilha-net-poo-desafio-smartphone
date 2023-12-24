using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Feito

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"123456", modelo:"Nokia 30", imei: "546738", memoria: 120  );
nokia.Ligar();
nokia.InstalarAplicativo("\"Whatsapp\"");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"234567", modelo: "iphone 15", imei:"1111111111", memoria:180);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("\"Telegram\"");