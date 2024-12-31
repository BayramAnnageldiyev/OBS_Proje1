using System;
using System.Linq;
using System.Windows.Forms;

namespace OBS_Proje
{
    public partial class SinifEkle : Form
    {
        public SinifEkle()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_sinif_ad.Text) || !int.TryParse(txt_kontenjan.Text, out int kontenjan))
            {
                MessageBox.Show("Lütfen geçerli bir sınıf adı ve kontenjan giriniz.");
                return;
            }

            using (var context = new OkulDbContext())
            {
              
                if (context.Siniflar.Any(s => s.SinifAdi == txt_sinif_ad.Text.Trim()))
                {
                    MessageBox.Show("Bu isimde bir sınıf zaten mevcut!");
                    return;
                }

                var yeniSinif = new tblSiniflar
                {
                    SinifAdi = txt_sinif_ad.Text.Trim(),
                    Kontenjan = kontenjan
                };

                context.Siniflar.Add(yeniSinif);
                context.SaveChanges();
                MessageBox.Show("Sınıf başarıyla eklendi!");

                txt_sinif_ad.Clear();
                txt_kontenjan.Clear();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_sinif_id.Text) || !int.TryParse(txt_sinif_id.Text, out int sinifId) ||
                string.IsNullOrEmpty(txt_sinif_ad.Text) || !int.TryParse(txt_kontenjan.Text, out int kontenjan))
            {
                MessageBox.Show("Lütfen geçerli sınıf ID'si, adı ve kontenjan giriniz.");
                return;
            }

            using (var context = new OkulDbContext())
            {
                var sinif = context.Siniflar.FirstOrDefault(s => s.Id == sinifId);

                if (sinif != null)
                {
                    sinif.SinifAdi = txt_sinif_ad.Text.Trim();
                    sinif.Kontenjan = kontenjan;

                    context.SaveChanges();
                    MessageBox.Show("Sınıf başarıyla güncellendi!");
                }
                else
                {
                    MessageBox.Show("Sınıf bulunamadı!");
                }
            }
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_sinif_id.Text) || !int.TryParse(txt_sinif_id.Text, out int sinifId))
            {
                MessageBox.Show("Lütfen geçerli bir sınıf ID'si giriniz.");
                return;
            }

            using (var context = new OkulDbContext())
            {
                var sinif = context.Siniflar.FirstOrDefault(s => s.Id == sinifId);

                if (sinif != null)
                {
                    txt_sinif_ad.Text = sinif.SinifAdi;
                    txt_kontenjan.Text = sinif.Kontenjan.ToString();
                }
                else
                {
                    MessageBox.Show("Sınıf bulunamadı!");
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_sinif_id.Text) || !int.TryParse(txt_sinif_id.Text, out int sinifId))
            {
                MessageBox.Show("Lütfen geçerli bir sınıf ID'si giriniz.");
                return;
            }

            using (var context = new OkulDbContext())
            {
                var sinif = context.Siniflar.FirstOrDefault(s => s.Id == sinifId);

                if (sinif != null)
                {
                    context.Siniflar.Remove(sinif);
                    context.SaveChanges();
                    MessageBox.Show("Sınıf başarıyla silindi!");

                 
                    txt_sinif_id.Clear();
                    txt_sinif_ad.Clear();
                    txt_kontenjan.Clear();
                }
                else
                {
                    MessageBox.Show("Sınıf bulunamadı!");
                }
            }
        }

       
    }
}
