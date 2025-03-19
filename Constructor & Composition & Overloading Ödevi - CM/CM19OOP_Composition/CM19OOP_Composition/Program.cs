using CM19OOP_Composition;

Marka marka = new Marka("BMW");
Kasa kasa = new Kasa("SUV"); // BMW X5 "sedan" değil hocam
Pencere pencere = new Pencere(4);
Kapi kapi = new Kapi(4);

Araba a1 = new Araba(marka, kasa, pencere, kapi);
ArabaSon a2 = new ArabaSon(a1, " X5 ", 2.000000);

a2.yazdir();