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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtİsim_TextChanged(object sender, EventArgs e)
        {
            //yanlışlıkla oluşturuldu silinirse çökmelere sebep oluyor!
        }

        private void btnKaydıEkle_Click(object sender, EventArgs e)
        {
            //gelen verileri değişkenlere atıyoruz ve ardından
            //sql bağlantısı oluşturup içine insert into metoduyla kaydediyoruz
            string gelenİsim = txtİsim.Text;
            string gelenSoyİsim = txtSoyisim.Text;
            string gelenNumara = txtNumara.Text;
            string gelenSehir = txtSehir.Text;
            SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-6K8V3U6;Initial Catalog=rehber;Integrated Security=true;");
            baglantı.Open();
            string sqlSorgu = "insert into kayıtlar(isim,soyisim,numara,sehir) values('"+gelenİsim+"','"+gelenSoyİsim+"','"+gelenNumara+"','"+gelenSehir+"')";
            SqlCommand cmd = new SqlCommand(sqlSorgu,baglantı);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı !");
            baglantı.Close();
        }
    }
}
