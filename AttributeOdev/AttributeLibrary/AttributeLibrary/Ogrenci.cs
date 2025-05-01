using AttributeLibrary;

namespace AttributeLibrary
{
    public class Ogrenci
    {
        [ZorunluAlan("Boş Bırakılamaz Lütfen Doldurun")]
        public string isim { get; set; }

        [ZorunluAlan("Boş Bırakılamaz Lütfen Doldurun")]
        public string soyisim { get; set; }

        [ZorunluAlan("Boş Bırakılamaz Lütfen Doldurun")]
        public string bolum { get; set; }
    }
}
