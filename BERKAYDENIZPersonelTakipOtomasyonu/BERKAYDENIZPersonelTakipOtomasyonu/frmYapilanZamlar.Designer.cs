namespace BERKAYDENIZPersonelTakipOtomasyonu
{
    partial class frmYapilanZamlar
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
            this.radioYuzde = new System.Windows.Forms.RadioButton();
            this.radioFiyat = new System.Windows.Forms.RadioButton();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboPersoneller = new System.Windows.Forms.ComboBox();
            this.txtYuzde = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPersonelID = new System.Windows.Forms.Label();
            this.btnOnay = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioYuzde
            // 
            this.radioYuzde.AutoSize = true;
            this.radioYuzde.Location = new System.Drawing.Point(74, 26);
            this.radioYuzde.Name = "radioYuzde";
            this.radioYuzde.Size = new System.Drawing.Size(92, 17);
            this.radioYuzde.TabIndex = 0;
            this.radioYuzde.TabStop = true;
            this.radioYuzde.Text = "Yüzdeye Göre";
            this.radioYuzde.UseVisualStyleBackColor = true;
            this.radioYuzde.CheckedChanged += new System.EventHandler(this.radioYuzde_CheckedChanged);
            // 
            // radioFiyat
            // 
            this.radioFiyat.AutoSize = true;
            this.radioFiyat.Location = new System.Drawing.Point(193, 26);
            this.radioFiyat.Name = "radioFiyat";
            this.radioFiyat.Size = new System.Drawing.Size(79, 17);
            this.radioFiyat.TabIndex = 1;
            this.radioFiyat.TabStop = true;
            this.radioFiyat.Text = "Fiyata Göre";
            this.radioFiyat.UseVisualStyleBackColor = true;
            this.radioFiyat.CheckedChanged += new System.EventHandler(this.radioFiyat_CheckedChanged);
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
            this.comboAy.Location = new System.Drawing.Point(90, 60);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(67, 21);
            this.comboAy.TabIndex = 2;
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(181, 60);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(105, 21);
            this.comboYil.TabIndex = 3;
            // 
            // comboPersoneller
            // 
            this.comboPersoneller.FormattingEnabled = true;
            this.comboPersoneller.Items.AddRange(new object[] {
            "Tüm Personeller"});
            this.comboPersoneller.Location = new System.Drawing.Point(90, 87);
            this.comboPersoneller.Name = "comboPersoneller";
            this.comboPersoneller.Size = new System.Drawing.Size(165, 21);
            this.comboPersoneller.TabIndex = 4;
            this.comboPersoneller.SelectedIndexChanged += new System.EventHandler(this.comboPersoneller_SelectedIndexChanged);
            // 
            // txtYuzde
            // 
            this.txtYuzde.Location = new System.Drawing.Point(90, 114);
            this.txtYuzde.Name = "txtYuzde";
            this.txtYuzde.Size = new System.Drawing.Size(196, 20);
            this.txtYuzde.TabIndex = 5;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(90, 140);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(196, 20);
            this.txtFiyat.TabIndex = 6;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(90, 166);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(196, 69);
            this.txtAciklama.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dönem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Personeller:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yüzde(%):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fiyat(TL):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Açıklama:";
            // 
            // lblPersonelID
            // 
            this.lblPersonelID.AutoSize = true;
            this.lblPersonelID.Location = new System.Drawing.Point(269, 90);
            this.lblPersonelID.Name = "lblPersonelID";
            this.lblPersonelID.Size = new System.Drawing.Size(13, 13);
            this.lblPersonelID.TabIndex = 14;
            this.lblPersonelID.Text = "0";
            // 
            // btnOnay
            // 
            this.btnOnay.Location = new System.Drawing.Point(90, 245);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(93, 37);
            this.btnOnay.TabIndex = 15;
            this.btnOnay.Text = "Onay";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(193, 245);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(93, 37);
            this.btnCikis.TabIndex = 16;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmYapilanZamlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 300);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.lblPersonelID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtYuzde);
            this.Controls.Add(this.comboPersoneller);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.radioFiyat);
            this.Controls.Add(this.radioYuzde);
            this.Name = "frmYapilanZamlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Maaş Zamları Sayfası";
            this.Load += new System.EventHandler(this.frmYapilanZamlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioYuzde;
        private System.Windows.Forms.RadioButton radioFiyat;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboPersoneller;
        private System.Windows.Forms.TextBox txtYuzde;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPersonelID;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Button btnCikis;
    }
}