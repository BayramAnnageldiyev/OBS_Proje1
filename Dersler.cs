using System;
using System.Linq;
using System.Windows.Forms;

namespace OBS_Proje
{
    public partial class Dersler : Form
    {
        public Dersler()
        {
            InitializeComponent();
        }

        
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ders_kod.Text) || string.IsNullOrEmpty(txt_ders_ad.Text))
            {
                MessageBox.Show("Lütfen ders kodu ve adı giriniz.");
                return;
            }

            using (var context = new OkulDbContext())
            {
                if (context.Dersler.Any(d => d.DersKodu == txt_ders_kod.Text.Trim()))
                {
                    MessageBox.Show("Bu ders koduna sahip bir ders zaten mevcut!");
                    return;
                }

                var yeniDers = new tblDersler
                {
                    DersKodu = txt_ders_kod.Text.Trim(),
                    DersAdi = txt_ders_ad.Text.Trim()
                };

                context.Dersler.Add(yeniDers);
                context.SaveChanges();
                MessageBox.Show("Ders başarıyla eklendi!");

                txt_ders_id.Clear();
                txt_ders_kod.Clear();
                txt_ders_ad.Clear();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ders_id.Text))
            {
                MessageBox.Show("Lütfen bir ders ID'si giriniz.");
                return;
            }

            using (var context = new OkulDbContext())
            {
                int dersId = int.Parse(txt_ders_id.Text);
                var ders = context.Dersler.FirstOrDefault(d => d.Id == dersId);

                if (ders == null)
                {
                    MessageBox.Show("Ders bulunamadı!");
                }
                else
                {
                    ders.DersKodu = txt_ders_kod.Text.Trim();
                    ders.DersAdi = txt_ders_ad.Text.Trim();

                    context.SaveChanges();
                    MessageBox.Show("Ders başarıyla güncellendi!");
                }
            }
        }

        
        private void btn_bul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ders_id.Text))
            {
                MessageBox.Show("Lütfen bir ders ID'si giriniz.");
                return;
            }

            using (var context = new OkulDbContext())
            {
                int dersId = int.Parse(txt_ders_id.Text);
                var ders = context.Dersler.FirstOrDefault(d => d.Id == dersId);

                if (ders != null)
                {
                    txt_ders_kod.Text = ders.DersKodu;
                    txt_ders_ad.Text = ders.DersAdi;
                }
                else
                {
                    MessageBox.Show("Ders bulunamadı!");
                }
            }
        }

        
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ders_id.Text))
            {
                MessageBox.Show("Lütfen bir ders ID'si giriniz.");
                return;
            }

            using (var context = new OkulDbContext())
            {
                int dersId = int.Parse(txt_ders_id.Text);
                var ders = context.Dersler.FirstOrDefault(d => d.Id == dersId);

                if (ders != null)
                {
                    context.Dersler.Remove(ders);
                    context.SaveChanges();
                    MessageBox.Show("Ders başarıyla silindi!");

                   
                    txt_ders_id.Clear();
                    txt_ders_kod.Clear();
                    txt_ders_ad.Clear();
                }
                else
                {
                    MessageBox.Show("Ders bulunamadı!");
                }
            }
        }
    }
}
