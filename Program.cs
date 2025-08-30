using DesafioPOO.Models;

Nokia nokia = new Nokia("123", "Nokia Tijolão", "IMEI123456789", 16);
Console.WriteLine($"Nokia - Modelo: {nokia.Modelo}, IMEI: {nokia.IMEI}, Memória: {nokia.Memoria}GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("MSN");


Iphone iphone = new Iphone("456", "iPhone 8", "IMEI987654321", 32);
Console.WriteLine($"\niPhone - Modelo: {iphone.Modelo}, IMEI: {iphone.IMEI}, Memória: {iphone.Memoria}GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
