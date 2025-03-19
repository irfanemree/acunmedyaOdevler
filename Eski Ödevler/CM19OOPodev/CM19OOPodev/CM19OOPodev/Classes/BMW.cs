using CM19OOPodev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM19OOPodev.Classes
{
    class BMW : Araba, IDenizdeYuzer, IHızlıGider, IHavadaUcar
    {
        public void denizdeYuzer(string marka)
        {
            Console.WriteLine(marka + " denizde yüzüyor.");
        }

        public void havadaUcar(string marka)
        {
            Console.WriteLine(marka+ " havada uçuyor.");
        }

        public void hızlıGider(string marka)
        {
            Console.WriteLine(marka + " hızlı gidiyor");
        }
    }
}
