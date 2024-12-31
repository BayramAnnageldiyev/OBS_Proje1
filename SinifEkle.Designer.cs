namespace OBS_Proje
{
    partial class SinifEkle
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
            groupBox1 = new GroupBox();
            txt_kontenjan = new TextBox();
            label3 = new Label();
            txt_sinif_ad = new TextBox();
            label2 = new Label();
            txt_sinif_id = new TextBox();
            label1 = new Label();
            btn_ekle = new Button();
            btn_guncelle = new Button();
            btn_bul = new Button();
            btn_sil = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_kontenjan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_sinif_ad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_sinif_id);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 215);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sınıf Ekleme";
            // 
            // txt_kontenjan
            // 
            txt_kontenjan.Location = new Point(127, 109);
            txt_kontenjan.Name = "txt_kontenjan";
            txt_kontenjan.Size = new Size(125, 27);
            txt_kontenjan.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(30, 111);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 4;
            label3.Text = "Kontenjan";
            // 
            // txt_sinif_ad
            // 
            txt_sinif_ad.Location = new Point(127, 76);
            txt_sinif_ad.Name = "txt_sinif_ad";
            txt_sinif_ad.Size = new Size(125, 27);
            txt_sinif_ad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(30, 78);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 2;
            label2.Text = "Sınıf Ad";
            // 
            // txt_sinif_id
            // 
            txt_sinif_id.Location = new Point(127, 40);
            txt_sinif_id.Name = "txt_sinif_id";
            txt_sinif_id.Size = new Size(125, 27);
            txt_sinif_id.TabIndex = 1;
            txt_sinif_id.TextChanged += txt_sinif_id_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(30, 42);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 0;
            label1.Text = "Sınıf İd";
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(36, 256);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(94, 29);
            btn_ekle.TabIndex = 1;
            btn_ekle.Text = "Ekle";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(136, 256);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(94, 29);
            btn_guncelle.TabIndex = 2;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // btn_bul
            // 
            btn_bul.Location = new Point(238, 256);
            btn_bul.Name = "btn_bul";
            btn_bul.Size = new Size(94, 29);
            btn_bul.TabIndex = 3;
            btn_bul.Text = "Bul";
            btn_bul.UseVisualStyleBackColor = true;
            btn_bul.Click += btn_bul_Click;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(136, 291);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(94, 29);
            btn_sil.TabIndex = 4;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // SinifEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 348);
            Controls.Add(btn_sil);
            Controls.Add(btn_bul);
            Controls.Add(btn_guncelle);
            Controls.Add(btn_ekle);
            Controls.Add(groupBox1);
            Name = "SinifEkle";
            Text = "SinifEkle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_kontenjan;
        private Label label3;
        private TextBox txt_sinif_ad;
        private Label label2;
        private TextBox txt_sinif_id;
        private Label label1;
        private Button btn_ekle;
        private Button btn_guncelle;
        private Button btn_bul;
        private Button btn_sil;
    }
}