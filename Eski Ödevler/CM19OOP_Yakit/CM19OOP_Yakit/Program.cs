using CM19OOP_Yakit.Classes;

BMW b = new BMW();
Mercedes m = new Mercedes();
Porsche p = new Porsche();
double toplamYakit = 0;
toplamYakit = b.yakitinizNedir() + m.yakitinizNedir() + p.yakitinizNedir();
Console.WriteLine("Toplam Yakit : " + toplamYakit);