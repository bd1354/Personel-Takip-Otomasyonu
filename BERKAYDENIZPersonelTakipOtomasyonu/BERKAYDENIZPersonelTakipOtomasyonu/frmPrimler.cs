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
    public partial class frmPrimler : Form
    {
        public frmPrimler()
        {
            InitializeComponent();
        }

        private void frmPrimler_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());

            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);
            }

            Veritabani.Listele_Ara(dataGridView1,"select PersonelID,Adi,Soyadi,Maasi,GirisTarihi from personeller");

        }

        private void btnPrimEkle_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.KullaniciID = Kullanicilar.kid;
            p.Donem = comboAy.Text + "/" + comboYil.Text;
            p.PrimTutari = decimal.Parse(txtPrimTutari.Text);
            p.Aciklama = txtAciklama.Text;
            p.Tarih = DateTime.Now;
            string odenmedurumudefault = "Odenmedi";

            if (radioKisiyeOzel.Checked)
            {   
                p.PersonelID = int.Parse(txtPersonelID.Text); //Null dondurmesin diye yukarida degil burada cunku herkese prim eklerken bu kisim bos kaliyor
                
                string sql = "insert into Primler(KullaniciID,PersonelID,Donem,PrimTutari,OdenmeDurumu,Aciklama,Tarih) " +
                    "values('"+p.KullaniciID+"','"+p.PersonelID+"','"+p.Donem+"',@PTutari,'"+odenmedurumudefault+"','"+p.Aciklama+"',@Tarih)";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@PTutari", SqlDbType.Decimal).Value = p.PrimTutari;
                komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                Veritabani.ESG(komut,sql);
                MessageBox.Show("İşlem başarılı","Prim Ekleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (radioTumPersoneller.Checked)
            {
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string sql = "insert into Primler(KullaniciID,PersonelID,Donem,PrimTutari,OdenmeDurumu,Aciklama,Tarih) " +
                    "values('" + p.KullaniciID + "','" + dataGridView1.Rows[i].Cells[0].Value + "','" + p.Donem + "',@PTutari,'" + odenmedurumudefault + "','" + p.Aciklama + "',@Tarih)";
                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.Add("@PTutari", SqlDbType.Decimal).Value = p.PrimTutari;
                    komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                    Veritabani.ESG(komut, sql);
                    
                }
                MessageBox.Show("İşlem başarılı", "Prim Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPersonelAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " +
                dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
