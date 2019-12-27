namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblYapilacakİslem = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKayıtGoruntule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblYapilacakİslem
            // 
            this.lblYapilacakİslem.AutoSize = true;
            this.lblYapilacakİslem.Location = new System.Drawing.Point(94, 42);
            this.lblYapilacakİslem.Name = "lblYapilacakİslem";
            this.lblYapilacakİslem.Size = new System.Drawing.Size(123, 13);
            this.lblYapilacakİslem.TabIndex = 0;
            this.lblYapilacakİslem.Text = "Yapılacak işlemi seçiniz :";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 85);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(130, 85);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(247, 85);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKayıtGoruntule
            // 
            this.btnKayıtGoruntule.Location = new System.Drawing.Point(80, 146);
            this.btnKayıtGoruntule.Name = "btnKayıtGoruntule";
            this.btnKayıtGoruntule.Size = new System.Drawing.Size(173, 23);
            this.btnKayıtGoruntule.TabIndex = 4;
            this.btnKayıtGoruntule.Text = "Kayıtları Görüntüle";
            this.btnKayıtGoruntule.UseVisualStyleBackColor = true;
            this.btnKayıtGoruntule.Click += new System.EventHandler(this.btnKayıtGoruntule_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 181);
            this.Controls.Add(this.btnKayıtGoruntule);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblYapilacakİslem);
            this.Name = "Form1";
            this.Text = "Rehber Otomasyon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYapilacakİslem;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKayıtGoruntule;
    }
}

