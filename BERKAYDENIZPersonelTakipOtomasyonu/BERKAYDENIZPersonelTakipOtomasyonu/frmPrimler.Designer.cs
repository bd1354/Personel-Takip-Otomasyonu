namespace BERKAYDENIZPersonelTakipOtomasyonu
{
    partial class frmPrimler
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
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.radioKisiyeOzel = new System.Windows.Forms.RadioButton();
            this.radioTumPersoneller = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPrimTutari = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrimEkle = new System.Windows.Forms.Button();
            this.btnPrimGoster = new System.Windows.Forms.Button();
            this.btnPrimOde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(119, 58);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(174, 20);
            this.txtPersonelID.TabIndex = 0;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(119, 84);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(174, 20);
            this.txtPersonelAdSoyad.TabIndex = 1;
            // 
            // radioKisiyeOzel
            // 
            this.radioKisiyeOzel.AutoSize = true;
            this.radioKisiyeOzel.Location = new System.Drawing.Point(56, 22);
            this.radioKisiyeOzel.Name = "radioKisiyeOzel";
            this.radioKisiyeOzel.Size = new System.Drawing.Size(99, 17);
            this.radioKisiyeOzel.TabIndex = 2;
            this.radioKisiyeOzel.TabStop = true;
            this.radioKisiyeOzel.Text = "Kişiye Özel Prim";
            this.radioKisiyeOzel.UseVisualStyleBackColor = true;
            // 
            // radioTumPersoneller
            // 
            this.radioTumPersoneller.AutoSize = true;
            this.radioTumPersoneller.Location = new System.Drawing.Point(322, 22);
            this.radioTumPersoneller.Name = "radioTumPersoneller";
            this.radioTumPersoneller.Size = new System.Drawing.Size(143, 17);
            this.radioTumPersoneller.TabIndex = 3;
            this.radioTumPersoneller.TabStop = true;
            this.radioTumPersoneller.Text = "Tüm Personeller için Prim";
            this.radioTumPersoneller.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dönem:";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(210, 110);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(83, 21);
            this.comboYil.TabIndex = 11;
            // 
            // comboAy
            // 
            this.comboAy.FormattingEnabled = true;
            this.comboAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboAy.Location = new System.Drawing.Point(119, 110);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(65, 21);
            this.comboAy.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 150);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtPrimTutari
            // 
            this.txtPrimTutari.Location = new System.Drawing.Point(386, 55);
            this.txtPrimTutari.Name = "txtPrimTutari";
            this.txtPrimTutari.Size = new System.Drawing.Size(174, 20);
            this.txtPrimTutari.TabIndex = 15;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(386, 87);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(174, 47);
            this.txtAciklama.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "PersonelID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Personel Ad Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Prim Tutarı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Açıklama:";
            // 
            // btnPrimEkle
            // 
            this.btnPrimEkle.Location = new System.Drawing.Point(56, 160);
            this.btnPrimEkle.Name = "btnPrimEkle";
            this.btnPrimEkle.Size = new System.Drawing.Size(99, 46);
            this.btnPrimEkle.TabIndex = 21;
            this.btnPrimEkle.Text = "Prim Ekle";
            this.btnPrimEkle.UseVisualStyleBackColor = true;
            this.btnPrimEkle.Click += new System.EventHandler(this.btnPrimEkle_Click);
            // 
            // btnPrimGoster
            // 
            this.btnPrimGoster.Location = new System.Drawing.Point(161, 160);
            this.btnPrimGoster.Name = "btnPrimGoster";
            this.btnPrimGoster.Size = new System.Drawing.Size(99, 46);
            this.btnPrimGoster.TabIndex = 22;
            this.btnPrimGoster.Text = "Prim Göster";
            this.btnPrimGoster.UseVisualStyleBackColor = true;
            // 
            // btnPrimOde
            // 
            this.btnPrimOde.Location = new System.Drawing.Point(266, 160);
            this.btnPrimOde.Name = "btnPrimOde";
            this.btnPrimOde.Size = new System.Drawing.Size(99, 46);
            this.btnPrimOde.TabIndex = 23;
            this.btnPrimOde.Text = "Prim Öde";
            this.btnPrimOde.UseVisualStyleBackColor = true;
            // 
            // frmPrimler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 388);
            this.Controls.Add(this.btnPrimOde);
            this.Controls.Add(this.btnPrimGoster);
            this.Controls.Add(this.btnPrimEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrimTutari);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.radioTumPersoneller);
            this.Controls.Add(this.radioKisiyeOzel);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.txtPersonelID);
            this.Name = "frmPrimler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prim Sayfası";
            this.Load += new System.EventHandler(this.frmPrimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.RadioButton radioKisiyeOzel;
        private System.Windows.Forms.RadioButton radioTumPersoneller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPrimTutari;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrimEkle;
        private System.Windows.Forms.Button btnPrimGoster;
        private System.Windows.Forms.Button btnPrimOde;
    }
}