using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            AracKayit kayit = new AracKayit();
            kayit.ShowDialog();
        }

        private void btnYer_Click(object sender, EventArgs e)
        {
            AracOtoparkYerleri yer = new AracOtoparkYerleri();
            yer.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            AracCikis cikis = new AracCikis();
            cikis.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
