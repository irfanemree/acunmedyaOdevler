using CM19OOPodev.Classes;

BMW a = new BMW();
a.marka = "BMW";
/*a.marka = "BMW";
a.vites = "Manuel";
a.kasaTipi = "Sedan";*/
a.denizdeYuzer(a.marka);
a.havadaUcar(a.marka);
a.hızlıGider(a.marka);


/*a.ekranaYazdir();*/

Mercedes m = new Mercedes();
m.marka = "Mercedes";
m.havadaUcar(m.marka);
m.denizdeYuzer(m.marka);
/*m.ekranaYazdir("Mercedes" , "Otomatik" , "Station Wagon");*/

Porsche au = new Porsche();
au.marka = "Porsche";
au.havadaUcar(au.marka);
/*au.ekranaYazdir("Audi", "Otomatik", "Hatchback");*/

Araba t = new Araba();
/*t.ekranaYazdir("Toyota", "Manuel", "Sedan");*/

Araba tog = new Araba();
/*tog.ekranaYazdir("TOGG", "Otomatik", "SUV");*/

Araba p = new Araba();
/*p.ekranaYazdir("Porsche", "Otomatik", "SUV");*/




