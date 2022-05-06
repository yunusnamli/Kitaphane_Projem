using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaphane
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Kategori_Click(object sender, EventArgs e)
        {
            Kategori_Form frm = new Kategori_Form();
            frm.Show();
            this.Hide();//arkadaki formu gızlemek icin yazıldı
        }

        private void btn_Yazar_Click(object sender, EventArgs e)
        {
            Yazar_Form frm = new Yazar_Form();
            frm.Show();
            this.Hide();
        }

        private void btn_Yayinevi_Click(object sender, EventArgs e)
        {
            Yayinevi_Form frm = new Yayinevi_Form();
            frm.Show();
            this.Hide();
        }

        private void btn_Uye_Click(object sender, EventArgs e)
        {
            Uye_Form frm = new Uye_Form();
            frm.Show();
            this.Hide();
        }

        private void btn_Kitap_Click(object sender, EventArgs e)
        {
            Kitap_Form frm = new Kitap_Form();
            frm.Show();
            this.Hide();
        }

        private void btn_Satis_Click(object sender, EventArgs e)
        {
            Satis_Form frm = new Satis_Form();
            frm.Show();
            this.Hide();

        }
    }
}
