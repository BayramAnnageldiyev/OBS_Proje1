using System;
using System.Linq;
using System.Windows.Forms;

namespace OBS_Proje
{
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
            
            LoadSiniflar();
        }

        private void LoadSiniflar()
        {
            using (var context = new OkulDbContext())
            {
                
                cmb_sinif.DataSource = context.Siniflar.ToList();
                cmb_sinif.DisplayMember = "SinifAdi";
                cmb_sinif.ValueMember = "Id";
                cmb_sinif.SelectedIndex = -1; 
            }
        }

        private void btn_sinif_ekle_Click(object sender, EventArgs e)
        {
            SinifEkle snf = new SinifEkle();
            snf.Show();
        }

        private void btn_ders_secim_Click(object sender, EventArgs e)
        {
            ODK odk = new ODK();
            odk.Show();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_numara.Text))
            {
                using (var context = new OkulDbContext())
                {
                    var ogrenci = context.Ogrenciler.FirstOrDefault(o => o.Numara == txt_numara.Text);

                    if (ogrenci != null)
                    {
                        
                        if (cmb_sinif.SelectedItem is tblSiniflar selectedSinif)
                        {
                            
                            if (ogrenci.SinifId != selectedSinif.Id)
                            {
                                int mevcutOgrenciSayisi = context.Ogrenciler.Count(o => o.SinifId == selectedSinif.Id);
                                if (mevcutOgrenciSayisi >= selectedSinif.Kontenjan)
                                {
                                    MessageBox.Show("Bu sınıfın kontenjanı doldu!");
                                    return;
                                }
                            }

                            
                            ogrenci.Ad = txt_ad.Text.Trim();
                            ogrenci.Soyad = txt_soyad.Text.Trim();
                            ogrenci.SinifId = selectedSinif.Id;

                            context.SaveChanges();
                            MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi!");
                        }
                        else
                        {
                            MessageBox.Show("Lütfen bir sınıf seçiniz!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bulunamadı!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir numara giriniz!");
            }
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_numara.Text))
            {
                using (var context = new OkulDbContext())
                {
                    var ogrenci = context.Ogrenciler.FirstOrDefault(o => o.Numara == txt_numara.Text);

                    if (ogrenci != null)
                    {
                        
                        txt_ad.Text = ogrenci.Ad;
                        txt_soyad.Text = ogrenci.Soyad;

                        
                        var sinif = context.Siniflar.FirstOrDefault(s => s.Id == ogrenci.SinifId);
                        if (sinif != null)
                        {
                            cmb_sinif.SelectedItem = sinif;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bulunamadı!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir numara giriniz!");
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_numara.Text))
            {
                using (var context = new OkulDbContext())
                {
                    
                    if (context.Ogrenciler.Any(o => o.Numara == txt_numara.Text))
                    {
                        MessageBox.Show("Bu numaraya sahip bir öğrenci zaten mevcut!");
                        return;
                    }

                    
                    if (cmb_sinif.SelectedItem is tblSiniflar selectedSinif)
                    {
                        
                        int mevcutOgrenciSayisi = context.Ogrenciler.Count(o => o.SinifId == selectedSinif.Id);
                        if (mevcutOgrenciSayisi >= selectedSinif.Kontenjan)
                        {
                            MessageBox.Show("Bu sınıfın kontenjanı doldu!");
                            return;
                        }

                       
                        var yeniOgrenci = new Ogrenciler
                        {
                            Ad = txt_ad.Text.Trim(),
                            Soyad = txt_soyad.Text.Trim(),
                            Numara = txt_numara.Text.Trim(),
                            SinifId = selectedSinif.Id
                        };

                        context.Ogrenciler.Add(yeniOgrenci);
                        context.SaveChanges();
                        MessageBox.Show("Öğrenci başarıyla kaydedildi!");

                        
                        txt_ad.Clear();
                        txt_soyad.Clear();
                        txt_numara.Clear();
                        cmb_sinif.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir sınıf seçiniz!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir numara giriniz!");
            }
        }

        private void btn_ders_ekle_Click(object sender, EventArgs e)
        {
            Dersler ders=new Dersler();
            ders.Show();
        }
    }
}
