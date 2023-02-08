namespace BERKAYDENIZPersonelTakipOtomasyonu
{
    partial class frmResim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResim));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnYakala = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(223, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 184);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnBaslat
            // 
            this.btnBaslat.FlatAppearance.BorderSize = 0;
            this.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaslat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaslat.ImageIndex = 5;
            this.btnBaslat.ImageList = this.ımageList1;
            this.btnBaslat.Location = new System.Drawing.Point(12, 202);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 40);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnYakala
            // 
            this.btnYakala.FlatAppearance.BorderSize = 0;
            this.btnYakala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYakala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYakala.ImageIndex = 6;
            this.btnYakala.ImageList = this.ımageList1;
            this.btnYakala.Location = new System.Drawing.Point(110, 202);
            this.btnYakala.Name = "btnYakala";
            this.btnYakala.Size = new System.Drawing.Size(80, 40);
            this.btnYakala.TabIndex = 3;
            this.btnYakala.Text = "Yakala";
            this.btnYakala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYakala.UseVisualStyleBackColor = true;
            this.btnYakala.Click += new System.EventHandler(this.btnYakala_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dosya Adı";
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Location = new System.Drawing.Point(223, 222);
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(205, 20);
            this.txtDosyaAdi.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.ImageIndex = 3;
            this.btnKaydet.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(275, 257);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(81, 40);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageIndex = 0;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(362, 257);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(66, 40);
            this.btnCikis.TabIndex = 7;
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
            this.ımageList1.Images.SetKeyName(5, "rec-button.png");
            this.ımageList1.Images.SetKeyName(6, "photo-capture.png");
            // 
            // frmResim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 313);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtDosyaAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYakala);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmResim";
            this.Text = "Resim Sayfası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmResim_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnYakala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDosyaAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ImageList ımageList1;
    }
}