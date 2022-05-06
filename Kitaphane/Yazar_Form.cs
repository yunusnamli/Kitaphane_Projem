using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;// Bunu ekle
namespace Kitaphane
{
    public partial class Yazar_Form : Form
    {
        public Yazar_Form()
        {
            InitializeComponent();
        }

        private void btn_YazarAnasayfa_Click(object sender, EventArgs e)
        {
            AnaForm frm = new AnaForm();
            frm.Show();
            this.Hide();
        }

        private void btn_YazarEkle_Click(object sender, EventArgs e)
        {
            Yazar yzr = new Yazar();
            try
            {
                yzr.Yazar_ad = txtbox_Yazaradi.Text;
                yzr.Ozgecmis = richtxtbox_ozgecmis.Text;
                yzr.Yazar_resim = txtbox_Yazaradi.Text + ".jpg";
                YazarDb yzrdb = new YazarDb();
                yzrdb.Ekle(yzr);
                //1-yazardb ekle bölmüne gir ve doldur.
                txtbox_Yazaradi.Text = "";
                richtxtbox_ozgecmis.Text = "";
                pictureBox_YazarResim.Image = null;
                lbl_Yazarmesaj.Visible = true;
                lbl_Yazarmesaj.Text = "ekleme başarılı oldu";

            }
            catch (Exception)
            {
                lbl_Yazarmesaj.Visible = true;
                lbl_Yazarmesaj.Text = "Ekleme başarısız oldu";
                //2-resim sec tıkla
            }
        }

        private void btn_Resimsec_Click(object sender, EventArgs e)
        {

            openFileDialog_YazarResim.ShowDialog();
            string dosyaadi = txtbox_Yazaradi.Text + ".jpg";
            bool dosya;
            dosya = File.Exists("\\WEB1-SERVER2\\pc11\\11TBMustafa\\2.dönem c#\\images\\YazarResim" + txtbox_Yazaradi.Text + ".jpg");

            if (dosya)
            {
                File.Delete("\\WEB1-SERVER2\\pc11\\11TBMustafa\\2.dönem c#\\images\\YazarResim" + txtbox_Yazaradi.Text + ".jpg");
            }
            File.Copy(openFileDialog_YazarResim.FileName, "\\WEB1-SERVER2\\pc11\\11TBMustafa\\2.dönem c#\\images\\YazarResim" + txtbox_Yazaradi.Text + ".jpg");
            File.WriteAllBytes(dosyaadi, File.ReadAllBytes(openFileDialog_YazarResim.FileName));
            pictureBox_YazarResim.ImageLocation = txtbox_Yazaradi.Text + ".jpg";
            pictureBox_YazarResim.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_YazarAra_Click(object sender, EventArgs e)
        {
            Yazar yzr=new Yazar();
            yzr.Yazar_ad=txtbox_Yazaradi.Text;
            YazarDb yzrdb=new YazarDb();
            yzrdb.Getir(yzr); // Getir metodunu aç.

            if (yzr.Yazar_ıd!=0)
            {
                lbl_Yazaradi.Text = yzr.Yazar_ıd.ToString();
                txtbox_Yazaradi.Text = yzr.Yazar_ad;
                richtxtbox_ozgecmis.Text = yzr.Ozgecmis;
                pictureBox_YazarResim.ImageLocation = yzr.Yazar_resim.ToString();
                pictureBox_YazarResim.SizeMode = PictureBoxSizeMode.StretchImage;
                lbl_Yazarmesaj.Visible = true;
                lbl_Yazarmesaj.Text = "yazar bulundu";

            }
            else
            {
                lbl_Yazarmesaj.Visible = true;
                lbl_Yazarmesaj.Text = "yazar bulunmadı";
            }
            //5- yazar guncelle tıkla
        }

        private void btn_YazarGuncelle_Click(object sender, EventArgs e)
        {
            Yazar yzr = new Yazar();
            yzr.Yazar_ıd = Convert.ToInt32(lbl_YazarId.Text);
            yzr.Yazar_ad = txtbox_Yazaradi.Text;
            yzr.Ozgecmis = richtxtbox_ozgecmis.Text;
            yzr.Yazar_resim = txtbox_Yazaradi.Text + ".jpg";
            YazarDb yzrdb = new YazarDb();
            yzrdb.Guncelle(yzr);
            //6-yazardb gir.
            txtbox_Yazaradi.Text = "";
            richtxtbox_ozgecmis.Text = "";
            pictureBox_YazarResim.Image = null;
        }

        private void pictureBox_YazarResim_Click(object sender, EventArgs e)
        {

        }

        private void Yazar_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
