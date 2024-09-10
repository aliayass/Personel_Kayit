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
    public partial class Form_Grafik : Form
    {
        public Form_Grafik()
        {
            InitializeComponent();
        }
        //veri tabanının yerini belirttiğimiz kısım
        SqlConnection baglanti = new SqlConnection("Data Source=ayas\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        //

        private void Form_Grafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("Select PerSehir,Count(*) From Tbl_Personel Group by PerSehir", baglanti);
            SqlDataReader dr1 =komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("Select PerMeslek,Avg(PerMaaş) From Tbl_Personel Group by PerMeslek",baglanti);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();
        }
    }
}
