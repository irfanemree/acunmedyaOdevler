using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeLibrary
{
    [AttributeUsage(AttributeTargets.Property , AllowMultiple = false)]
    public class ZorunluAlan : Attribute
    {
        public string HataMesaji { get; set; }

        public ZorunluAlan(string hataMesaji)
        {
            HataMesaji = hataMesaji;
        }
    }
}
