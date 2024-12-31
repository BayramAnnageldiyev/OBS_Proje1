namespace OBS_Proje
{
    partial class Dersler
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
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txt_ders_id = new TextBox();
            txt_ders_kod = new TextBox();
            txt_ders_ad = new TextBox();
            btn_ekle = new Button();
            btn_sil = new Button();
            btn_bul = new Button();
            btn_guncelle = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 0;
            label1.Text = "Ders Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(16, 108);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 1;
            label2.Text = "Ders Ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(16, 70);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 2;
            label3.Text = "Ders Kod";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_ders_ad);
            groupBox1.Controls.Add(txt_ders_kod);
            groupBox1.Controls.Add(txt_ders_id);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 152);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ders Ekle";
            // 
            // txt_ders_id
            // 
            txt_ders_id.Location = new Point(127, 33);
            txt_ders_id.Name = "txt_ders_id";
            txt_ders_id.Size = new Size(125, 27);
            txt_ders_id.TabIndex = 3;
            // 
            // txt_ders_kod
            // 
            txt_ders_kod.Location = new Point(127, 71);
            txt_ders_kod.Name = "txt_ders_kod";
            txt_ders_kod.Size = new Size(125, 27);
            txt_ders_kod.TabIndex = 4;
            // 
            // txt_ders_ad
            // 
            txt_ders_ad.Location = new Point(127, 108);
            txt_ders_ad.Name = "txt_ders_ad";
            txt_ders_ad.Size = new Size(125, 27);
            txt_ders_ad.TabIndex = 5;
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(335, 31);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(94, 29);
            btn_ekle.TabIndex = 4;
            btn_ekle.Text = "Ekle";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(335, 66);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(94, 29);
            btn_sil.TabIndex = 5;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // btn_bul
            // 
            btn_bul.Location = new Point(335, 104);
            btn_bul.Name = "btn_bul";
            btn_bul.Size = new Size(94, 29);
            btn_bul.TabIndex = 6;
            btn_bul.Text = "Bul";
            btn_bul.UseVisualStyleBackColor = true;
            btn_bul.Click += btn_bul_Click;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(335, 138);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(94, 29);
            btn_guncelle.TabIndex = 7;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // Dersler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 224);
            Controls.Add(btn_guncelle);
            Controls.Add(btn_bul);
            Controls.Add(btn_sil);
            Controls.Add(btn_ekle);
            Controls.Add(groupBox1);
            Name = "Dersler";
            Text = "Dersler";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox txt_ders_ad;
        private TextBox txt_ders_kod;
        private TextBox txt_ders_id;
        private Button btn_ekle;
        private Button btn_sil;
        private Button btn_bul;
        private Button btn_guncelle;
    }
}