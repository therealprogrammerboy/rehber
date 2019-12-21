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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            string gelenSilinecekKisiNumara = txtSİlinecekKisiNumarası.Text;
            SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-6K8V3U6;Initial Catalog=rehber;Integrated Security=true;");
            baglantı.Open();
            string sqlSorgu = "delete from kayıtlar where numara='"+gelenSilinecekKisiNumara+"'";
            SqlCommand cmd = new SqlCommand(sqlSorgu, baglantı);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı !");
        }
    }
}
