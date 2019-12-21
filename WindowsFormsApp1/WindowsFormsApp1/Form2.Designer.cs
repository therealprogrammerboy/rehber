namespace WindowsFormsApp1
{
    partial class Form2
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
            this.lblİsim = new System.Windows.Forms.Label();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.lblNumara = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.lblŞehir = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.btnKaydıEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblİsim
            // 
            this.lblİsim.AutoSize = true;
            this.lblİsim.Location = new System.Drawing.Point(12, 13);
            this.lblİsim.Name = "lblİsim";
            this.lblİsim.Size = new System.Drawing.Size(31, 13);
            this.lblİsim.TabIndex = 0;
            this.lblİsim.Text = "İsim :";
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(56, 6);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(100, 20);
            this.txtİsim.TabIndex = 1;
            this.txtİsim.TextChanged += new System.EventHandler(this.txtİsim_TextChanged);
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(2, 51);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(48, 13);
            this.lblSoyisim.TabIndex = 2;
            this.lblSoyisim.Text = "Soyisim :";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(56, 51);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(100, 20);
            this.txtSoyisim.TabIndex = 3;
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(0, 91);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(50, 13);
            this.lblNumara.TabIndex = 4;
            this.lblNumara.Text = "Numara :";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(56, 91);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 5;
            // 
            // lblŞehir
            // 
            this.lblŞehir.AutoSize = true;
            this.lblŞehir.Location = new System.Drawing.Point(2, 133);
            this.lblŞehir.Name = "lblŞehir";
            this.lblŞehir.Size = new System.Drawing.Size(37, 13);
            this.lblŞehir.TabIndex = 6;
            this.lblŞehir.Text = "Şehir :";
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(56, 133);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(100, 20);
            this.txtSehir.TabIndex = 7;
            // 
            // btnKaydıEkle
            // 
            this.btnKaydıEkle.Location = new System.Drawing.Point(210, 81);
            this.btnKaydıEkle.Name = "btnKaydıEkle";
            this.btnKaydıEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKaydıEkle.TabIndex = 8;
            this.btnKaydıEkle.Text = "Kaydı Ekle";
            this.btnKaydıEkle.UseVisualStyleBackColor = true;
            this.btnKaydıEkle.Click += new System.EventHandler(this.btnKaydıEkle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 177);
            this.Controls.Add(this.btnKaydıEkle);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.lblŞehir);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.lblNumara);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.lblSoyisim);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.lblİsim);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblİsim;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label lblŞehir;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.Button btnKaydıEkle;
    }
}