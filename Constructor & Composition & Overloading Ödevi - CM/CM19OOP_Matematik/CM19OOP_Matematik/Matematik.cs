using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM19OOP_Matematik
{
    public class Matematik
    {   
        public int Toplama(int sayi1 ,int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }

        public int Toplama(int sayi1, int sayi2, int sayi3)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2 + sayi3;
            return sonuc;
        }
        public int Carpma(int sayi1, int sayi2)
        {         
            return sayi1 * sayi2;
        }
        public int Carpma(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 * sayi2 * sayi3;
        }
        public double Toplama(double sayi1, double sayi2)
        {
            double sonuc = 0;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }

        public double Toplama(double sayi1, double sayi2, double sayi3)
        {
            double sonuc = 0;
            sonuc = sayi1 + sayi2 + sayi3;
            return sonuc;
        }
        public double Carpma(double sayi1, double sayi2)
        {
            return sayi1 * sayi2;
        }
        public double Carpma(double sayi1, double sayi2, double sayi3)
        {
            return sayi1 * sayi2 * sayi3;
        }
    }
}
