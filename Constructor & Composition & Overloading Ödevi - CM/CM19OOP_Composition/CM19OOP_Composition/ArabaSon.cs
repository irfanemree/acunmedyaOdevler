using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM19OOP_Composition
{
    public class ArabaSon
    {
        public Araba araba;
        public string model;
        public double fiyat;

        public ArabaSon(Araba araba, string model, double fiyat)
        {
            this.araba = araba;
            this.model = model;
            this.fiyat = fiyat;
        }

        public void yazdir()
        {
            Console.WriteLine("Arabanın Markası: " + araba.marka.markasi + " Modeli: "+ model + " Kapı Sayısı: " + araba.kapi.kapiSayisi + " Pencere Sayısı: " + 
                araba.pencere.pencereSayisi + " Kasası: " + araba.kasa.kasaTipi + " Fiyatı: " +fiyat );
        }
    }
}
