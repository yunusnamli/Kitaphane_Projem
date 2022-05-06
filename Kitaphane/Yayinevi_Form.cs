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
    public partial class Yayinevi_Form : Form
    {
        
        public Yayinevi_Form()
        {
            InitializeComponent();
        }

        private void btn_Yayınevianasayfa_Click(object sender, EventArgs e)
        {
            AnaForm frm = new AnaForm();
            frm.Show();
            this.Hide();
        }
        int i = 0;
        private void btn_Yayınevıekle_Click(object sender, EventArgs e)
        {
            Yayinevi yayin = new Yayinevi();
            
            try
            {
                yayin.Yayin_ad = txtbox_yayineviadi.Text;
                yayin.Yayin_adres = txtbox_yayınevıadres.Text;
                yayin.Yayin_email = txtbox_Yayınevıemail.Text;
                yayin.Yayin_fax = txtbox_Yayınfax.Text;
                yayin.Yayin_tel = txtbox_yayıneevıtel.Text;
                YayineviDb yayindb = new YayineviDb();
                yayindb.Ekle(yayin);
                i = 0;
                if (timer_yayinevi.Enabled==false)
                {
                    timer_yayinevi.Enabled = true;
                    txtbox_yayineviadi.Text = "";
                    txtbox_yayıneevıtel.Text = "";
                    txtbox_Yayınfax.Text = "";
                    txtbox_yayınevıadres.Text = "";
                    lbl_YayınevıMesaj.Visible = true;
                    lbl_YayınevıMesaj.Text = "yayinevi başarıyla eklendi";
                    i = 0;
                    comboBox_yayinevilistesi.Items.Clear();
                    YayineviDoldur(); //metot ismi aç burda ama once timer yap
                }
            }
            catch (Exception)
            {
                lbl_YayınevıMesaj.Visible = true;
                lbl_YayınevıMesaj.Text = "ekleme başarısız.";

            }
        }

        private void YayineviDoldur()//bu sefer farklı yontemle actık 
        {
            List<string> liste = new List<string>();
            YayineviDb yayindb = new YayineviDb();
            liste = yayindb.Doldur();//ayrı bir metotdur.
            foreach (var item in liste)
            {
                comboBox_yayinevilistesi.Items.Add(item);

            }
            //doldur metotunu doldur. yayindb classına git
        }

        private void timer_yayinevi_Tick(object sender, EventArgs e)
        {
            i++;
            if(i==2)
            {
                lbl_YayınevıMesaj.Visible = false;
                lbl_YayınevıMesaj.Enabled = false;
            }
        }

        private void Yayinevi_Form_Load(object sender, EventArgs e)
        {
            YayineviDoldur();
        }

        private void btn_Yayınevıguncelle_Click(object sender, EventArgs e)
        {
            Yayinevi yayin = new Yayinevi();
            yayin.Yayin_id = Convert.ToInt32(lbl_yayınevıid.Text);
            yayin.Yayin_ad = txtbox_yayineviadi.Text;
            yayin.Yayin_adres = txtbox_yayınevıadres.Text;
            yayin.Yayin_email = txtbox_Yayınevıemail.Text;
            yayin.Yayin_fax = txtbox_Yayınfax.Text;
            yayin.Yayin_tel = txtbox_yayıneevıtel.Text;
            YayineviDb yayindb = new YayineviDb();
            yayindb.Guncelle(yayin);
            txtbox_yayineviadi.Text = "";
            txtbox_yayıneevıtel.Text = "";
            txtbox_Yayınevıemail.Text = "";
            txtbox_yayınevıadres.Text = "";
            txtbox_Yayınfax.Text = "";
        }

        private void comboBox_yayinevilistesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Yayinevi yayin = new Yayinevi();
            yayin.Yayin_ad = comboBox_yayinevilistesi.SelectedItem.ToString();
            YayineviDb yayindb = new YayineviDb();
            yayindb.Getir(yayin);//getiri metot olarak acıcaz.
            //metotdaki kodlar yazılınca buraya geri dön.
            lbl_yayınevıid.Text = yayin.Yayin_id.ToString();
            txtbox_yayineviadi.Text = yayin.Yayin_ad;
            txtbox_yayınevıadres.Text = yayin.Yayin_adres;
            txtbox_Yayınevıemail.Text = yayin.Yayin_email;
            txtbox_Yayınfax.Text = yayin.Yayin_fax;
            txtbox_yayıneevıtel.Text = yayin.Yayin_tel;
            //burdaki kodlar comboboxdan ne alıcagımıza baglı olarak mesela comboboxdan mustafa sectın butun bılgılerı karsına cıkıcak.

        }
    }
}
