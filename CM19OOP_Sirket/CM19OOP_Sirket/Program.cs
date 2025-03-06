using CM19OOP_Sirket.Classes;

GenelMudur gm = new GenelMudur();
Mudur m = new Mudur();
Programci pr = new Programci();
Stajyer st = new Stajyer();

double toplamMaas = 0;
toplamMaas = gm.maasinizNedir() + m.maasinizNedir() + pr.maasinizNedir() + st.maasinizNedir();
Console.WriteLine("Toplam Maaş : " + toplamMaas);