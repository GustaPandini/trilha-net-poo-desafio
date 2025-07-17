using DesafioPOO.Models;

// Realizado os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia(numero: "9999-9999", modelo: "Lumia", imei: "1234", memoria: 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Iphone iphone = new Iphone(numero: "1111-1111", modelo: "16 Pro Max", imei: "4321", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Pinterest");