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
using System.Diagnostics.Eventing.Reader;

namespace Personel_Kayit
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        //veri tabanının yerini belirttiğimiz kısım
        SqlConnection baglanti = new SqlConnection("Data Source=ayas\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        //


        Form1 frm1 = new Form1();

        private void button1_Click(object sender, EventArgs e)

        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where KullaniciAdi=@p1 and Sifre=@p2  ", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {
                frm1.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı kullanıcı adı ve şifre girişi yaptınız");
            baglanti.Close();
            
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
