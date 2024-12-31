namespace OBS_Proje
{
    partial class OgrenciEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            cmb_sinif = new ComboBox();
            txt_numara = new TextBox();
            txt_soyad = new TextBox();
            txt_ad = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_kaydet = new Button();
            btn_bul = new Button();
            btn_guncelle = new Button();
            btn_ders_secim = new Button();
            btn_sinif_ekle = new Button();
            btn_ders_ekle = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(37, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmb_sinif);
            groupBox1.Controls.Add(txt_numara);
            groupBox1.Controls.Add(txt_soyad);
            groupBox1.Controls.Add(txt_ad);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(11, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 208);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci";
            // 
            // cmb_sinif
            // 
            cmb_sinif.FormattingEnabled = true;
            cmb_sinif.Location = new Point(108, 159);
            cmb_sinif.Name = "cmb_sinif";
            cmb_sinif.Size = new Size(176, 36);
            cmb_sinif.TabIndex = 7;
            // 
            // txt_numara
            // 
            txt_numara.Location = new Point(108, 119);
            txt_numara.Name = "txt_numara";
            txt_numara.Size = new Size(176, 34);
            txt_numara.TabIndex = 6;
            // 
            // txt_soyad
            // 
            txt_soyad.Location = new Point(108, 79);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(176, 34);
            txt_soyad.TabIndex = 5;
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(108, 39);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(176, 34);
            txt_ad.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(6, 167);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 3;
            label4.Text = "Sınıf";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(6, 125);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 2;
            label3.Text = "Numara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(6, 85);
            label2.Name = "label2";
            label2.Size = new Size(67, 28);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(331, 12);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(114, 29);
            btn_kaydet.TabIndex = 2;
            btn_kaydet.Text = "Kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // btn_bul
            // 
            btn_bul.Location = new Point(331, 48);
            btn_bul.Name = "btn_bul";
            btn_bul.Size = new Size(114, 29);
            btn_bul.TabIndex = 3;
            btn_bul.Text = "Bul";
            btn_bul.UseVisualStyleBackColor = true;
            btn_bul.Click += btn_bul_Click;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(331, 83);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(114, 29);
            btn_guncelle.TabIndex = 4;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // btn_ders_secim
            // 
            btn_ders_secim.Location = new Point(331, 118);
            btn_ders_secim.Name = "btn_ders_secim";
            btn_ders_secim.Size = new Size(114, 29);
            btn_ders_secim.TabIndex = 5;
            btn_ders_secim.Text = "Ders Seçimi";
            btn_ders_secim.UseVisualStyleBackColor = true;
            btn_ders_secim.Click += btn_ders_secim_Click;
            // 
            // btn_sinif_ekle
            // 
            btn_sinif_ekle.Location = new Point(331, 153);
            btn_sinif_ekle.Name = "btn_sinif_ekle";
            btn_sinif_ekle.Size = new Size(114, 29);
            btn_sinif_ekle.TabIndex = 6;
            btn_sinif_ekle.Text = "Sınıf Ekle";
            btn_sinif_ekle.UseVisualStyleBackColor = true;
            btn_sinif_ekle.Click += btn_sinif_ekle_Click;
            // 
            // btn_ders_ekle
            // 
            btn_ders_ekle.Location = new Point(331, 188);
            btn_ders_ekle.Name = "btn_ders_ekle";
            btn_ders_ekle.Size = new Size(114, 29);
            btn_ders_ekle.TabIndex = 7;
            btn_ders_ekle.Text = "Ders Ekle";
            btn_ders_ekle.UseVisualStyleBackColor = true;
            btn_ders_ekle.Click += btn_ders_ekle_Click;
            // 
            // OgrenciEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 246);
            Controls.Add(btn_ders_ekle);
            Controls.Add(btn_sinif_ekle);
            Controls.Add(btn_ders_secim);
            Controls.Add(btn_guncelle);
            Controls.Add(btn_bul);
            Controls.Add(btn_kaydet);
            Controls.Add(groupBox1);
            Name = "OgrenciEkle";
            Text = "OgrenciEkle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private ComboBox cmb_sinif;
        private TextBox txt_numara;
        private TextBox txt_soyad;
        private TextBox txt_ad;
        private Label label4;
        private Button btn_kaydet;
        private Button btn_bul;
        private Button btn_guncelle;
        private Button btn_ders_secim;
        private Button btn_sinif_ekle;
        private Button btn_ders_ekle;
    }
}