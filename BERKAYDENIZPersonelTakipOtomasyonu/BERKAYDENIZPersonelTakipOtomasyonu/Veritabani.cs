using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERKAYDENIZPersonelTakipOtomasyonu
{
    internal class Veritabani
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=STRING;Initial Catalog=Personel_Takip;Integrated Security=True");

        public static void ESG(SqlCommand cmd,string sql)
        {
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        public static DataTable Listele_Ara(DataGridView gridView,string sql)
        {
            DataTable tbl = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql,baglanti);
            adtr.Fill(tbl);
            gridView.DataSource = tbl;
            baglanti.Close();
            return tbl;
        }

        public static DataTable YasGetir(string sql)
        {
            DataTable tbl = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, baglanti);
            adtr.Fill(tbl);
            baglanti.Close();
            return tbl;
        }


    }
}
