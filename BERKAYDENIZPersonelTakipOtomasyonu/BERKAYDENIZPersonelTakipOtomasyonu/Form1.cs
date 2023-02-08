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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDepartmanlar_Click(object sender, EventArgs e)
        {
            frmDepartmanlar frm = new frmDepartmanlar();
            frm.ShowDialog();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frm = new frmPersonelEkle();
            frm.ShowDialog();
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            frmPersonelListele frm = new frmPersonelListele();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMaasZamlari_Click(object sender, EventArgs e)
        {
            frmYapilanZamlar frm = new frmYapilanZamlar();
            frm.ShowDialog();
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            frmPrimler frm = new frmPrimler();
            frm.ShowDialog();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            frmGrafik frm = new frmGrafik();
            frm.ShowDialog();
        }
    }
}
