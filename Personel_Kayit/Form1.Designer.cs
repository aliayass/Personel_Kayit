namespace Personel_Kayit
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PersonelKayitBox = new System.Windows.Forms.GroupBox();
            this.comboBox_Meslek = new System.Windows.Forms.ComboBox();
            this.comboBox_Sehir = new System.Windows.Forms.ComboBox();
            this.textBox_Maas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton_evli_false = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton_evli_true = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_grafik = new System.Windows.Forms.Button();
            this.btn_istatistik = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_listele = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaaşDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new Personel_Kayit.PersonelVeriTabaniDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_PersonelTableAdapter = new Personel_Kayit.PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.PersonelKayitBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonelKayitBox
            // 
            this.PersonelKayitBox.Controls.Add(this.comboBox_Meslek);
            this.PersonelKayitBox.Controls.Add(this.comboBox_Sehir);
            this.PersonelKayitBox.Controls.Add(this.textBox_Maas);
            this.PersonelKayitBox.Controls.Add(this.label7);
            this.PersonelKayitBox.Controls.Add(this.radioButton_evli_false);
            this.PersonelKayitBox.Controls.Add(this.label6);
            this.PersonelKayitBox.Controls.Add(this.radioButton_evli_true);
            this.PersonelKayitBox.Controls.Add(this.label5);
            this.PersonelKayitBox.Controls.Add(this.label4);
            this.PersonelKayitBox.Controls.Add(this.textBox_soyad);
            this.PersonelKayitBox.Controls.Add(this.label3);
            this.PersonelKayitBox.Controls.Add(this.textBox_ad);
            this.PersonelKayitBox.Controls.Add(this.label2);
            this.PersonelKayitBox.Controls.Add(this.textBox_id);
            this.PersonelKayitBox.Controls.Add(this.label1);
            this.PersonelKayitBox.Location = new System.Drawing.Point(2, 3);
            this.PersonelKayitBox.Name = "PersonelKayitBox";
            this.PersonelKayitBox.Size = new System.Drawing.Size(392, 347);
            this.PersonelKayitBox.TabIndex = 0;
            this.PersonelKayitBox.TabStop = false;
            this.PersonelKayitBox.Text = "Personel Kayıt";
            this.PersonelKayitBox.Enter += new System.EventHandler(this.PersonelKayitBox_Enter);
            // 
            // comboBox_Meslek
            // 
            this.comboBox_Meslek.FormattingEnabled = true;
            this.comboBox_Meslek.Location = new System.Drawing.Point(167, 294);
            this.comboBox_Meslek.Name = "comboBox_Meslek";
            this.comboBox_Meslek.Size = new System.Drawing.Size(167, 37);
            this.comboBox_Meslek.TabIndex = 8;
            // 
            // comboBox_Sehir
            // 
            this.comboBox_Sehir.FormattingEnabled = true;
            this.comboBox_Sehir.Location = new System.Drawing.Point(167, 162);
            this.comboBox_Sehir.Name = "comboBox_Sehir";
            this.comboBox_Sehir.Size = new System.Drawing.Size(167, 37);
            this.comboBox_Sehir.TabIndex = 4;
            // 
            // textBox_Maas
            // 
            this.textBox_Maas.Location = new System.Drawing.Point(167, 210);
            this.textBox_Maas.Name = "textBox_Maas";
            this.textBox_Maas.Size = new System.Drawing.Size(167, 37);
            this.textBox_Maas.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Maaş";
            // 
            // radioButton_evli_false
            // 
            this.radioButton_evli_false.AutoSize = true;
            this.radioButton_evli_false.Location = new System.Drawing.Point(239, 256);
            this.radioButton_evli_false.Name = "radioButton_evli_false";
            this.radioButton_evli_false.Size = new System.Drawing.Size(95, 33);
            this.radioButton_evli_false.TabIndex = 7;
            this.radioButton_evli_false.TabStop = true;
            this.radioButton_evli_false.Text = "Bekar";
            this.radioButton_evli_false.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Meslek";
            // 
            // radioButton_evli_true
            // 
            this.radioButton_evli_true.AutoSize = true;
            this.radioButton_evli_true.Location = new System.Drawing.Point(170, 256);
            this.radioButton_evli_true.Name = "radioButton_evli_true";
            this.radioButton_evli_true.Size = new System.Drawing.Size(72, 33);
            this.radioButton_evli_true.TabIndex = 6;
            this.radioButton_evli_true.TabStop = true;
            this.radioButton_evli_true.Text = "Evli";
            this.radioButton_evli_true.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Durum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şehir";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Location = new System.Drawing.Point(167, 119);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(167, 37);
            this.textBox_soyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyad";
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(167, 76);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(167, 37);
            this.textBox_ad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personel Ad";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(170, 33);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(164, 37);
            this.textBox_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_grafik);
            this.groupBox1.Controls.Add(this.btn_istatistik);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.btn_güncelle);
            this.groupBox1.Controls.Add(this.button_sil);
            this.groupBox1.Controls.Add(this.button_kaydet);
            this.groupBox1.Controls.Add(this.button_listele);
            this.groupBox1.Location = new System.Drawing.Point(446, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 347);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_grafik
            // 
            this.btn_grafik.Location = new System.Drawing.Point(23, 295);
            this.btn_grafik.Name = "btn_grafik";
            this.btn_grafik.Size = new System.Drawing.Size(176, 37);
            this.btn_grafik.TabIndex = 6;
            this.btn_grafik.Text = "Grafikler";
            this.btn_grafik.UseVisualStyleBackColor = true;
            // 
            // btn_istatistik
            // 
            this.btn_istatistik.Location = new System.Drawing.Point(23, 252);
            this.btn_istatistik.Name = "btn_istatistik";
            this.btn_istatistik.Size = new System.Drawing.Size(177, 37);
            this.btn_istatistik.TabIndex = 5;
            this.btn_istatistik.Text = "İstatistik";
            this.btn_istatistik.UseVisualStyleBackColor = true;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(23, 209);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(176, 37);
            this.btn_temizle.TabIndex = 4;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(23, 166);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(176, 37);
            this.btn_güncelle.TabIndex = 3;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(23, 118);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(176, 37);
            this.button_sil.TabIndex = 2;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(23, 75);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(176, 37);
            this.button_kaydet.TabIndex = 1;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            // 
            // button_listele
            // 
            this.button_listele.Location = new System.Drawing.Point(23, 32);
            this.button_listele.Name = "button_listele";
            this.button_listele.Size = new System.Drawing.Size(176, 37);
            this.button_listele.TabIndex = 0;
            this.button_listele.Text = "Listele";
            this.button_listele.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(2, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(934, 218);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaaşDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(928, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            this.perSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaaşDataGridViewTextBoxColumn
            // 
            this.perMaaşDataGridViewTextBoxColumn.DataPropertyName = "PerMaaş";
            this.perMaaşDataGridViewTextBoxColumn.HeaderText = "PerMaaş";
            this.perMaaşDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaaşDataGridViewTextBoxColumn.Name = "perMaaşDataGridViewTextBoxColumn";
            this.perMaaşDataGridViewTextBoxColumn.Width = 125;
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            this.perDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(715, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 577);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PersonelKayitBox);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PersonelKayitBox.ResumeLayout(false);
            this.PersonelKayitBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PersonelKayitBox;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.RadioButton radioButton_evli_false;
        private System.Windows.Forms.RadioButton radioButton_evli_true;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_listele;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button btn_grafik;
        private System.Windows.Forms.Button btn_istatistik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Maas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_Meslek;
        private System.Windows.Forms.ComboBox comboBox_Sehir;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaaşDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
    }
}

