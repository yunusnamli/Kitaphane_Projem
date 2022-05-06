using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Kitaphane
{
    public partial class Kitap_Form : Form
    {
        public Kitap_Form()
        {
            InitializeComponent();
        }

        private void btn_Anasayfa_Click(object sender, EventArgs e)
        {
            AnaForm frm = new AnaForm();
            frm.Show();
            this.Hide();
        }
        int i = 0;
        private void timer_Kitap_Tick(object sender, EventArgs e)//1- ilk işlem timer.
        {
            i++;
            if (i==2)
            {
                timer_Kitap.Enabled = false;
                lbl_Mesaj.Visible = false;
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)//2-2. işlem
        {
           
            Kitap ktp = new Kitap();
            ktp.Kitap_ad = txtbox_Kitapadi.Text;
            ktp.Basim_yili =Convert.ToInt16( txtbox_Basimyili.Text);
            ktp.Kapak_resim = txtbox_Kitapadi.Text + ".jpg";
            ktp.Fiyat = Convert.ToInt16(txtbox_Fiyati.Text);
            ktp.Kat_no.Kat_id = Convert.ToInt32(cmbbox_Kategori.SelectedValue);
            ktp.Yayin_no.Yayin_id=Convert.ToInt32(cmbbox_Yayinevi.SelectedValue);
            ktp.Yazar_no.Yazar_ıd = Convert.ToInt32(cmbbox_Yazarı.SelectedValue);
            ktp.Ozet = richTextBox_Ozet.Text;
            KitapDb ktpdp = new KitapDb();
            try
            {
                ktpdp.Ekle(ktp);
                timer_Kitap.Enabled = true;
                lbl_Mesaj.Visible = true;
                lbl_Mesaj.Text = "ekleme başarılı";
                i = 0;
            }
            catch (Exception)
            {
                timer_Kitap.Enabled = true;
                lbl_Mesaj.Visible = true;
                lbl_Mesaj.Text = "ekleme başarısız";
                i = 0;
            }
            txtbox_Basimyili.Text = "";
            txtbox_Fiyati.Text = "";
            txtbox_Kitapadi.Text = "";
            pictureBox_Kapakresim = null;
            richTextBox_Ozet.Text = "";
            //3- 3.işlem dbsini doldur
        }

        private void Kitap_Form_Load(object sender, EventArgs e)
        {//4- 4.işlem metotları aç
            YazarDoldur();
            YayDoldur();
            KategoriDoldur();
        }

        private void KategoriDoldur()
        {
            KategoriDb katdb = new KategoriDb();
            cmbbox_Kategori.DataSource = katdb.DoldurKategori();//metot
            cmbbox_Kategori.DisplayMember = "Kategori_Ad";
            cmbbox_Kategori.ValueMember = "Kategori_Id";
        }

        private void YayDoldur()
        {
            YayineviDb yaydb = new YayineviDb();
            cmbbox_Yayinevi.DataSource = yaydb.DoldurYayinevi();//metot
            cmbbox_Yayinevi.DisplayMember = "Yayinevi_Ad";
            cmbbox_Yayinevi.ValueMember = "Yayinevi_Id";
        }

        private void YazarDoldur()
        {
            YazarDb yzrdb = new YazarDb();
            cmbbox_Yazarı.DataSource = yzrdb.DoldurYazar();//metot
            cmbbox_Yazarı.DisplayMember = "Yazar_Ad";
            cmbbox_Yazarı.ValueMember = "Yazar_Id";
        }

        private void btn_Resimsec_Click(object sender, EventArgs e)
        {
            //4- işlem resim seç tıkla
            openFileDialog_Kitap.ShowDialog();
            string dosyaadi = txtbox_Kitapadi.Text;
            bool dosya;
            dosya = File.Exists("\\WEB1-SERVER2\\pc11\\11TBMustafa\\2.dönem c#\\images\\KitapResim" + txtbox_Kitapadi.Text + ".jpg");
            if (dosya)
            {
                File.Delete("\\WEB1-SERVER2\\pc11\\11TBMustafa\\2.dönem c#\\images\\KitapResim"+txtbox_Kitapadi+".jpg");
            }
            File.Copy(openFileDialog_Kitap.FileName,"\\WEB1-SERVER2\\pc11\\11TBMustafa\\2.dönem c#\\images\\KitapResim" + txtbox_Kitapadi.Text + ".jpg");
            File.WriteAllBytes(dosyaadi, File.ReadAllBytes(openFileDialog_Kitap.FileName));
            pictureBox_Kapakresim.ImageLocation = txtbox_Kitapadi.Text + ".jpg";
            pictureBox_Kapakresim.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        private void btn_Arama_Click(object sender, EventArgs e)
        {//5- işlem arama tıkla
            Kitap ktp = new Kitap();
            ktp.Kitap_ad = txtbox_Kitapadi.Text;
            KitapDb ktpdb = new KitapDb();
            ktpdb.Getir(ktp);//metot var.
            if (ktp.Kitap_id!=0)
            {
                lbl_Kitapadi.Text = ktp.Kitap_id.ToString();
                txtbox_Kitapadi.Text = ktp.Kitap_ad;
                richTextBox_Ozet.Text = ktp.Ozet;
                cmbbox_Kategori.SelectedValue = ktp.Kat_no.Kat_id;
                cmbbox_Yayinevi.SelectedValue = ktp.Yayin_no.Yayin_id;
                cmbbox_Yazarı.SelectedValue = ktp.Yazar_no.Yazar_ıd;
                txtbox_Fiyati.Text =ktp.Fiyat.ToString();
                txtbox_Basimyili.Text = ktp.Basim_yili.ToString();
                pictureBox_Kapakresim.ImageLocation = ktp.Kapak_resim;
                pictureBox_Kapakresim.SizeMode = PictureBoxSizeMode.StretchImage;
                timer_Kitap.Enabled = true;
                lbl_Mesaj.Visible = true;
                lbl_Mesaj.Text = "kitap bulundu";

                i = 0;
            }
            else
            {
                timer_Kitap.Enabled = true;
                lbl_Mesaj.Visible = true;
                lbl_Mesaj.Text = "kitap bulunamadı";
                i = 0;
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {//6- iş
            Kitap ktp = new Kitap();
            ktp.Kitap_ad = txtbox_Kitapadi.Text;
            ktp.Kapak_resim = txtbox_Kitapadi.Text + ".jpg";
            pictureBox_Kapakresim.ImageLocation = null;
            ktp.Kitap_id = Convert.ToInt16(lbl_Id.Text);
            ktp.Kat_no.Kat_id = Convert.ToInt16(cmbbox_Kategori.SelectedValue);
            ktp.Yazar_no.Yazar_ıd = Convert.ToInt16(cmbbox_Yazarı.SelectedValue);
            ktp.Yayin_no.Yayin_id = Convert.ToInt16(cmbbox_Yayinevi.SelectedValue);
            ktp.Fiyat = Convert.ToInt16(txtbox_Fiyati.Text);
            ktp.Basim_yili = Convert.ToInt16(txtbox_Basimyili);
            ktp.Ozet = richTextBox_Ozet.Text;

            KitapDb ktpdb = new KitapDb();
            ktpdb.Guncelle(ktp);
            try
            {
                timer_Kitap.Enabled = true;
                lbl_Mesaj.Visible = true;
                lbl_Mesaj.Text = "kayıt güncellendi";
                i = 0;
            }
            catch (Exception)
            {
                timer_Kitap.Enabled = true;
                lbl_Mesaj.Visible = true;
                lbl_Mesaj.Text = "kayıt güncellenmedi";
                i = 0;
                
            }
            txtbox_Basimyili.Text = "";
            txtbox_Fiyati.Text = "";
            txtbox_Kitapadi.Text = "";
            pictureBox_Kapakresim.Image = null;
            richTextBox_Ozet.Text = "";

        }

        private void pictureBox_Kapakresim_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Kapakresmi_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox_Ozet_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbbox_Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

