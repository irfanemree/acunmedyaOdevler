using CM19OOPodev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM19OOPodev.Classes
{
    class Porsche : Araba, IHavadaUcar
    {
        public void havadaUcar(string marka)
        {
            Console.WriteLine(marka + " havada uçuyor.");
        }
    }
}
