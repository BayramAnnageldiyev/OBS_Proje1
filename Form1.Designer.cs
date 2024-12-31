namespace OBS_Proje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new GroupBox();
            this.cmb_sinif = new ComboBox();
            this.label4 = new Label();
            this.txt_numara = new TextBox();
            this.label3 = new Label();
            this.txt_soyad = new TextBox();
            this.label2 = new Label();
            this.txt_ad = new TextBox();
            this.label1 = new Label();
            this.btn_guncelle = new Button();
            this.btn_kaydet = new Button();
            this.btn_bul = new Button();
            this.btn_ders_secim = new Button();
            this.btn_sil = new Button();
            this.btn_sinif_ekle = new Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_sinif);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_numara);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(300, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";

            // 
            // cmb_sinif
            // 
            this.cmb_sinif.FormattingEnabled = true;
            this.cmb_sinif.Location = new Point(120, 170);
            this.cmb_sinif.Name = "cmb_sinif";
            this.cmb_sinif.Size = new Size(150, 28);
            this.cmb_sinif.TabIndex = 7;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(30, 170);
            this.label4.Name = "label4";
            this.label4.Size = new Size(35, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sınıf";

            // 
            // txt_numara
            // 
            this.txt_numara.Location = new Point(120, 130);
            this.txt_numara.Name = "txt_numara";
            this.txt_numara.Size = new Size(150, 27);
            this.txt_numara.TabIndex = 5;

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(30, 130);
            this.label3.Name = "label3";
            this.label3.Size = new Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numara";

            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new Point(120, 90);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new Size(150, 27);
            this.txt_soyad.TabIndex = 3;

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";

            // 
            // txt_ad
            // 
            this.txt_ad.Location = new Point(120, 50);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new Size(150, 27);
            this.txt_ad.TabIndex = 1;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";

            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new Point(340, 50);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new Size(120, 30);
            this.btn_guncelle.TabIndex = 1;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;

            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new Point(340, 90);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new Size(120, 30);
            this.btn_kaydet.TabIndex = 2;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;

            // 
            // btn_bul
            // 
            this.btn_bul.Location = new Point(340, 130);
            this.btn_bul.Name = "btn_bul";
            this.btn_bul.Size = new Size(120, 30);
            this.btn_bul.TabIndex = 3;
            this.btn_bul.Text = "Bul";
            this.btn_bul.UseVisualStyleBackColor = true;

            // 
            // btn_ders_secim
            // 
            this.btn_ders_secim.Location = new Point(340, 170);
            this.btn_ders_secim.Name = "btn_ders_secim";
            this.btn_ders_secim.Size = new Size(120, 30);
            this.btn_ders_secim.TabIndex = 4;
            this.btn_ders_secim.Text = "Ders Seçim";
            this.btn_ders_secim.UseVisualStyleBackColor = true;

            // 
            // btn_sil
            // 
            this.btn_sil.Location = new Point(340, 210);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new Size(120, 30);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;

            // 
            // btn_sinif_ekle
            // 
            this.btn_sinif_ekle.Location = new Point(340, 250);
            this.btn_sinif_ekle.Name = "btn_sinif_ekle";
            this.btn_sinif_ekle.Size = new Size(120, 30);
            this.btn_sinif_ekle.TabIndex = 6;
            this.btn_sinif_ekle.Text = "Sınıf Ekle";
            this.btn_sinif_ekle.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(500, 300);
            this.Controls.Add(this.btn_sinif_ekle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ders_secim);
            this.Controls.Add(this.btn_bul);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Öğrenci Yönetimi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }


        private GroupBox groupBox1;
        private Label label4;
        private TextBox txt_numara;
        private Label label3;
        private TextBox txt_soyad;
        private Label label2;
        private TextBox txt_ad;
        private Label label1;
        private ComboBox cmb_sinif;
        private Button btn_guncelle;
        private Button btn_kaydet;
        private Button btn_bul;
        private Button btn_ders_secim;
        private Button btn_sil;
        private Button btn_sinif_ekle;
    }
    
}

