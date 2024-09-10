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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string durum = "";


        //veri tabanının yerini belirttiğimiz kısım
        SqlConnection baglanti = new SqlConnection("Data Source=ayas\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        //

        void temizle()
        {

            textBox_id.Text = "";
            textBox_ad.Text = "";
            textBox_soyad.Text = "";
            comboBox_Meslek.Text = "";
            comboBox_Sehir.Text = "";
            maskedTextBox_Maas.Text = "";
            durum = "false";
            textBox_ad.Focus();
        }

        void sil()
        {
            baglanti.Open();

            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1",baglanti);
            komutsil.Parameters.AddWithValue("@k1", textBox_id.Text);

            komutsil .ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt silindi");
        }
        void kaydet()
        {
            baglanti.Open();
            if (textBox_ad.Text == "" || textBox_soyad.Text == "")
            {
                MessageBox.Show("ad ve soyad kısmı boş bırakılamaz");
            }
            else
            {

                SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaaş,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                komut.Parameters.AddWithValue("@p1", textBox_ad.Text);
                komut.Parameters.AddWithValue("@p2", textBox_soyad.Text);
                komut.Parameters.AddWithValue("@p3", comboBox_Sehir.Text);
                komut.Parameters.AddWithValue("@p4", Convert.ToInt16(maskedTextBox_Maas.Text));
                komut.Parameters.AddWithValue("@p5", comboBox_Meslek.Text);
                komut.Parameters.AddWithValue("@p6", durum);

                komut.ExecuteNonQuery();
                MessageBox.Show("Personel eklendi");
            }
            baglanti.Close();
        }

        void guncelle()
        {
            baglanti.Open();

            SqlCommand update = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaaş=@a4,PerDurum=@a5,PerMeslek=@a6 where Perid=@a7", baglanti);
            update.Parameters.AddWithValue("@a1", textBox_ad.Text);
            update.Parameters.AddWithValue("@a2", textBox_soyad.Text);
            update.Parameters.AddWithValue("@a3", comboBox_Sehir.Text);
            update.Parameters.AddWithValue("@a4", maskedTextBox_Maas.Text);
            update.Parameters.AddWithValue("@a5", durum);
            update.Parameters.AddWithValue("@a6", comboBox_Meslek.Text);
            update.Parameters.AddWithValue("@a7", textBox_id.Text);
            MessageBox.Show("personel bilgi güncellendi");

            update.ExecuteNonQuery();
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_listele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void radioButton_evli_true_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_evli_true.Checked == true)
            {
                durum = "true";
            }

        }

        private void radioButton_evli_false_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_evli_false.Checked == true)
            {
                durum = "false";
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            
            textBox_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox_Sehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox_Maas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            durum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            comboBox_Meslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            if(durum == "true")
            {
                radioButton_evli_true.Checked = true;
            }
            if(durum == "false")
            {
                radioButton_evli_false.Checked = true;
            }
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void btn_istatistik_Click(object sender, EventArgs e)
        {
            Form_İstatistik frmİstatistik = new Form_İstatistik();
            frmİstatistik.Show();
        }

        private void button_grafik_Click(object sender, EventArgs e)
        {
            Form_Grafik frg = new Form_Grafik();
            frg.Show();
        }
    }
}
