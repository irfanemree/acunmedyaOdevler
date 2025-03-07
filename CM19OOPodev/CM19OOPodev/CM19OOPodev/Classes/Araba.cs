using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM19OOPodev.Classes
{
    public class Araba
    {
        public string marka;
        public string vites;
        public string kasaTipi;

        public void ekranaYazdir()
        {
            Console.WriteLine("Arabanın Markası: " + marka + " , " + "Vites: " + vites + " , " + "Kasa Tipi: " + kasaTipi);
        }
        public void ekranaYazdir(string markasi, string vitesi, string kasa)
        {
            Console.WriteLine("Arabanın Markası: " + markasi + " , " + "Vites: " + vitesi + " , " + "Kasa Tipi: " + kasa);
        }
    }


}
