using DesafioPOO.Models;

Console.WriteLine("TESTE NOKIA:");
Smartphone NOKIA = new Nokia(numero:"012345", modelo:"Modelo 1", imei: "111111111", memoria: 64);
NOKIA.Ligar();
NOKIA.InstalarAplicativo("Whatsapp");

Console.WriteLine("-----------------------------------------------------------------");

Console.WriteLine("TESTE IPHONE:");
Smartphone IPHONE = new Iphone(numero:"678901", modelo:"Modelo 2", imei: "22222222", memoria: 128);
IPHONE.Ligar();
IPHONE.InstalarAplicativo("Telegram");