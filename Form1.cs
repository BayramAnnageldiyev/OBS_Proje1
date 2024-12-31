namespace OBS_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sinif_ekle_Click(object sender, EventArgs e)
        {
            SinifEkle sinif = new SinifEkle();
            sinif.Show();
        }
    }
}
