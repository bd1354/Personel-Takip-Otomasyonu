namespace BERKAYDENIZPersonelTakipOtomasyonu
{
    partial class frmPersonelListele
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelListele));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPersonelAdiAra = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyadiAra = new System.Windows.Forms.TextBox();
            this.txtPersonelTelefonAra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDepartman = new System.Windows.Forms.ComboBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblToplamMaas = new System.Windows.Forms.Label();
            this.lblToplamKayit = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePickerG_Tarihi = new System.Windows.Forms.DateTimePicker();
            this.txtCinsiyeteGoreAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYasaGoreAra = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboCinsiyet = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePickerDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Adı Ara:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Personel Soyadı Ara:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Personel Telefon Ara:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(857, 255);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtPersonelAdiAra
            // 
            this.txtPersonelAdiAra.Location = new System.Drawing.Point(278, 31);
            this.txtPersonelAdiAra.Name = "txtPersonelAdiAra";
            this.txtPersonelAdiAra.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelAdiAra.TabIndex = 9;
            this.txtPersonelAdiAra.TextChanged += new System.EventHandler(this.txtPersonelAdıAra_TextChanged);
            // 
            // txtPersonelSoyadiAra
            // 
            this.txtPersonelSoyadiAra.Location = new System.Drawing.Point(403, 31);
            this.txtPersonelSoyadiAra.Name = "txtPersonelSoyadiAra";
            this.txtPersonelSoyadiAra.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelSoyadiAra.TabIndex = 10;
            this.txtPersonelSoyadiAra.TextChanged += new System.EventHandler(this.txtPersonelSoyadiAra_TextChanged);
            // 
            // txtPersonelTelefonAra
            // 
            this.txtPersonelTelefonAra.Location = new System.Drawing.Point(534, 31);
            this.txtPersonelTelefonAra.Name = "txtPersonelTelefonAra";
            this.txtPersonelTelefonAra.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelTelefonAra.TabIndex = 11;
            this.txtPersonelTelefonAra.TextChanged += new System.EventHandler(this.txtPersonelTelefonAra_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Telefonu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Personel Soyadı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Personel Adı:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(122, 402);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(131, 20);
            this.txtTelefon.TabIndex = 14;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(122, 376);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(131, 20);
            this.txtSoyadi.TabIndex = 13;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(122, 350);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(131, 20);
            this.txtAdi.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "E-mail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Adres:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(337, 323);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(131, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(122, 430);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(131, 52);
            this.txtAdres.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Giriş Tarihi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(292, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Maaş:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Departman:";
            // 
            // dateTimePickerGirisTarihi
            // 
            this.dateTimePickerGirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerGirisTarihi.Location = new System.Drawing.Point(337, 402);
            this.dateTimePickerGirisTarihi.Name = "dateTimePickerGirisTarihi";
            this.dateTimePickerGirisTarihi.Size = new System.Drawing.Size(131, 20);
            this.dateTimePickerGirisTarihi.TabIndex = 24;
            // 
            // comboBoxDepartman
            // 
            this.comboBoxDepartman.FormattingEnabled = true;
            this.comboBoxDepartman.Location = new System.Drawing.Point(337, 349);
            this.comboBoxDepartman.Name = "comboBoxDepartman";
            this.comboBoxDepartman.Size = new System.Drawing.Size(131, 21);
            this.comboBoxDepartman.TabIndex = 23;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(337, 376);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(131, 20);
            this.txtMaas.TabIndex = 22;
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageIndex = 0;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(814, 436);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(65, 40);
            this.btnCikis.TabIndex = 31;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "4831032_door_entrance_exit_leave_logout_icon.png");
            this.ımageList1.Images.SetKeyName(1, "46845_documents_draft_eraser_icon.png");
            this.ımageList1.Images.SetKeyName(2, "285638_pencil_icon.png");
            this.ımageList1.Images.SetKeyName(3, "27876_add_cancel_delete_edit_guardar_icon.png");
            this.ımageList1.Images.SetKeyName(4, "299068_add_sign_icon.png");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(275, 430);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(337, 430);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(131, 52);
            this.txtAciklama.TabIndex = 28;
            // 
            // lblToplamMaas
            // 
            this.lblToplamMaas.AutoSize = true;
            this.lblToplamMaas.Location = new System.Drawing.Point(652, 326);
            this.lblToplamMaas.Name = "lblToplamMaas";
            this.lblToplamMaas.Size = new System.Drawing.Size(224, 13);
            this.lblToplamMaas.TabIndex = 32;
            this.lblToplamMaas.Text = "Listede toplam 55.000,85 TL maaş hesaplandı";
            // 
            // lblToplamKayit
            // 
            this.lblToplamKayit.AutoSize = true;
            this.lblToplamKayit.Location = new System.Drawing.Point(652, 352);
            this.lblToplamKayit.Name = "lblToplamKayit";
            this.lblToplamKayit.Size = new System.Drawing.Size(128, 13);
            this.lblToplamKayit.TabIndex = 33;
            this.lblToplamKayit.Text = "Toplam 55 kayıt listelendi.";
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 1;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(743, 436);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(65, 40);
            this.btnSil.TabIndex = 35;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageIndex = 4;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(655, 436);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(82, 40);
            this.btnGuncelle.TabIndex = 34;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(661, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Personel Tarih Ara:";
            // 
            // dateTimePickerG_Tarihi
            // 
            this.dateTimePickerG_Tarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerG_Tarihi.Location = new System.Drawing.Point(664, 31);
            this.dateTimePickerG_Tarihi.Name = "dateTimePickerG_Tarihi";
            this.dateTimePickerG_Tarihi.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerG_Tarihi.TabIndex = 40;
            this.dateTimePickerG_Tarihi.ValueChanged += new System.EventHandler(this.dateTimePickerG_Tarihi_ValueChanged);
            // 
            // txtCinsiyeteGoreAra
            // 
            this.txtCinsiyeteGoreAra.Location = new System.Drawing.Point(22, 31);
            this.txtCinsiyeteGoreAra.Name = "txtCinsiyeteGoreAra";
            this.txtCinsiyeteGoreAra.Size = new System.Drawing.Size(100, 20);
            this.txtCinsiyeteGoreAra.TabIndex = 42;
            this.txtCinsiyeteGoreAra.TextChanged += new System.EventHandler(this.txtCinsiyeteGoreAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Cinsiyete Göre Ara:";
            // 
            // txtYasaGoreAra
            // 
            this.txtYasaGoreAra.Location = new System.Drawing.Point(153, 31);
            this.txtYasaGoreAra.Name = "txtYasaGoreAra";
            this.txtYasaGoreAra.Size = new System.Drawing.Size(100, 20);
            this.txtYasaGoreAra.TabIndex = 44;
            this.txtYasaGoreAra.TextChanged += new System.EventHandler(this.txtYasaGoreAra_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(150, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Yaşa Göre Ara:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(655, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(721, 379);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(87, 23);
            this.btnFoto.TabIndex = 46;
            this.btnFoto.Text = "Fotoğraf Seç";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboCinsiyet
            // 
            this.comboCinsiyet.FormattingEnabled = true;
            this.comboCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboCinsiyet.Location = new System.Drawing.Point(122, 323);
            this.comboCinsiyet.Name = "comboCinsiyet";
            this.comboCinsiyet.Size = new System.Drawing.Size(131, 21);
            this.comboCinsiyet.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(67, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Cinsiyeti:";
            // 
            // dateTimePickerDogumTarihi
            // 
            this.dateTimePickerDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDogumTarihi.Location = new System.Drawing.Point(486, 347);
            this.dateTimePickerDogumTarihi.Name = "dateTimePickerDogumTarihi";
            this.dateTimePickerDogumTarihi.Size = new System.Drawing.Size(131, 20);
            this.dateTimePickerDogumTarihi.TabIndex = 50;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(483, 323);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "Dogum Tarihi:";
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(486, 390);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(131, 32);
            this.buttonExcel.TabIndex = 51;
            this.buttonExcel.Text = "PDF\'e Aktar";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // frmPersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 488);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.dateTimePickerDogumTarihi);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboCinsiyet);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtYasaGoreAra);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCinsiyeteGoreAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerG_Tarihi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblToplamKayit);
            this.Controls.Add(this.lblToplamMaas);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePickerGirisTarihi);
            this.Controls.Add(this.comboBoxDepartman);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtPersonelTelefonAra);
            this.Controls.Add(this.txtPersonelSoyadiAra);
            this.Controls.Add(this.txtPersonelAdiAra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmPersonelListele";
            this.Text = "Personel Listeleme,Arama,Silme ve Güncelleme Sayfası";
            this.Load += new System.EventHandler(this.frmPersonelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPersonelAdiAra;
        private System.Windows.Forms.TextBox txtPersonelSoyadiAra;
        private System.Windows.Forms.TextBox txtPersonelTelefonAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePickerGirisTarihi;
        private System.Windows.Forms.ComboBox comboBoxDepartman;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblToplamMaas;
        private System.Windows.Forms.Label lblToplamKayit;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePickerG_Tarihi;
        private System.Windows.Forms.TextBox txtCinsiyeteGoreAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYasaGoreAra;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboCinsiyet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePickerDogumTarihi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonExcel;
    }
}