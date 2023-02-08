using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERKAYDENIZPersonelTakipOtomasyonu
{
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanicilar.KullaniciGirisi(txtKullaniciAdi.Text, txtSifre.Text);
            if (Kullanicilar.durum)
            {

                Form1 frm = new Form1();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Şifre ya da kullanıcı adı hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifremiUnuttum frm = new frmSifremiUnuttum();
            frm.ShowDialog();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frmYeniKullanici frm = new frmYeniKullanici();
            frm.ShowDialog();
        }
    }
}
