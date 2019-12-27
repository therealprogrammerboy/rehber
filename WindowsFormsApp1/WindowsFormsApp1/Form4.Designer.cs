namespace WindowsFormsApp1
{
    partial class Form4
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
            this.lblGunKulNumara = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtYeniNumara = new System.Windows.Forms.TextBox();
            this.lblYeniNumara = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGunKulNumara
            // 
            this.lblGunKulNumara.AutoSize = true;
            this.lblGunKulNumara.Location = new System.Drawing.Point(3, 19);
            this.lblGunKulNumara.Name = "lblGunKulNumara";
            this.lblGunKulNumara.Size = new System.Drawing.Size(171, 13);
            this.lblGunKulNumara.TabIndex = 2;
            this.lblGunKulNumara.Text = "Güncellenecek kullanıcı numarası :";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(180, 19);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 6;
            // 
            // txtYeniNumara
            // 
            this.txtYeniNumara.Location = new System.Drawing.Point(180, 62);
            this.txtYeniNumara.Name = "txtYeniNumara";
            this.txtYeniNumara.Size = new System.Drawing.Size(100, 20);
            this.txtYeniNumara.TabIndex = 7;
            // 
            // lblYeniNumara
            // 
            this.lblYeniNumara.AutoSize = true;
            this.lblYeniNumara.Location = new System.Drawing.Point(102, 65);
            this.lblYeniNumara.Name = "lblYeniNumara";
            this.lblYeniNumara.Size = new System.Drawing.Size(72, 13);
            this.lblYeniNumara.TabIndex = 8;
            this.lblYeniNumara.Text = "Yeni numara :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(115, 147);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 270);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblYeniNumara);
            this.Controls.Add(this.txtYeniNumara);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.lblGunKulNumara);
            this.Name = "Form4";
            this.Text = "Numara Güncelle ";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGunKulNumara;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtYeniNumara;
        private System.Windows.Forms.Label lblYeniNumara;
        private System.Windows.Forms.Button btnGuncelle;
    }
}