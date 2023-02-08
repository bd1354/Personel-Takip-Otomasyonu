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
    public partial class sadasd : Form
    {
        public sadasd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SMS smsApi = new SMS();
            smsApi.SmsSender("+905510658490","Merhaba test mesajı");
        }
    }
}
