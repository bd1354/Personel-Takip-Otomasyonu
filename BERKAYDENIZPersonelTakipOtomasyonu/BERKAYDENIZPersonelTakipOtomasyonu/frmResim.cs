using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;


namespace BERKAYDENIZPersonelTakipOtomasyonu
{
    public partial class frmResim : Form
    {
        public frmResim()
        {
            InitializeComponent();
        }

        VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;
        bool safe = true;

        void KameraBaslat()
        {
            try
            {
                filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                videoCapture = new VideoCaptureDevice(filterInfo[0].MonikerString);
                videoCapture.NewFrame += new NewFrameEventHandler(Camera_On);
                videoCapture.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void Camera_On(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void frmResim_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!safe)
                {
                    videoCapture.Stop();
                }
                
            }
            catch
            {
                return;
            }
            
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            KameraBaslat();
            safe = false;
        }

        private void btnYakala_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string dosyaDizini = @"C:\Image\" + txtDosyaAdi.Text + ".jpg";
            var bitmap = new Bitmap(200,180);
            pictureBox2.DrawToBitmap(bitmap, pictureBox2.ClientRectangle);
            System.Drawing.Imaging.ImageFormat imageFormat = null;
            imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            bitmap.Save(dosyaDizini, imageFormat);

            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
