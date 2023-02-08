using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace BERKAYDENIZPersonelTakipOtomasyonu
{
    public partial class frmPersonelListele : Form
    {
        public frmPersonelListele()
        {
            InitializeComponent();
        }

        void YenileListele()
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.Resim as Fotograf,p.Adi as Ad,p.Soyadi as Soyad,p.Cinsiyeti as Cinsiyet,DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END ) AS Yaş,p.Telefon,p.Adres,p.Email,\r\nd.Departman,p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama\r\nfrom Personeller p,Departmanlar d where p.DepartmanID=d.DepartmanID");
            lblToplamKayit.Text = "Toplam " + (dataGridView1.Rows.Count - 1) +" "+ "kayit listelendi";
            decimal toplammaas = 0;
            for(int i= 0; i< dataGridView1.Rows.Count -1; i++)
            {
                toplammaas += Decimal.Parse(dataGridView1.Rows[i].Cells["Maasi"].Value.ToString());
            }

            lblToplamMaas.Text = "Toplam maaş tutarı" +" "+ toplammaas.ToString("0.00") + " TL";
            
        }

        private void frmPersonelListele_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaDepartmanGetir(comboBoxDepartman);
            YenileListele();
        }

        void Temizle()
        {
            dateTimePickerGirisTarihi.Value = DateTime.Now;
            comboBoxDepartman.Text = "";
            foreach (Control item in Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            
            p.Adi = txtAdi.Text;
            p.Soyadi = txtSoyadi.Text;
            p.Telefon = txtTelefon.Text;
            p.DogumTarihi = dateTimePickerDogumTarihi.Value;
            p.Adres = txtAdres.Text;
            p.Email = txtEmail.Text;
            p.DepartmanID = (int)comboBoxDepartman.SelectedValue;
            p.Maasi = decimal.Parse(txtMaas.Text);
            p.GirisTarihi = dateTimePickerGirisTarihi.Value;
            p.Aciklama = txtAciklama.Text;

            byte[] resim =(byte[])dataGridView1.CurrentRow.Cells[0].Value;
            
            if (imagepath != null)
            {
                FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                resim = binaryReader.ReadBytes((int)fileStream.Length);
                binaryReader.Close();
                fileStream.Close();
            }

            string sorgu = "update personeller set adi='"+p.Adi+"',soyadi='"+p.Soyadi+"',dogumtarihi=@DogumTarihi,telefon='"+p.Telefon+"',adres='"+p.Adres+"',email='"+p.Email+"',departmanID='"+p.DepartmanID+"',maasi=@Maasi,giristarihi=@GirisTarihi,aciklama='"+p.Aciklama+"',resim=@images  " +
                "where adi ='"+adi+"' ";

            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@Maasi", SqlDbType.Decimal).Value = p.Maasi;
            komut.Parameters.Add("@GirisTarihi", SqlDbType.Date).Value = p.GirisTarihi;
            komut.Parameters.Add("@DogumTarihi", SqlDbType.Date).Value = p.DogumTarihi;
            komut.Parameters.Add("@images", SqlDbType.Image, resim.Length).Value = resim;

            Veritabani.ESG(komut,sorgu);
            Temizle();
            YenileListele();
            MessageBox.Show("İşlem başarılı.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.Adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //string sorgu = "delete from personeller where PersonelID='" + p.PersonelID + "'";
            //SqlCommand komut = new SqlCommand();
            //Veritabani.ESG(komut,sorgu);
            string sorgu2 = "update personeller set durumu='Pasif' where Adi='"+p.Adi+"'";
            SqlCommand komut2 = new SqlCommand();
            Veritabani.ESG(komut2, sorgu2);
            Temizle();
            YenileListele();
            MessageBox.Show("İşlem başarılı.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        string adi = "";

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboCinsiyet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBoxDepartman.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtMaas.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            dateTimePickerGirisTarihi.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[11].Value.ToString());
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();

            adi = txtAdi.Text;

            //Cokmesin diye boyle yaptim 5'ten fazla olunca null olmuyor 
            if (dataGridView1.CurrentRow.Cells[0].Value.ToString().Length > 5)
            {
                byte[] imgData = (byte[])dataGridView1.CurrentRow.Cells[0].Value;
                MemoryStream ms = new MemoryStream(imgData);
                pictureBox1.Image = System.Drawing.Image.FromStream(ms);
            } 

        }   

        private void txtPersonelAdıAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.Resim as Fotoğraf,p.Adi as Ad,p.Soyadi as Soyad,p.Cinsiyeti as Cinsiyet,DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END ) AS Yaş,p.Telefon,p.Adres,p.Email,\r\nd.Departman,p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama\r\nfrom Personeller p,Departmanlar d where p.DepartmanID=d.DepartmanID and Adi like '%" + txtPersonelAdiAra.Text + "%'");
        }

        private void txtPersonelSoyadiAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.Resim as Fotoğraf,p.Adi as Ad,p.Soyadi as Soyad,p.Cinsiyeti as Cinsiyet,DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END ) AS Yaş,p.Telefon,p.Adres,p.Email,\r\nd.Departman,p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama\r\nfrom Personeller p,Departmanlar d where p.DepartmanID=d.DepartmanID and Soyadi like '%" + txtPersonelSoyadiAra.Text + "%'");
        }

        private void txtPersonelTelefonAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.Resim as Fotoğraf,p.Adi as Ad,p.Soyadi as Soyad,p.Cinsiyeti as Cinsiyet,DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END ) AS Yaş,p.Telefon,p.Adres,p.Email,\r\nd.Departman,p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama\r\nfrom Personeller p,Departmanlar d where p.DepartmanID=d.DepartmanID and Telefon like '%" + txtPersonelTelefonAra.Text + "%'");
        }

        private void dateTimePickerG_Tarihi_ValueChanged(object sender, EventArgs e)
        {
            Personeller.TariheGoreAra(dateTimePickerG_Tarihi, dataGridView1);
        }

        private void txtCinsiyeteGoreAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.Resim as Fotoğraf,p.Adi as Ad,p.Soyadi as Soyad,p.Cinsiyeti as Cinsiyet,DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END ) AS Yaş,p.Telefon,p.Adres,p.Email,\r\nd.Departman,p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama\r\nfrom Personeller p,Departmanlar d where p.DepartmanID=d.DepartmanID and Cinsiyeti like '%" + txtCinsiyeteGoreAra.Text + "%'");
        }

        string yas = "";

        private void txtYasaGoreAra_TextChanged(object sender, EventArgs e)
        {
            if(txtYasaGoreAra.Text != "")
            {
                yas = (DateTime.Now.Year - int.Parse(txtYasaGoreAra.Text.ToString())).ToString();
                Veritabani.Listele_Ara(dataGridView1, "select p.Resim as Fotoğraf,p.Adi as Ad,p.Soyadi as Soyad,p.Cinsiyeti as Cinsiyet,DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END ) AS Yaş,p.Telefon,p.Adres,p.Email,\r\nd.Departman,p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama\r\nfrom Personeller p,Departmanlar d where p.DepartmanID=d.DepartmanID and DogumTarihi like '%" + yas + "%'");
            }
            else
            {
                YenileListele();
            }         
        }
        string imagepath;
        private void btnFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Jpeg Dosyaları(*,jpeg)|*.jpeg| Jpg Dosyaları(*,jpg)|*.jpg| Png Dosyaları(*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                byte[] imageByte = (byte[])row.Cells[0].Value;

                iTextSharp.text.Image myImage = iTextSharp.text.Image.GetInstance(imageByte);

                pdfTable.AddCell(myImage);       

                string ad = row.Cells[1].Value.ToString();
                pdfTable.AddCell(ad);

                string soyad = row.Cells[2].Value.ToString();
                pdfTable.AddCell(soyad);

                string cinsiyet = row.Cells[3].Value.ToString();
                pdfTable.AddCell(cinsiyet);

                string yas = row.Cells[4].Value.ToString();
                pdfTable.AddCell(yas);

                string telefon = row.Cells[5].Value.ToString();
                pdfTable.AddCell(telefon);

                string adres = row.Cells[6].Value.ToString();
                pdfTable.AddCell(adres);

                string email = row.Cells[7].Value.ToString();
                pdfTable.AddCell(email);

                string departman = row.Cells[8].Value.ToString();
                pdfTable.AddCell(departman);

                string durumu = row.Cells[9].Value.ToString();
                pdfTable.AddCell(durumu);

                string maasi = row.Cells[10].Value.ToString();
                pdfTable.AddCell(maasi);

                string giristarihi = row.Cells[11].Value.ToString();
                pdfTable.AddCell(giristarihi);

                string aciklama = row.Cells[12].Value.ToString();
                pdfTable.AddCell(aciklama);


                
            }

            //Exporting to PDF.
            string folderPath = @"D:\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "DataGridViewImageExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A3, 10f, 10f, 10f, 10f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }

            MessageBox.Show("PDF Başarıyla aktarıldı");
        }
    }
}
