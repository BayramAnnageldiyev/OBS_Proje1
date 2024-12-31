namespace OBS_Proje
{
    partial class ODK
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
            lbl_bilgi = new Label();
            data_ogrenci = new DataGridView();
            btn_ogrenci_kaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)data_ogrenci).BeginInit();
            SuspendLayout();
            // 
            // lbl_bilgi
            // 
            lbl_bilgi.AutoSize = true;
            lbl_bilgi.Location = new Point(41, 26);
            lbl_bilgi.Name = "lbl_bilgi";
            lbl_bilgi.Size = new Size(95, 20);
            lbl_bilgi.TabIndex = 0;
            lbl_bilgi.Text = "Öğrenci bilgi";
            lbl_bilgi.Click += lbl_bilgi_Click;
            // 
            // data_ogrenci
            // 
            data_ogrenci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_ogrenci.Location = new Point(26, 61);
            data_ogrenci.Name = "data_ogrenci";
            data_ogrenci.RowHeadersWidth = 51;
            data_ogrenci.Size = new Size(750, 288);
            data_ogrenci.TabIndex = 1;
            // 
            // btn_ogrenci_kaydet
            // 
            btn_ogrenci_kaydet.Location = new Point(221, 392);
            btn_ogrenci_kaydet.Name = "btn_ogrenci_kaydet";
            btn_ogrenci_kaydet.Size = new Size(298, 29);
            btn_ogrenci_kaydet.TabIndex = 2;
            btn_ogrenci_kaydet.Text = "Öğrencinin bilgilerini kaydet";
            btn_ogrenci_kaydet.UseVisualStyleBackColor = true;
            btn_ogrenci_kaydet.Click += btn_ogrenci_kaydet_Click;
            // 
            // ODK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ogrenci_kaydet);
            Controls.Add(data_ogrenci);
            Controls.Add(lbl_bilgi);
            Name = "ODK";
            Text = "ODK";
            ((System.ComponentModel.ISupportInitialize)data_ogrenci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_bilgi;
        private DataGridView data_ogrenci;
        private Button btn_ogrenci_kaydet;
    }
}