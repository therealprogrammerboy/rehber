using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MessageBox.Show("No : 181809029\nÖmer Akincir\nManisa Celal Bayar Üniversitesi Kırkağaç MYO\nDers : Nesne Tabanlı Programlama\nGithub Linki : https://github.com/therealprogrammerboy/rehber");
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            f3.ShowDialog();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();

            f4.ShowDialog();
        }

        private void btnKayıtGoruntule_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
