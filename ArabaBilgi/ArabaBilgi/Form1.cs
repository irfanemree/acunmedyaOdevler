namespace ArabaBilgi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string[]> arabaSozluk = new Dictionary<string, string[]>
        ()
        {
            {"BMW" , new []{"X5" , "F30" , "ix1"} } ,
            {"MERCEDES" , new []{"E250" , "AMG" , "CLA180"} } ,
            {"AUDÝ" , new []{"A6" , "A3" , "Q7"} } ,
            {"TOYOTA" , new []{"Yaris" , "Hilux" , "Corolla"} } ,
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMarka.Items.Clear();
            foreach (string marka in arabaSozluk.Keys)
            {
                cmbMarka.Items.Add(marka);
            }
        }

        private void btnBilgiGoster_Click(object sender, EventArgs e)
        {

            MessageBox.Show($"Marka : {cmbMarka.Text}" +
                $"Model : {cmbModel.Text}" +
                $"Renk : {cmbRenk.Text}" +
                $"Pencere Sayýsý : {cmbPencere.Text}" +
                $"Kapý Sayýsý : {cmbKapi.Text}" +
                $"Yakýt Tüketimi : {txtYakit.Text}");
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            string marka = cmbMarka.Text;
            Kontrol();
            cmbModel.Items.Clear();
            cmbModel.Text = "";

            foreach (string model in arabaSozluk.GetValueOrDefault(marka))
            {
                cmbModel.Items.Add(model);
            }
        }

        private void cmbMarka_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kontrol();
        }

        private void cmbRenk_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kontrol();
        }

        private void cmbPencere_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kontrol();
        }

        private void cmbKapi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kontrol();
        }

        private void txtYakit_TextChanged(object sender, EventArgs e)
        {
            if (Kontrol() == true) { 
                btnBilgiGoster.Visible = true;
            }
        }

        private Boolean Kontrol()
        {
            if (!string.IsNullOrEmpty(cmbMarka.Text) &&
                !string.IsNullOrEmpty(cmbModel.Text) &&
                !string.IsNullOrEmpty(cmbPencere.Text) &&
                !string.IsNullOrEmpty(cmbKapi.Text) &&
                !string.IsNullOrEmpty(txtYakit.Text) &&
                !string.IsNullOrEmpty(cmbRenk.Text))
            {
                btnBilgiGoster.Visible=true;
                return true;
            }
            btnBilgiGoster.Visible = false;
            return false;
        }
    }
}
