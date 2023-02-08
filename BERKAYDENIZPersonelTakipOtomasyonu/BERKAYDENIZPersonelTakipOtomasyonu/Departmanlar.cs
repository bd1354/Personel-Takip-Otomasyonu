using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERKAYDENIZPersonelTakipOtomasyonu
{
    internal class Departmanlar
    {
        private int _DepartmanID;
        private string _Departman;
        private string _Aciklama;

        public int DepartmanID { get => _DepartmanID; set => _DepartmanID = value; }
        public string Departman { get => _Departman; set => _Departman = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }

        public static SqlDataReader DepartmanGetir(ListView lst)
        {
            lst.Items.Clear();
            Veritabani.baglanti.Open();
            //SqlCommand,T-SQL sorgulari ile veritabani uzerinde sorgulama,ekleme,guncelleme,silme islemlerini yapar.
            SqlCommand komut = new SqlCommand("Select * from Departmanlar", Veritabani.baglanti);
            //Bir ya da birden fazla row'un sonuc olarak dondurulecegi sorgularda SqlCommand'in ExecuteReader() ozelligi kullanilir.ExecuteReader SqlDatareader turunde dondurur.
            SqlDataReader dr = komut.ExecuteReader();
            //Okunabilir row oldugu surece Read() metodu true dondurecektir.SqlDataReader read-only'dir ve her row okumasi asagida ki gibi yapilir
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr[0].ToString();
                ekle.SubItems.Add(dr[1].ToString());
                ekle.SubItems.Add(dr[2].ToString());
                lst.Items.Add(ekle);

            }
            //SqlDataReader read-only'dir yani sadece okuma yapilir ve bu surede veritabani baglantisi acik kalmalidir ancak is bitince kapatilmasi gerekir
            Veritabani.baglanti.Close();
            return dr;
        }

    }
}
