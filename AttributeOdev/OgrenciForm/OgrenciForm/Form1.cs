
using AttributeLibrary;
using System.Reflection;

namespace OgrenciForm

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBilgileriDoðrula_Click(object sender, EventArgs e)

        {
            Ogrenci ogrenci = new Ogrenci
            {
                isim = txtAd.Text,
                soyisim = txtSoyad.Text,
                bolum = txtBolum.Text
            };

            var hatalar = "";

            foreach (PropertyInfo p in typeof(Ogrenci).GetProperties())
            {
                ZorunluAlan attr = p.GetCustomAttribute<ZorunluAlan>();
                if (attr != null)
                {
                    String deger = p.GetValue(ogrenci) as string;
                    if (string.IsNullOrWhiteSpace(deger))
                    {
                        hatalar += $"{attr.HataMesaji}\n";
                    }
                }
            }

            if (!string.IsNullOrEmpty(hatalar))
            {
                MessageBox.Show(hatalar, "Doðrulama Hatalarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblSonuc.Text = $"Ad: {ogrenci.isim}\nSoyad: {ogrenci.soyisim}\nBölüm: {ogrenci.bolum}";
            }

            //txtAd.BackColor = string.IsNullOrWhiteSpace(txtAd.Text) ? Color.Red : SystemColors.Window;
            //txtSoyad.BackColor = string.IsNullOrWhiteSpace(txtSoyad.Text) ? Color.Red : SystemColors.Window;
            //txtBolum.BackColor = string.IsNullOrWhiteSpace(txtBolum.Text) ? Color.Red : SystemColors.Window;


        }
    }
}
