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
using System.IO;


namespace BERKAYDENIZPersonelTakipOtomasyonu
{
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaDepartmanGetir(comboBoxDepartman);
        }
        void Temizle()
        {
            dateTimePickerGirisTarihi.Value = DateTime.Now;
            comboBoxDepartman.Text = "";
            foreach(Control item in Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.Adi = txtAdi.Text;
            p.Soyadi = txtSoyadi.Text;
            p.Cinsiyeti = comboCinsiyet.SelectedItem.ToString() ;
            p.DogumTarihi = dateTimePickerDogumTarihi.Value;
            p.Telefon = txtTelefon.Text;
            p.Adres = txtAdres.Text;
            p.Email = txtEmail.Text;
            p.DepartmanID = (int)comboBoxDepartman.SelectedValue;
            p.Maasi = decimal.Parse(txtMaas.Text);
            p.GirisTarihi = dateTimePickerGirisTarihi.Value;
            p.Aciklama = txtAciklama.Text;
            string durumaktif = "Aktif";

            FileStream fileStream = new FileStream(imagepath,FileMode.Open,FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();

            string sorgu = "insert into Personeller(Adi,Soyadi,Cinsiyeti,DogumTarihi,Telefon,Adres,Email,DepartmanID,Durumu,Maasi,GirisTarihi,Aciklama,Resim) values('"+p.Adi+"','"+p.Soyadi+"','"+p.Cinsiyeti+"',@DogumTarihi,'"+p.Telefon+"','"+p.Adres+"','"+p.Email+"','"+p.DepartmanID+"','"+durumaktif+"',@Maasi,@GirisTarihi,'"+p.Aciklama+"',@images)";
            SqlCommand komut = new SqlCommand();

            komut.Parameters.Add("@Maasi", SqlDbType.Decimal).Value = p.Maasi;
            komut.Parameters.Add("@GirisTarihi", SqlDbType.Date).Value = p.GirisTarihi;
            komut.Parameters.Add("@DogumTarihi", SqlDbType.Date).Value = p.DogumTarihi;
            komut.Parameters.Add("@images", SqlDbType.Image,resim.Length).Value = resim;

            Veritabani.ESG(komut,sorgu);
            Temizle();
            MessageBox.Show("İşlem Başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            frmResim resim = new frmResim();
            resim.ShowDialog();
        }
        string imagepath;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Jpeg Dosyaları(*,jpeg)|*.jpeg| Jpg Dosyaları(*,jpg)|*.jpg| Png Dosyaları(*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;
            }
        }
    }
}
