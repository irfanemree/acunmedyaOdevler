using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM19OOP_Composition
{
    public class Araba
    {
        public Marka marka;
        public Kasa kasa;
        public Pencere pencere;
        public Kapi kapi;

        public Araba (Marka marka, Kasa kasa, Pencere pencere, Kapi kapi)
        {
            this.marka = marka;
            this.kasa = kasa;
            this.pencere = pencere;
            this.kapi = kapi;
        }

       
    }
}
