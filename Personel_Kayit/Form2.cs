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

namespace Personel_Kayit
{
    public partial class Form_İstatistik : Form
    {
        public Form_İstatistik()
        {
            InitializeComponent();
        }

        //veri tabanının yerini belirttiğimiz kısım
        SqlConnection bağlanti = new SqlConnection("Data Source=ayas\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        //

        private void Form_İstatistik_Load(object sender, EventArgs e)
        {
            bağlanti.Open();

            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel",bağlanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblTopPerSayisi.Text = dr1[0].ToString();
            }

            bağlanti.Close();


            //evli per sayisi
            bağlanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum=1",bağlanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblEvliPerSayisi.Text = dr2[0].ToString();
            }

            bağlanti.Close();

            //bekar sayisi
            bağlanti.Open();

            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum=0",bağlanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblBekarPerSayisi.Text = dr3[0].ToString();
            }

            bağlanti.Close();

            //şehir sayisi
            bağlanti.Open();

            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerSehir)) From Tbl_Personel",bağlanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblSehirSayisi.Text = dr4[0].ToString();
            }

            bağlanti.Close();

            //toplam maaş
            bağlanti.Open();

            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaaş) from Tbl_Personel",bağlanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblTopMaas.Text = dr5[0].ToString();
            }
            bağlanti.Close() ;

            //ortalama maaş
            bağlanti.Open();

            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaaş) From Tbl_Personel",bağlanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblAvgMaas.Text = dr6[0].ToString();
            }

            bağlanti.Close() ;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
