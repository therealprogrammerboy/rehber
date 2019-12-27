using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //yanlışlıkla oluşturuldu silinirse hata veriyor
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //yanlışlıkla oluşturuldu silinirse hata veriyor
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string gelenEskiNumara = txtNumara.Text;
            string gelenYeniNumara = txtYeniNumara.Text;
            SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-6K8V3U6;Initial Catalog=rehber;Integrated Security=true;");
            baglantı.Open();
            string sqlSorgu = "update kayıtlar set numara='"+gelenYeniNumara+"' where numara='"+gelenEskiNumara+"'";
            SqlCommand cmd = new SqlCommand(sqlSorgu, baglantı);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncelleme Başarılı !");
            baglantı.Close();
        }
    }
}
