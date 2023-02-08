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
    public partial class frmYeniKullanici : Form
    {
        public frmYeniKullanici()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Temizle()
        {
            comboBoxSoru.Text = "";
            foreach(Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciAdi = txtKullaniciAdi.Text;
            k.Sifre = txtSifre.Text;
            k.Adisoyadi = txtAdiSoyadi.Text;
            k.Soru = comboBoxSoru.Text;
            k.Cevap = txtCevap.Text;
            k.Aciklama = txtAciklama.Text;
            k.Tarih = DateTime.Now;

            if (txtSifre.Text ==txtSifreTekrar.Text)
            {
                string sql = "insert into Kullanicilar values('" + k.KullaniciAdi + "','" + k.Sifre + "','" + k.Adisoyadi + "','" + k.Soru + "','" + k.Cevap + "'," +
                " @Tarih,'" + k.Aciklama + "')";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = k.Tarih;
                MessageBox.Show("Yeni kullanıcı eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Veritabani.ESG(komut, sql);
                Temizle();
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }
    }
}
