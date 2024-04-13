using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone smartphoneNokia = new Nokia("92422332", "T20", "LO2SJI4", 16);
smartphoneNokia.Ligar();
smartphoneNokia.InstalarAplicativo("Whatsapp");


Smartphone smartphoneIphone = new Iphone("924645632", "8s", "RO2FSI4", 32);
smartphoneIphone.Ligar();
smartphoneIphone.InstalarAplicativo("Instagram");
