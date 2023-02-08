using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Reflection.Emit;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;

namespace BERKAYDENIZPersonelTakipOtomasyonu
{
    public partial class frmGrafik : Form
    {
        public frmGrafik()
        {
            InitializeComponent();
        }

        void FillChart()
        {
            
            Veritabani.baglanti.Open();

            int toplamErkek = 0;
            int toplamKadin = 0;

            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand myCommand2 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE Cinsiyeti = 'Kadin' ", Veritabani.baglanti);
            
            myReader = myCommand.ExecuteReader();
            
            while (myReader.Read())
            {
                toplamErkek = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            chart1.Series["Maaş"].Points.AddXY("Erkek", toplamErkek);

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            myReader = myCommand2.ExecuteReader();

            while (myReader.Read())
            {
                toplamKadin = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            chart1.Series["Maaş"].Points.AddXY("Kadın", toplamKadin);

            chart1.Titles.Add("Maaş Cinsiyet");
            Veritabani.baglanti.Close();

        }

        private void frmGrafik_Load(object sender, EventArgs e)
        {
            FillChart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = true;
            chart1.Series["Yaş Ortalaması"].Enabled = false;
            chart1.Series["Kişi Sayısı"].Enabled = false;
            chart1.Series["Maaş Ortalaması"].Enabled = false;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            FillChart();         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = true;
            chart1.Series["Yaş Ortalaması"].Enabled = false;
            chart1.Series["Kişi Sayısı"].Enabled = false;
            chart1.Series["Maaş Ortalaması"].Enabled = false;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            Veritabani.baglanti.Open();

            int toplam20_30 = 0;
            int toplam30_50 = 0;
            int toplam50 = 0;

            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DogumTarihi BETWEEN '1992/01/01' AND '2002/01/01' ", Veritabani.baglanti);
            SqlCommand myCommand2 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DogumTarihi BETWEEN '1972/01/01' AND '1992/01/01' ", Veritabani.baglanti);
            SqlCommand myCommand3 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DogumTarihi BETWEEN '1910/01/01' AND '1972/01/01' ", Veritabani.baglanti);

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                toplam20_30 = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            chart1.Series["Maaş"].Points.AddXY("20-30 Yaş arası", toplam20_30);

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            myReader = myCommand2.ExecuteReader();

            while (myReader.Read())
            {
                toplam30_50 = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            chart1.Series["Maaş"].Points.AddXY("30-50 Yaş arası", toplam30_50);

            
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            myReader = myCommand3.ExecuteReader();

            while (myReader.Read())
            {
                toplam50 = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            chart1.Series["Maaş"].Points.AddXY("50+", toplam50);

            chart1.Titles.Add("Maaş Yaş");
            Veritabani.baglanti.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = true;
            chart1.Series["Yaş Ortalaması"].Enabled = false;
            chart1.Series["Kişi Sayısı"].Enabled = false;
            chart1.Series["Maaş Ortalaması"].Enabled = false;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;


            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            Veritabani.baglanti.Open();

            int toplamYonetim = 0;
            int toplamBilisim = 0;
            int toplamIhracat = 0;
            int toplamInsanKaynaklari = 0;
            int toplamUretim = 0;
            int toplamArge = 0;
            int toplamMuhasebe = 0;

            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DepartmanID = '1' ", Veritabani.baglanti);
            SqlCommand myCommand2 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DepartmanID = '2' ", Veritabani.baglanti);
            SqlCommand myCommand3 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DepartmanID = '3' ", Veritabani.baglanti);
            SqlCommand myCommand4 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DepartmanID = '4' ", Veritabani.baglanti);
            SqlCommand myCommand5 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DepartmanID = '5' ", Veritabani.baglanti);
            SqlCommand myCommand6 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DepartmanID = '6' ", Veritabani.baglanti);
            SqlCommand myCommand7 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DepartmanID = '7' ", Veritabani.baglanti);

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                toplamYonetim = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            chart1.Series["Maaş"].Points.AddXY("Yonetim", toplamYonetim);

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            myReader = myCommand2.ExecuteReader();

            while (myReader.Read())
            {
                toplamBilisim = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            chart1.Series["Maaş"].Points.AddXY("Bilişim", toplamBilisim);


            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            myReader = myCommand3.ExecuteReader();

            while (myReader.Read())
            {
                toplamIhracat = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            chart1.Series["Maaş"].Points.AddXY("İhracat", toplamIhracat);

            
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            myReader = myCommand4.ExecuteReader();

            while (myReader.Read())
            {
                toplamInsanKaynaklari = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            chart1.Series["Maaş"].Points.AddXY("İK", toplamInsanKaynaklari);

            
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            myReader = myCommand5.ExecuteReader();

            while (myReader.Read())
            {
                toplamUretim = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            chart1.Series["Maaş"].Points.AddXY("Üretim", toplamUretim);

            
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            myReader = myCommand6.ExecuteReader();

            while (myReader.Read())
            {
                toplamArge = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            chart1.Series["Maaş"].Points.AddXY("Ar-ge", toplamArge);

            
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            myReader = myCommand7.ExecuteReader();

            while (myReader.Read())
            {
                toplamMuhasebe = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            chart1.Series["Maaş"].Points.AddXY("Muhasebe", toplamMuhasebe);

            chart1.Titles.Add("Maaş Departman");
            Veritabani.baglanti.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = false;
            chart1.Series["Yaş Ortalaması"].Enabled = true;
            chart1.Series["Kişi Sayısı"].Enabled = false;
            chart1.Series["Maaş Ortalaması"].Enabled = false;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            Veritabani.baglanti.Open();

            int toplamYonetim = 0;
            int toplamBilisim = 0;
            int toplamIhracat = 0;
            int toplamInsanKaynaklari = 0;
            int toplamUretim = 0;
            int toplamArge = 0;
            int toplamMuhasebe = 0;

            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT SUM(DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END )) as ToplamMaas FROM Personeller WHERE DepartmanID = '1' ", Veritabani.baglanti);
            SqlCommand count = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '1' ", Veritabani.baglanti);
            SqlCommand myCommand2 = new SqlCommand("SELECT SUM(DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END )) as ToplamMaas FROM Personeller WHERE DepartmanID = '2' ", Veritabani.baglanti);
            SqlCommand count2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '2' ", Veritabani.baglanti);
            SqlCommand myCommand3 = new SqlCommand("SELECT SUM(DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END )) as ToplamMaas FROM Personeller WHERE DepartmanID = '3' ", Veritabani.baglanti);
            SqlCommand count3 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '3' ", Veritabani.baglanti);
            SqlCommand myCommand4 = new SqlCommand("SELECT SUM(DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END )) as ToplamMaas FROM Personeller WHERE DepartmanID = '4' ", Veritabani.baglanti);
            SqlCommand count4 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '4' ", Veritabani.baglanti);
            SqlCommand myCommand5 = new SqlCommand("SELECT SUM(DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END )) as ToplamMaas FROM Personeller WHERE DepartmanID = '5' ", Veritabani.baglanti);
            SqlCommand count5 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '5' ", Veritabani.baglanti);
            SqlCommand myCommand6 = new SqlCommand("SELECT SUM(DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END )) as ToplamMaas FROM Personeller WHERE DepartmanID = '6' ", Veritabani.baglanti);
            SqlCommand count6 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '6' ", Veritabani.baglanti);
            SqlCommand myCommand7 = new SqlCommand("SELECT SUM(DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END )) as ToplamMaas FROM Personeller WHERE DepartmanID = '7' ", Veritabani.baglanti);
            SqlCommand count7 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '7' ", Veritabani.baglanti);
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                toplamYonetim += Convert.ToInt32(myReader["ToplamMaas"]);
                
            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count11 = (Int32)count.ExecuteScalar();

            chart1.Series["Yaş Ortalaması"].Points.AddXY("Yonetim", toplamYonetim/count11);

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            myReader = myCommand2.ExecuteReader();

            while (myReader.Read())
            {
                toplamBilisim = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count22 = (Int32)count2.ExecuteScalar();

            chart1.Series["Yaş Ortalaması"].Points.AddXY("Bilişim", toplamBilisim/count22);


            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            myReader = myCommand3.ExecuteReader();

            while (myReader.Read())
            {
                toplamIhracat = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count33 = (Int32)count3.ExecuteScalar();

            chart1.Series["Yaş Ortalaması"].Points.AddXY("İhracat", toplamIhracat/count33);


            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            myReader = myCommand4.ExecuteReader();

            while (myReader.Read())
            {
                toplamInsanKaynaklari = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count44 = (Int32)count4.ExecuteScalar();

            chart1.Series["Yaş Ortalaması"].Points.AddXY("İK", toplamInsanKaynaklari/count44);


            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            myReader = myCommand5.ExecuteReader();

            while (myReader.Read())
            {
                toplamUretim = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count55 = (Int32)count5.ExecuteScalar();

            chart1.Series["Yaş Ortalaması"].Points.AddXY("Üretim", toplamUretim/count55);


            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            myReader = myCommand6.ExecuteReader();

            while (myReader.Read())
            {
                toplamArge = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count66 = (Int32)count6.ExecuteScalar();

            chart1.Series["Yaş Ortalaması"].Points.AddXY("Ar-ge", toplamArge/count66);


            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            myReader = myCommand7.ExecuteReader();

            while (myReader.Read())
            {
                toplamMuhasebe = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count77 = (Int32)count7.ExecuteScalar();

            chart1.Series["Yaş Ortalaması"].Points.AddXY("Muhasebe", toplamMuhasebe/count77);

            chart1.Titles.Add("Yaş Ortalaması Departman");
            Veritabani.baglanti.Close();

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = false;
            chart1.Series["Yaş Ortalaması"].Enabled = true;
            chart1.Series["Kişi Sayısı"].Enabled = false;
            chart1.Series["Maaş Ortalaması"].Enabled = false;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            Veritabani.baglanti.Open();

            int toplamErkek = 0;
            int toplamKadin = 0;

            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT SUM(DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END )) as ToplamYas FROM Personeller WHERE Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand count = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand myCommand2 = new SqlCommand("SELECT SUM(DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END )) as ToplamYas FROM Personeller WHERE Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand count2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Cinsiyeti = 'Kadın' ", Veritabani.baglanti);

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                toplamErkek += Convert.ToInt32(myReader["ToplamYas"]);

            }
            
            

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count11 = (Int32)count.ExecuteScalar();

            

            chart1.Series["Yaş Ortalaması"].Points.AddXY("Erkek", toplamErkek / count11);

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            myReader = myCommand2.ExecuteReader();

            while (myReader.Read())
            {
                toplamKadin = Convert.ToInt32(myReader["ToplamYas"]);

            }

            

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count22 = (Int32)count2.ExecuteScalar();

            

            chart1.Series["Yaş Ortalaması"].Points.AddXY("Kadın", toplamKadin / count22);

            chart1.Titles.Add("Yaş Ortalaması Cinsiyet");
            Veritabani.baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = true;
            chart1.Series["Yaş Ortalaması"].Enabled = false;
            chart1.Series["Kişi Sayısı"].Enabled = false;
            chart1.Series["Maaş Ortalaması"].Enabled = false;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;


            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            Veritabani.baglanti.Open();

            int toplamIstanbul = 0;
            int toplamAnkara = 0;

            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE Adres like '%Istanbul%' ", Veritabani.baglanti);
            SqlCommand myCommand2 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE Adres like '%Ankara%' ", Veritabani.baglanti);

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                toplamIstanbul = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            chart1.Series["Maaş"].Points.AddXY("İstanbul", toplamIstanbul);

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            myReader = myCommand2.ExecuteReader();

            while (myReader.Read())
            {
                toplamAnkara = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            chart1.Series["Maaş"].Points.AddXY("Ankara", toplamAnkara);

            chart1.Titles.Add("Maaş İl");
            Veritabani.baglanti.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = false;
            chart1.Series["Yaş Ortalaması"].Enabled = false;
            chart1.Series["Kişi Sayısı"].Enabled = true;
            chart1.Series["Maaş Ortalaması"].Enabled = false;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }


            SqlCommand count = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Maasi BETWEEN '5500' AND '10000' ", Veritabani.baglanti);
            SqlCommand count2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Maasi BETWEEN '10000' AND '20000' ", Veritabani.baglanti);
            SqlCommand count3 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Maasi BETWEEN '20000' AND '100000' ", Veritabani.baglanti);

            
            Veritabani.baglanti.Open();

            Int32 count11 = (Int32)count.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("Asgari Ucret - 10K", count11);

            Veritabani.baglanti.Close();
             
            Veritabani.baglanti.Open();

            Int32 count22 = (Int32)count2.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("10K - 20K",count22);


            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 count33 = (Int32)count3.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("20k+",count33);


            chart1.Titles.Add("Kişi Sayısı Maaş Aralığı");
            Veritabani.baglanti.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = false;
            chart1.Series["Yaş Ortalaması"].Enabled = false;
            chart1.Series["Kişi Sayısı"].Enabled = true;
            chart1.Series["Maaş Ortalaması"].Enabled = false;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }


            SqlCommand count = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DogumTarihi BETWEEN '1992/01/01' AND '2002/01/01' ", Veritabani.baglanti);
            SqlCommand count2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DogumTarihi BETWEEN '1972/01/01' AND '1992/01/01' ", Veritabani.baglanti);
            SqlCommand count3 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DogumTarihi BETWEEN '1910/01/01' AND '1972/01/01' ", Veritabani.baglanti);


            Veritabani.baglanti.Open();

            Int32 count11 = (Int32)count.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("20-30 Yaş arası", count11);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 count22 = (Int32)count2.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("30-50 Yaş arası", count22);


            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 count33 = (Int32)count3.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("50+", count33);


            chart1.Titles.Add("Kişi Sayısı Yaş");
            Veritabani.baglanti.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = false;
            chart1.Series["Yaş Ortalaması"].Enabled = false;
            chart1.Series["Kişi Sayısı"].Enabled = true;
            chart1.Series["Maaş Ortalaması"].Enabled = false;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }


            SqlCommand count = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '1' ", Veritabani.baglanti);
            SqlCommand count2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '2' ", Veritabani.baglanti);
            SqlCommand count3 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '3' ", Veritabani.baglanti);
            SqlCommand count4 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '4' ", Veritabani.baglanti);
            SqlCommand count5 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '5' ", Veritabani.baglanti);
            SqlCommand count6 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '6' ", Veritabani.baglanti);
            SqlCommand count7 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '7' ", Veritabani.baglanti);


            Veritabani.baglanti.Open();

            Int32 count11 = (Int32)count.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("Yönetim", count11);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 count22 = (Int32)count2.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("Bilişim", count22);


            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 count33 = (Int32)count3.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("İhracat", count33);


            
            Veritabani.baglanti.Close();


            Veritabani.baglanti.Open();

            Int32 count44 = (Int32)count4.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("İnsan Kaynakları", count44);


            
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 count55 = (Int32)count5.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("Üretim", count55);


            
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 count66 = (Int32)count6.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("AR-GE", count66);

 
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 count77 = (Int32)count7.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("Muhasebe", count77);


            chart1.Titles.Add("Kişi Sayısı Departman");
            Veritabani.baglanti.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = false;
            chart1.Series["Yaş Ortalaması"].Enabled = false;
            chart1.Series["Kişi Sayısı"].Enabled = true;
            chart1.Series["Maaş Ortalaması"].Enabled = false;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }


            SqlCommand count = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Adres like '%Istanbul%' ", Veritabani.baglanti);
            SqlCommand count2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Adres like '%Ankara%' ", Veritabani.baglanti);
            

            Veritabani.baglanti.Open();

            Int32 count11 = (Int32)count.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("Istanbul", count11);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 count22 = (Int32)count2.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("Ankara", count22);

            chart1.Titles.Add("Kişi Sayısı İl");
            Veritabani.baglanti.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = false;
            chart1.Series["Yaş Ortalaması"].Enabled = false;
            chart1.Series["Kişi Sayısı"].Enabled = true;
            chart1.Series["Maaş Ortalaması"].Enabled = false;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }


            SqlCommand count = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand count2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Cinsiyeti = 'Kadın' ", Veritabani.baglanti);


            Veritabani.baglanti.Open();

            Int32 count11 = (Int32)count.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("Erkek", count11);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 count22 = (Int32)count2.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("Kadın", count22);

            chart1.Titles.Add("Kişi Sayısı Cinsiyet");
            Veritabani.baglanti.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = false;
            chart1.Series["Yaş Ortalaması"].Enabled = true;
            chart1.Series["Kişi Sayısı"].Enabled = false;
            chart1.Series["Maaş Ortalaması"].Enabled = false;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            Veritabani.baglanti.Open();

            int toplamIstanbul = 0;
            int toplamAnkara = 0;

            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT SUM(DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END )) as ToplamYas FROM Personeller WHERE Adres like '%Istanbul%' ", Veritabani.baglanti);
            SqlCommand count = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Adres like '%Istanbul%' ", Veritabani.baglanti);
            SqlCommand myCommand2 = new SqlCommand("SELECT SUM(DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END )) as ToplamYas FROM Personeller WHERE Adres like '%Ankara%' ", Veritabani.baglanti);
            SqlCommand count2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Adres like '%Ankara%' ", Veritabani.baglanti);

            

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                toplamIstanbul += Convert.ToInt32(myReader["ToplamYas"]);

            }


            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count11 = (Int32)count.ExecuteScalar();


            chart1.Series["Yaş Ortalaması"].Points.AddXY("Istanbul", toplamIstanbul / count11);

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            myReader = myCommand2.ExecuteReader();

            while (myReader.Read())
            {
                toplamAnkara = Convert.ToInt32(myReader["ToplamYas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count22 = (Int32)count2.ExecuteScalar();

            chart1.Series["Yaş Ortalaması"].Points.AddXY("Ankara", toplamAnkara / count22);

            chart1.Titles.Add("Yaş Ortalaması İl");
            Veritabani.baglanti.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = false;
            chart1.Series["Yaş Ortalaması"].Enabled = false;
            chart1.Series["Kişi Sayısı"].Enabled = false;
            chart1.Series["Maaş Ortalaması"].Enabled = true;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            Veritabani.baglanti.Open();

            int toplam20_30 = 0;
            int toplam30_50 = 0;
            int toplam50ustu = 0;

            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DogumTarihi BETWEEN '1992/01/01' AND '2002/01/01' ", Veritabani.baglanti);
            SqlCommand count = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DogumTarihi BETWEEN '1992/01/01' AND '2002/01/01' ", Veritabani.baglanti);
            SqlCommand myCommand2 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DogumTarihi BETWEEN '1972/01/01' AND '1992/01/01' ", Veritabani.baglanti);
            SqlCommand count2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DogumTarihi BETWEEN '1972/01/01' AND '1992/01/01' ", Veritabani.baglanti);
            SqlCommand myCommand3 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DogumTarihi BETWEEN '1910/01/01' AND '1972/01/01' ", Veritabani.baglanti);
            SqlCommand count3 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DogumTarihi BETWEEN '1910/01/01' AND '1972/01/01' ", Veritabani.baglanti);

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                toplam20_30 += Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count11 = (Int32)count.ExecuteScalar();


            chart1.Series["Maaş Ortalaması"].Points.AddXY("20-30 Yaş arası", toplam20_30 / count11);

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            myReader = myCommand2.ExecuteReader();

            while (myReader.Read())
            {
                toplam30_50 = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count22 = (Int32)count2.ExecuteScalar();

            chart1.Series["Maaş Ortalaması"].Points.AddXY("30-50 Yaş arası", toplam30_50 / count22);

            
            Veritabani.baglanti.Close();
            
            Veritabani.baglanti.Open();

            myReader = myCommand3.ExecuteReader();

            while (myReader.Read())
            {
                toplam50ustu = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count33 = (Int32)count3.ExecuteScalar();

            chart1.Series["Maaş Ortalaması"].Points.AddXY("50+", toplam50ustu / count33);

            chart1.Titles.Add("Maaş Ortalaması Yaş");
            Veritabani.baglanti.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = false;
            chart1.Series["Yaş Ortalaması"].Enabled = true;
            chart1.Series["Kişi Sayısı"].Enabled = false;
            chart1.Series["Maaş Ortalaması"].Enabled = false;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            Veritabani.baglanti.Open();

            int toplam5500_10000 = 0;
            int toplam10000_20000 = 0;
            int toplam20000_100000 = 0;

            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT SUM(DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END )) as ToplamYas FROM Personeller WHERE Maasi BETWEEN '5500' AND '10000' ", Veritabani.baglanti);
            SqlCommand count = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Maasi BETWEEN '5500' AND '10000' ", Veritabani.baglanti);
            SqlCommand myCommand2 = new SqlCommand("SELECT SUM(DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END )) as ToplamYas FROM Personeller WHERE Maasi BETWEEN '10000' AND '20000' ", Veritabani.baglanti);
            SqlCommand count2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Maasi BETWEEN '10000' AND '20000' ", Veritabani.baglanti);
            SqlCommand myCommand3 = new SqlCommand("SELECT SUM(DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END )) as ToplamYas FROM Personeller WHERE Maasi BETWEEN '20000' AND '100000' ", Veritabani.baglanti);
            SqlCommand count3 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Maasi BETWEEN '20000' AND '100000' ", Veritabani.baglanti);

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                toplam5500_10000 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count11 = (Int32)count.ExecuteScalar();

            chart1.Series["Yaş Ortalaması"].Points.AddXY("Asgari ücret - 10K", toplam5500_10000 / count11);

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            myReader = myCommand2.ExecuteReader();

            while (myReader.Read())
            {
                toplam10000_20000 = Convert.ToInt32(myReader["ToplamYas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count22 = (Int32)count2.ExecuteScalar();

            chart1.Series["Yaş Ortalaması"].Points.AddXY("10K-20K", toplam10000_20000 / count22);

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            myReader = myCommand3.ExecuteReader();

            while (myReader.Read())
            {
                toplam20000_100000 = Convert.ToInt32(myReader["ToplamYas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count33 = (Int32)count3.ExecuteScalar();

            chart1.Series["Yaş Ortalaması"].Points.AddXY("20K+", toplam20000_100000 / count33);

            chart1.Titles.Add("Yaş Ortalaması Maaş Aralığı");
            Veritabani.baglanti.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = false;
            chart1.Series["Yaş Ortalaması"].Enabled = false;
            chart1.Series["Kişi Sayısı"].Enabled = false;
            chart1.Series["Maaş Ortalaması"].Enabled = true;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            Veritabani.baglanti.Open();

            int toplamIstanbul = 0;
            int toplamAnkara = 0;
            
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DogumTarihi BETWEEN '1992/01/01' AND '2002/01/01' ", Veritabani.baglanti);
            SqlCommand count = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Adres like '%Istanbul%' ", Veritabani.baglanti);
            SqlCommand myCommand2 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DogumTarihi BETWEEN '1972/01/01' AND '1992/01/01' ", Veritabani.baglanti);
            SqlCommand count2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Adres like '%Ankara%' ", Veritabani.baglanti);

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                toplamIstanbul += Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count11 = (Int32)count.ExecuteScalar();


            chart1.Series["Maaş Ortalaması"].Points.AddXY("Istanbul", toplamIstanbul / count11);

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            myReader = myCommand2.ExecuteReader();

            while (myReader.Read())
            {
                toplamAnkara = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count22 = (Int32)count2.ExecuteScalar();

            chart1.Series["Maaş Ortalaması"].Points.AddXY("Ankara", toplamAnkara / count22);


            Veritabani.baglanti.Close();
   
            chart1.Titles.Add("Maaş Ortalaması İl");         
        }

        private void button16_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = false;
            chart1.Series["Yaş Ortalaması"].Enabled = false;
            chart1.Series["Kişi Sayısı"].Enabled = false;
            chart1.Series["Maaş Ortalaması"].Enabled = true;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            Veritabani.baglanti.Open();

            int toplamErkek = 0;
            int toplamKadin = 0;

            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand count = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand myCommand2 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand count2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE Cinsiyeti = 'Kadın' ", Veritabani.baglanti);

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                toplamErkek += Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count11 = (Int32)count.ExecuteScalar();


            chart1.Series["Maaş Ortalaması"].Points.AddXY("Erkek", toplamErkek / count11);

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            myReader = myCommand2.ExecuteReader();

            while (myReader.Read())
            {
                toplamKadin = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count22 = (Int32)count2.ExecuteScalar();

            chart1.Series["Maaş Ortalaması"].Points.AddXY("Kadın", toplamKadin / count22);


            Veritabani.baglanti.Close();

            chart1.Titles.Add("Maaş Ortalaması Cinsiyet");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = false;
            chart1.Series["Yaş Ortalaması"].Enabled = false;
            chart1.Series["Kişi Sayısı"].Enabled = false;
            chart1.Series["Maaş Ortalaması"].Enabled = true;
            chart1.Series["Erkek"].Enabled = false;
            chart1.Series["Kadın"].Enabled = false;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            Veritabani.baglanti.Open();

            int toplamYonetim = 0;
            int toplamBilisim = 0;
            int toplamIhracat = 0;
            int toplamInsanKaynaklari = 0;
            int toplamUretim = 0;
            int toplamARGE = 0;
            int toplamMuhasebe = 0;

            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DepartmanID = '1' ", Veritabani.baglanti);
            SqlCommand count = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '1' ", Veritabani.baglanti);
            SqlCommand myCommand2 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DepartmanID = '2' ", Veritabani.baglanti);
            SqlCommand count2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '2' ", Veritabani.baglanti);
            SqlCommand myCommand3 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DepartmanID = '3' ", Veritabani.baglanti);
            SqlCommand count3 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '3' ", Veritabani.baglanti);
            SqlCommand myCommand4 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DepartmanID = '4' ", Veritabani.baglanti);
            SqlCommand count4 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '4' ", Veritabani.baglanti);
            SqlCommand myCommand5 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DepartmanID = '5' ", Veritabani.baglanti);
            SqlCommand count5 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '5' ", Veritabani.baglanti);
            SqlCommand myCommand6 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DepartmanID = '6' ", Veritabani.baglanti);
            SqlCommand count6 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '6' ", Veritabani.baglanti);
            SqlCommand myCommand7 = new SqlCommand("SELECT SUM (Maasi) as ToplamMaas FROM Personeller WHERE DepartmanID = '7' ", Veritabani.baglanti);
            SqlCommand count7 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '7' ", Veritabani.baglanti);

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                toplamYonetim += Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count11 = (Int32)count.ExecuteScalar();


            chart1.Series["Maaş Ortalaması"].Points.AddXY("Yönetim", toplamYonetim / count11);

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            myReader = myCommand2.ExecuteReader();

            while (myReader.Read())
            {
                toplamBilisim = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count22 = (Int32)count2.ExecuteScalar();

            chart1.Series["Maaş Ortalaması"].Points.AddXY("Bilişim", toplamBilisim / count22);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            myReader = myCommand3.ExecuteReader();

            while (myReader.Read())
            {
                toplamIhracat= Convert.ToInt32(myReader["ToplamMaas"]);
            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count33 = (Int32)count3.ExecuteScalar();

            chart1.Series["Maaş Ortalaması"].Points.AddXY("İhracat", toplamIhracat / count33);

            Veritabani.baglanti.Close();


            Veritabani.baglanti.Open();

            myReader = myCommand6.ExecuteReader();

            while (myReader.Read())
            {
                toplamInsanKaynaklari = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count44 = (Int32)count4.ExecuteScalar();

            chart1.Series["Maaş Ortalaması"].Points.AddXY("IK", toplamInsanKaynaklari / count44);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            myReader = myCommand5.ExecuteReader();

            while (myReader.Read())
            {
                toplamUretim = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count55 = (Int32)count5.ExecuteScalar();

            chart1.Series["Maaş Ortalaması"].Points.AddXY("Üretim", toplamUretim / count55);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            myReader = myCommand6.ExecuteReader();

            while (myReader.Read())
            {
                toplamARGE = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count66 = (Int32)count6.ExecuteScalar();

            chart1.Series["Maaş Ortalaması"].Points.AddXY("AR-GE", toplamARGE / count66);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            myReader = myCommand7.ExecuteReader();

            while (myReader.Read())
            {
                toplamMuhasebe = Convert.ToInt32(myReader["ToplamMaas"]);

            }

            Veritabani.baglanti.Close();
            Veritabani.baglanti.Open();

            Int32 count77 = (Int32)count7.ExecuteScalar();

            chart1.Series["Maaş Ortalaması"].Points.AddXY("Muhasebe", toplamMuhasebe / count77);

            Veritabani.baglanti.Close();

            chart1.Titles.Add("Maaş Ortalaması Departman");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = false;
            chart1.Series["Yaş Ortalaması"].Enabled = false;
            chart1.Series["Kişi Sayısı"].Enabled = true;
            chart1.Series["Maaş Ortalaması"].Enabled = false;
            chart1.Series["Erkek"].Enabled = true;
            chart1.Series["Kadın"].Enabled = true;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }


            SqlCommand count = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '1' ", Veritabani.baglanti);
            SqlCommand count2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '2' ", Veritabani.baglanti);
            SqlCommand count3 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '3' ", Veritabani.baglanti);
            SqlCommand count4 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '4' ", Veritabani.baglanti);
            SqlCommand count5 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '5' ", Veritabani.baglanti);
            SqlCommand count6 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '6' ", Veritabani.baglanti);
            SqlCommand count7 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '7' ", Veritabani.baglanti);

            SqlCommand erkekcount = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '1' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcount2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '2' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcount3 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '3' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcount4 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '4' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcount5 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '5' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcount6 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '6' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcount7 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '7' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);

            SqlCommand kadincount = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '1' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincount2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '2' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincount3 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '3' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincount4 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '4' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincount5 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '5' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincount6 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '6' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincount7 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '7' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);


            Veritabani.baglanti.Open();

            Int32 count11 = (Int32)count.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("Yönetim", count11);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 counterkek = (Int32)erkekcount.ExecuteScalar();

            chart1.Series["Erkek"].Points.AddXY("Yönetim", counterkek);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 countkadin = (Int32)kadincount.ExecuteScalar();

            chart1.Series["Kadın"].Points.AddXY("Yönetim", countkadin);

            Veritabani.baglanti.Close();


            Veritabani.baglanti.Open();

            Int32 count22 = (Int32)count2.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("Bilişim", count22);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 counterkek2 = (Int32)erkekcount2.ExecuteScalar();

            chart1.Series["Erkek"].Points.AddXY("Bilişim", counterkek2);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 countkadin2 = (Int32)kadincount2.ExecuteScalar();

            chart1.Series["Kadın"].Points.AddXY("Bilişim", countkadin2);

            Veritabani.baglanti.Close();


            Veritabani.baglanti.Open();

            Int32 count33 = (Int32)count3.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("İhracat", count33);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 counterkek3 = (Int32)erkekcount3.ExecuteScalar();

            chart1.Series["Erkek"].Points.AddXY("İhracat", counterkek3);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 countkadin3 = (Int32)kadincount3.ExecuteScalar();

            chart1.Series["Kadın"].Points.AddXY("İhracat", countkadin3);

            Veritabani.baglanti.Close();


            Veritabani.baglanti.Open();

            Int32 count44 = (Int32)count4.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("IK", count44);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 counterkek4 = (Int32)erkekcount4.ExecuteScalar();

            chart1.Series["Erkek"].Points.AddXY("IK", counterkek4);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 countkadin4 = (Int32)kadincount4.ExecuteScalar();

            chart1.Series["Kadın"].Points.AddXY("IK", countkadin4);

            Veritabani.baglanti.Close();


            Veritabani.baglanti.Open();

            Int32 count55 = (Int32)count5.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("Üretim", count55);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 counterkek5 = (Int32)erkekcount5.ExecuteScalar();

            chart1.Series["Erkek"].Points.AddXY("Üretim", counterkek5);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 countkadin5 = (Int32)kadincount5.ExecuteScalar();

            chart1.Series["Kadın"].Points.AddXY("Üretim", countkadin5);

            Veritabani.baglanti.Close();


            Veritabani.baglanti.Open();

            Int32 count66 = (Int32)count6.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("AR-GE", count66);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 counterkek6 = (Int32)erkekcount6.ExecuteScalar();

            chart1.Series["Erkek"].Points.AddXY("AR-GE", counterkek6);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 countkadin6 = (Int32)kadincount6.ExecuteScalar();

            chart1.Series["Kadın"].Points.AddXY("AR-GE", countkadin6);

            Veritabani.baglanti.Close();


            Veritabani.baglanti.Open();

            Int32 count77 = (Int32)count7.ExecuteScalar();

            chart1.Series["Kişi Sayısı"].Points.AddXY("Muhasebe", count77);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 counterkek7 = (Int32)erkekcount7.ExecuteScalar();

            chart1.Series["Erkek"].Points.AddXY("Muhasebe", counterkek7);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            Int32 countkadin7 = (Int32)kadincount7.ExecuteScalar();

            chart1.Series["Kadın"].Points.AddXY("Muhasebe", countkadin7);

            Veritabani.baglanti.Close();


            chart1.Titles.Add("Departman - Kişi Sayısı,Cinsiyet");
            Veritabani.baglanti.Close();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Series["Maaş"].Enabled = false;
            chart1.Series["Yaş Ortalaması"].Enabled = false;
            chart1.Series["Kişi Sayısı"].Enabled = true;
            chart1.Series["Maaş Ortalaması"].Enabled = false;
            chart1.Series["Erkek"].Enabled = true;
            chart1.Series["Kadın"].Enabled = true;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            SqlDataReader myReader = null;

            SqlCommand count = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '1' ", Veritabani.baglanti);
            SqlCommand count2 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '2' ", Veritabani.baglanti);
            SqlCommand count3 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '3' ", Veritabani.baglanti);
            SqlCommand count4 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '4' ", Veritabani.baglanti);
            SqlCommand count5 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '5' ", Veritabani.baglanti);
            SqlCommand count6 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '6' ", Veritabani.baglanti);
            SqlCommand count7 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '7' ", Veritabani.baglanti);

            SqlCommand erkekcount = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '1' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcount2 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '2' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcount3 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '3' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcount4 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '4' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcount5 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '5' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcount6 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '6' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcount7 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '7' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);

            SqlCommand kadincount = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '1' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincount2 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '2' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincount3 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '3' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincount4 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '4' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincount5 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '5' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincount6 = new SqlCommand("SELECT SUM (Maasi) as ToplamYas FROM Personeller WHERE DepartmanID = '6' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincount7 = new SqlCommand("SELECT SUM (Maasi)  as ToplamYas FROM Personeller WHERE DepartmanID = '7' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);


            SqlCommand countSayi = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '1' ", Veritabani.baglanti);
            SqlCommand countSayi2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '2' ", Veritabani.baglanti);
            SqlCommand countSayi3 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '3' ", Veritabani.baglanti);
            SqlCommand countSayi4 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '4' ", Veritabani.baglanti);
            SqlCommand countSayi5 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '5' ", Veritabani.baglanti);
            SqlCommand countSayi6 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '6' ", Veritabani.baglanti);
            SqlCommand countSayi7 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '7' ", Veritabani.baglanti);

            SqlCommand erkekcountSayi = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '1' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcountSayi2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '2' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcountSayi3 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '3' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcountSayi4 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '4' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcountSayi5 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '5' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcountSayi6 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '6' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);
            SqlCommand erkekcountSayi7 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '7' AND Cinsiyeti = 'Erkek' ", Veritabani.baglanti);

            SqlCommand kadincountSayi = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '1' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincountSayi2 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '2' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincountSayi3 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '3' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincountSayi4 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '4' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincountSayi5 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '5' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincountSayi6 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '6' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);
            SqlCommand kadincountSayi7 = new SqlCommand("SELECT COUNT (PersonelID) FROM Personeller WHERE DepartmanID = '7' AND Cinsiyeti = 'Kadın' ", Veritabani.baglanti);


            Veritabani.baglanti.Open();
            Int32 countSayi1 = (Int32)countSayi.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countSayi22 = (Int32)countSayi2.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countSayi33 = (Int32)countSayi3.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countSayi44 = (Int32)countSayi4.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countSayi55 = (Int32)countSayi5.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countSayi66 = (Int32)countSayi6.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countSayi77 = (Int32)countSayi7.ExecuteScalar();
            Veritabani.baglanti.Close();


            Veritabani.baglanti.Open();
            Int32 countErkekSayi1 = (Int32)erkekcountSayi.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countErkekSayi2 = (Int32)erkekcountSayi2.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countErkekSayi3 = (Int32)erkekcountSayi3.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countErkekSayi4 = (Int32)erkekcountSayi4.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countErkekSayi5 = (Int32)erkekcountSayi5.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countErkekSayi6 = (Int32)erkekcountSayi6.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countErkekSayi7 = (Int32)erkekcountSayi7.ExecuteScalar();
            Veritabani.baglanti.Close();



            Veritabani.baglanti.Open();
            Int32 countKadinSayi1 = (Int32)kadincountSayi.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countKadinSayi2 = (Int32)kadincountSayi2.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countKadinSayi3 = (Int32)kadincountSayi3.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countKadinSayi4 = (Int32)kadincountSayi4.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countKadinSayi5 = (Int32)kadincountSayi5.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countKadinSayi6 = (Int32)kadincountSayi6.ExecuteScalar();
            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            Int32 countKadinSayi7 = (Int32)kadincountSayi7.ExecuteScalar();
            Veritabani.baglanti.Close();


            Veritabani.baglanti.Open();


            myReader = count.ExecuteReader();
            
            int count11 = 0;

            while (myReader.Read())
            {
                count11 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Kişi Sayısı"].Points.AddXY("Yönetim", count11/countSayi1);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();       

            myReader = erkekcount.ExecuteReader();

            int counterkek = 0;

            while (myReader.Read())
            {
                counterkek += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Erkek"].Points.AddXY("Yönetim", counterkek/countErkekSayi1);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();
            

            myReader = kadincount.ExecuteReader();

            int countkadin = 0;

            while (myReader.Read())
            {
                countkadin += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Kadın"].Points.AddXY("Yönetim", countkadin/countKadinSayi1);

            Veritabani.baglanti.Close();


            Veritabani.baglanti.Open();

            

            myReader = count2.ExecuteReader();

            int count22 = 0;

            while (myReader.Read())
            {
                count22 += Convert.ToInt32(myReader["ToplamYas"]);

            }


            chart1.Series["Kişi Sayısı"].Points.AddXY("Bilişim", count22/countSayi22);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            

            myReader = erkekcount2.ExecuteReader();

            int counterkek2 = 0;

            while (myReader.Read())
            {
                counterkek2 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Erkek"].Points.AddXY("Bilişim", counterkek2/countErkekSayi2);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

          

            myReader = kadincount2.ExecuteReader();

            int countkadin2 = 0;

            while (myReader.Read())
            {
                countkadin2 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Kadın"].Points.AddXY("Bilişim", countkadin2/countKadinSayi2);

            Veritabani.baglanti.Close();


            Veritabani.baglanti.Open();           


            myReader = count3.ExecuteReader();

            int count33 = 0;

            while (myReader.Read())
            {
                count33 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Kişi Sayısı"].Points.AddXY("İhracat", count33/countSayi33);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            


            myReader = erkekcount3.ExecuteReader();

            int counterkek3 = 0;

            while (myReader.Read())
            {
                counterkek3 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Erkek"].Points.AddXY("İhracat", counterkek3/countErkekSayi3);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            

            myReader = kadincount3.ExecuteReader();

            int countkadin3 = 0;

            while (myReader.Read())
            {
                countkadin3 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Kadın"].Points.AddXY("İhracat", countkadin3/countKadinSayi3);

            Veritabani.baglanti.Close();


            Veritabani.baglanti.Open();

            

            myReader = count4.ExecuteReader();

            int count44 = 0;

            while (myReader.Read())
            {
                count44 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Kişi Sayısı"].Points.AddXY("IK", count44/countSayi44);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            

            myReader = erkekcount4.ExecuteReader();

            int counterkek4 = 0;

            while (myReader.Read())
            {
                counterkek4 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Erkek"].Points.AddXY("IK", counterkek4/countErkekSayi4);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            


            myReader = kadincount4.ExecuteReader();

            int countkadin4 = 0;

            while (myReader.Read())
            {
                countkadin4 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Kadın"].Points.AddXY("IK", countkadin4/countKadinSayi4);

            Veritabani.baglanti.Close();


            Veritabani.baglanti.Open();

            


            myReader = count5.ExecuteReader();

            int count55 = 0;

            while (myReader.Read())
            {
                count55 += Convert.ToInt32(myReader["ToplamYas"]);

            }


            chart1.Series["Kişi Sayısı"].Points.AddXY("Üretim", count55/countSayi55);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            


            myReader = erkekcount5.ExecuteReader();

            int counterkek5 = 0;

            while (myReader.Read())
            {
                counterkek5 += Convert.ToInt32(myReader["ToplamYas"]);

            }


            chart1.Series["Erkek"].Points.AddXY("Üretim", counterkek5/countErkekSayi5);


            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();


            myReader = kadincount5.ExecuteReader();

            int countkadin5 = 0;

            while (myReader.Read())
            {
                countkadin5 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Kadın"].Points.AddXY("Üretim", countkadin5/countKadinSayi5);

            Veritabani.baglanti.Close();


            Veritabani.baglanti.Open();

            

            myReader = count6.ExecuteReader();

            int count66 = 0;

            while (myReader.Read())
            {
                count66 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Kişi Sayısı"].Points.AddXY("AR-GE", count66/countSayi66);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

           

            myReader = erkekcount6.ExecuteReader();

            int counterkek6 = 0;

            while (myReader.Read())
            {
                counterkek6 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Erkek"].Points.AddXY("AR-GE", counterkek6/countErkekSayi6);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            


            myReader = kadincount6.ExecuteReader();

            int countkadin6 = 0;

            while (myReader.Read())
            {
                countkadin6 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Kadın"].Points.AddXY("AR-GE", countkadin6/countKadinSayi6);

            Veritabani.baglanti.Close();


            Veritabani.baglanti.Open();

           


            myReader = count7.ExecuteReader();

            int count77 = 0;

            while (myReader.Read())
            {
                count77 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Kişi Sayısı"].Points.AddXY("Muhasebe", count77/countSayi77);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

            


            myReader = erkekcount7.ExecuteReader();

            int counterkek7 = 0;

            while (myReader.Read())
            {
                counterkek7 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Erkek"].Points.AddXY("Muhasebe", counterkek7/countErkekSayi7);

            Veritabani.baglanti.Close();

            Veritabani.baglanti.Open();

           


            myReader = kadincount7.ExecuteReader();

            int countkadin7 = 0;

            while (myReader.Read())
            {
                countkadin7 += Convert.ToInt32(myReader["ToplamYas"]);

            }

            chart1.Series["Kadın"].Points.AddXY("Muhasebe", countkadin7/countKadinSayi7);

            Veritabani.baglanti.Close();


            chart1.Titles.Add("Maaş Ortalaması,Departman - Kişi Sayısı,Cinsiyet");
            Veritabani.baglanti.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
