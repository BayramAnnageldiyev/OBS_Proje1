using System;
using System.Linq;
using System.Windows.Forms;

namespace OBS_Proje
{
    public partial class ODK : Form
    {
        public Ogrenciler SecilenOgrenci { get; set; } 

        public ODK()
        {
            InitializeComponent();
        }

        private void ODK_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadDersler()
        {
            using (var context = new OkulDbContext())
            {
                var dersler = from d in context.Dersler
                              select new
                              {
                                  DersId = d.Id,
                                  DersKodu = d.DersKodu,
                                  DersAdi = d.DersAdi
                              };

                data_ogrenci.DataSource = dersler.ToList(); 

                data_ogrenci.Columns["DersId"].Visible = false; 
                data_ogrenci.Columns["DersKodu"].HeaderText = "Ders Kodu";
                data_ogrenci.Columns["DersAdi"].HeaderText = "Ders Adı";
            }
        }

        private void btn_ogrenci_kaydet_Click(object sender, EventArgs e)
        {
            if (SecilenOgrenci == null)
            {
                MessageBox.Show("Öğrenci bilgisi eksik!");
                return;
            }

            using (var context = new OkulDbContext())
            {
                foreach (DataGridViewRow row in data_ogrenci.SelectedRows)
                {
                    int dersId = (int)row.Cells["DersId"].Value;

                    
                    if (context.OgrenciDersler.Any(od => od.OgrenciId == SecilenOgrenci.Id && od.DersId == dersId))
                    {
                        MessageBox.Show($"Ders (ID: {dersId}) zaten kayıtlı!");
                        continue;
                    }

                    var ogrenciDers = new tblOgrenciDers
                    {
                        OgrenciId = SecilenOgrenci.Id,
                        DersId = dersId
                    };

                    context.OgrenciDersler.Add(ogrenciDers);
                }

                context.SaveChanges();
                MessageBox.Show("Seçilen dersler başarıyla kaydedildi!");
            }
        }

        private void lbl_bilgi_Click(object sender, EventArgs e)
        {
            if (SecilenOgrenci != null)
            {
                
                lbl_bilgi.Text = $"Ad: {SecilenOgrenci.Ad} {SecilenOgrenci.Soyad}, No: {SecilenOgrenci.Numara}";

                LoadDersler();
            }
            else
            {
                lbl_bilgi.Text = "Öğrenci bilgisi bulunamadı!";
            }
        }
    }
}
