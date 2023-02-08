using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERKAYDENIZPersonelTakipOtomasyonu
{
    internal class Personeller
    {
        private int _PersonelID;
        private string _Adi;
        private string _Soyadi;
        private string _Cinsiyeti;
        private DateTime _DogumTarihi;
        private string _Telefon;
        private string _Adres;
        private string _Email;
        private int _DepartmanID;
        private decimal _Maasi;
        private DateTime _GirisTarihi;
        private string _Aciklama;

        public int PersonelID { get => _PersonelID; set => _PersonelID = value; }
        public string Adi { get => _Adi; set => _Adi = value; }
        public string Soyadi { get => _Soyadi; set => _Soyadi = value; }
        public string Telefon { get => _Telefon; set => _Telefon = value; }
        public string Adres { get => _Adres; set => _Adres = value; }
        public string Email { get => _Email; set => _Email = value; }
        public int DepartmanID { get => _DepartmanID; set => _DepartmanID = value; }
        public decimal Maasi { get => _Maasi; set => _Maasi = value; }
        public DateTime GirisTarihi { get => _GirisTarihi; set => _GirisTarihi = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public string Cinsiyeti { get => _Cinsiyeti; set => _Cinsiyeti = value; }
        public DateTime DogumTarihi { get => _DogumTarihi; set => _DogumTarihi = value; }

        public static DataTable ComboyaDepartmanGetir(ComboBox combo)
        {
            DataTable tbl = new DataTable();
            Veritabani.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Departmanlar", Veritabani.baglanti);
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.ValueMember = "DepartmanID"; //Arkaplanda'ki deger
            combo.DisplayMember = "Departman"; //Gorunecek olan deger
            Veritabani.baglanti.Close();
            return tbl;
        }

        public static DataTable TariheGoreAra(DateTimePicker dt,DataGridView gridview)
        {
            DataTable tbl = new DataTable();
            Veritabani.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select p.Resim as Fotoğraf,p.Adi as Ad,p.Soyadi as Soyad,p.Cinsiyeti as Cinsiyet,DATEDIFF(yy,[DogumTarihi],GETDATE()) + (CASE WHEN DATEPART(MONTH,GETDATE()) - DATEPART(MONTH,[DogumTarihi]) < 0 THEN -1 ELSE 0 END ) AS Yaş,p.Telefon,p.Adres,p.Email,\r\nd.Departman,p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama\r\nfrom Personeller p,Departmanlar d where p.DepartmanID=d.DepartmanID and GirisTarihi =@P1", Veritabani.baglanti);
            adtr.SelectCommand.Parameters.Add("@P1", SqlDbType.Date).Value = dt.Value;
            adtr.Fill(tbl);
            gridview.DataSource = tbl;
            Veritabani.baglanti.Close();
            return tbl;
        }
    }
}
