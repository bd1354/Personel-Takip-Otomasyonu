using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERKAYDENIZPersonelTakipOtomasyonu
{
    public partial class frmSifremiUnuttum : Form
    {
        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Temizle()
        {
            comboSoru.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = int.Parse(txtKullaniciID.Text);
            k.KullaniciAdi = txtKullaniciAdi.Text;
            k.Sifre = txtSifre.Text;
            k.Adisoyadi = txtAdisoyadi.Text;
            k.Soru = comboSoru.Text;
            k.Cevap = txtCevap.Text;
            k.Aciklama = txtAciklama.Text;
            k.Tarih = DateTime.Now;

            if(txtSifre.Text == txtSifreTekrar.Text)
            {
                string sql = "update kullanicilar set kullaniciAdi='" + k.KullaniciAdi + "',Sifre='" + k.Sifre + "',AdiSoyadi='" + k.Adisoyadi + "',Soru='" + k.Soru + "',Cevap='" + k.Cevap + "',Tarih=@Tarih,Aciklama='" + k.Aciklama + "' where kullaniciID = '" + k.KullaniciID + "' ";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = k.Tarih;
                MessageBox.Show("Kullanıcı bilgileri güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Veritabani.ESG(komut, sql);
                Temizle();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            
        }
    }
}
