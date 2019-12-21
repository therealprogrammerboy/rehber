namespace WindowsFormsApp1
{
    partial class Form3
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
            this.lblSilinecekKisiNumara = new System.Windows.Forms.Label();
            this.txtSİlinecekKisiNumarası = new System.Windows.Forms.TextBox();
            this.sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSilinecekKisiNumara
            // 
            this.lblSilinecekKisiNumara.AutoSize = true;
            this.lblSilinecekKisiNumara.Location = new System.Drawing.Point(12, 9);
            this.lblSilinecekKisiNumara.Name = "lblSilinecekKisiNumara";
            this.lblSilinecekKisiNumara.Size = new System.Drawing.Size(119, 13);
            this.lblSilinecekKisiNumara.TabIndex = 0;
            this.lblSilinecekKisiNumara.Text = "Silinecek kişi numarası :";
            // 
            // txtSİlinecekKisiNumarası
            // 
            this.txtSİlinecekKisiNumarası.Location = new System.Drawing.Point(146, 6);
            this.txtSİlinecekKisiNumarası.Name = "txtSİlinecekKisiNumarası";
            this.txtSİlinecekKisiNumarası.Size = new System.Drawing.Size(100, 20);
            this.txtSİlinecekKisiNumarası.TabIndex = 1;
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(92, 33);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 2;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 68);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.txtSİlinecekKisiNumarası);
            this.Controls.Add(this.lblSilinecekKisiNumara);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSilinecekKisiNumara;
        private System.Windows.Forms.TextBox txtSİlinecekKisiNumarası;
        private System.Windows.Forms.Button sil;
    }
}