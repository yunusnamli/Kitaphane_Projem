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
    public partial class Uye_Form : Form
    {
        public Uye_Form()
        {
            InitializeComponent();
        }

        private void btn_UyeAnasayfa_Click(object sender, EventArgs e)
        {
            AnaForm frm = new AnaForm();
            frm.Show();
            this.Hide();
        }
        int i = 0;
        private void btn_Uyeekle_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye();
            try
            {
                uye.Uye_ad = txtbox_Uyeadı.Text;
                uye.Uye_adres = txtbox_UyeAdres.Text;
                uye.Uye_email = txtBox_Email.Text;
                uye.Uye_tel = txtBox_Tel.Text;
                uye.Sicil_no =Convert.ToInt32(txtbox_Sicilno.Text);
                try
                {
                    UyeDb uyedb = new UyeDb();
                    uyedb.Ekle(uye);//baştaki uyeyi yazdık
                    if (timer_Uye.Enabled == false)
                    {
                        timer_Uye.Enabled = true;
                        txtBox_Email.Text = "";
                        txtbox_Sicilno.Text = "";
                        txtBox_Tel.Text = "";
                        txtbox_Uyeadı.Text = "";
                        txtbox_UyeAdres.Text = "";
                        lbl_Uyemesaj.Visible = true;
                        lbl_Uyemesaj.Text = "uye başarıyla eklendi";
                        i = 0;

                    }
                }
                catch (Exception)
                {
                    lbl_Uyemesaj.Visible=true;
                    lbl_Uyemesaj.Text = "ekleme basarısız.";
                    i = 0;
                }
                
              

                
            }
            catch (Exception)
            {
                lbl_Uyemesaj.Visible = true;
                lbl_Uyemesaj.Text = "ekleme başarısız.";
            }
            
        }

        private void timer_Uye_Tick(object sender, EventArgs e)
        {
            i++;
            if(i==2)
            {
                lbl_Uyemesaj.Visible = false;
                lbl_Uyemesaj.Enabled = false;
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Uye uy = new Uye();
            uy.Sicil_no =Convert.ToInt16( txtbox_Sicilno.Text);
            uy.Uye_ad = txtbox_Uyeadı.Text;
            uy.Uye_adres = txtbox_UyeAdres.Text;
            uy.Uye_email = txtBox_Email.Text;
            uy.Uye_id = Convert.ToInt16(lbl_Uyeid);
            uy.Uye_tel = txtBox_Tel.Text;
            try 
	{	        
		 UyeDb uydb = new UyeDb();
         uydb.Guncelle(uy);
         if (timer_Uye.Enabled==false)
         {
             lbl_Uyemesaj.Visible = false;
             lbl_Uyemesaj.Text = "guncelleme başarılı oldu";
             i = 0;
         }
	}
	catch (Exception)
	{
        timer_Uye.Enabled = true;
        lbl_Uyemesaj.Visible = true;
        lbl_Uyemesaj.Text = "guncelleme başarısız oldu";
        i = 0;
	}
            txtbox_Uyeadı.Text = "";
            txtbox_UyeAdres.Text = "";
            txtBox_Email.Text = "";
            txtbox_Sicilno.Text = "";
            txtBox_Tel.Text = "";
            lbl_Uyeid.Text = "";
           
        }

        private void btn_sicilara_Click(object sender, EventArgs e)
        {
            Uye uy = new Uye();
            uy.Sicil_no = Convert.ToInt16(txtbox_Sicilno.Text);
            UyeDb uydb = new UyeDb();
            uydb.Getir(uy);//1-bu metotu aç 
            //doldurduktan sonra devam et.
            if (uy.Uye_id!=0)
            {
                lbl_Uyeid.Text = uy.Uye_id.ToString();
                txtbox_Uyeadı.Text = uy.Uye_ad;
                txtbox_UyeAdres.Text = uy.Uye_adres;
                txtBox_Email.Text = uy.Uye_email;
                txtBox_Tel.Text = uy.Uye_tel;
                txtbox_Sicilno.Text = uy.Sicil_no.ToString();
                if (timer_Uye.Enabled==false)
                {
                    timer_Uye.Enabled = true;
                    lbl_Uyemesaj.Visible = true;
                    lbl_Uyemesaj.Text = "Kayıt bulundu";
                    i = 0;
                }
            }
            else
            {
                timer_Uye.Enabled = true;
                lbl_Uyemesaj.Visible = true;
                lbl_Uyemesaj.Text = "Kayıt bulunamadı";
                i = 0;
            }
        }

        private void btn_uyeadara_Click(object sender, EventArgs e)
        {
            Uye uy = new Uye();
            uy.Uye_ad = txtbox_Uyeadı.Text;
            UyeDb uydb = new UyeDb();
            uydb.GetirAd(uy);//metodu aç
            //içini doldur devam et.

            if (uy.Uye_id!=0)
            {
                lbl_Uyeid.Text = uy.Uye_id.ToString();
                txtbox_Uyeadı.Text = uy.Uye_ad;
                txtbox_UyeAdres.Text = uy.Uye_adres;
                txtBox_Email.Text = uy.Uye_email;
                txtBox_Tel.Text = uy.Uye_tel;
                txtbox_Sicilno.Text = uy.Sicil_no.ToString();
                if (timer_Uye.Enabled==false)
                {
                    timer_Uye.Enabled = true;
                    lbl_Uyemesaj.Visible = true;
                    lbl_Uyemesaj.Text = "Kayıt bulundu";
                    i = 0;
                }
            }
            else
            {
                timer_Uye.Enabled = true;
                lbl_Uyemesaj.Visible = true;
                lbl_Uyemesaj.Text = "Kayıt bulunamadı";
                i = 0;
            }
        
        }
    }
}
