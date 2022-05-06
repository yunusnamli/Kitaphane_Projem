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
    public partial class Satis_Form : Form
    {
        public Satis_Form()
        {
            InitializeComponent();
        }

        private void bttn_Anasayfa_Click(object sender, EventArgs e)
        {
            AnaForm frm = new AnaForm();
            frm.Show();
            this.Hide();
        }
        int i = 0;
        private void timer_Satis_Tick(object sender, EventArgs e)
        {//1-timer yap
            i++;
            if (i==2)
            {
                timer_Satis.Enabled = false;
                lbl_Mesaj.Visible = false;
            }

        }

        private void txtbox_siciluyeno_TextChanged(object sender, EventArgs e)
        {
            //2-burayı yap
            Uye uy = new Uye();
            try
            {
                uy.Sicil_no =Convert.ToInt16( txtbox_siciluyeno.Text);
                UyeDb uydb = new UyeDb();
                uydb.Bul(uy);//tc girdiğinde bilgileri gelir gibi düşün
                lbl_uyeadsoyad.Text = uy.Uye_ad;
                lbl_uyeadsoyad.Visible = true;
                lbl_Id.Text = uy.Uye_id.ToString();
                if (uy.Uye_ad!="")
                {
                    timer_Satis.Enabled = true;
                    lbl_Mesaj.Visible = true;
                    lbl_Mesaj.Text = "Uye mevcut";
                    i = 0;
                }
                else
                {
                    timer_Satis.Enabled = true;
                    lbl_Mesaj.Visible = true;
                    lbl_Mesaj.Text = "Uye yok";
                    i = 0;
                }
            }
            catch (Exception)
            {

                timer_Satis.Enabled = true;
                lbl_Mesaj.Visible = true;
                lbl_Mesaj.Text = "Uye bulunamadı";
                i = 0;
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {//3.işlem
            Satis sat = new Satis();
            sat.Adet = Convert.ToInt16(txtbox_Satisadet);
            sat.Kitap_no.Kitap_id = Convert.ToInt16(comboBox_Kitaplistesi.SelectedValue);
            sat.Uye_no.Uye_id = Convert.ToInt16(lbl_Id.Text);
            try
            {
                SatisDb satdb = new SatisDb();
                satdb.Ekle(sat);
                timer_Satis.Enabled = true;
                lbl_Mesaj.Visible = true;
                lbl_Mesaj.Text = "ekleme başarılı";
                i = 0;
            }
            catch (Exception)
            {
                timer_Satis.Enabled = true;
                lbl_Mesaj.Visible = true;
                lbl_Mesaj.Text = "ekleme başarısız";
                
            }
            txtbox_Satisadet.Text = "";
            txtbox_siciluyeno.Text = "";
            lbl_uyeadsoyad.Text = "";
        }

        private void Satis_Form_Load(object sender, EventArgs e)
        {//4.işlem
            KitapDoldur();//metot ac
            
        }

        private void KitapDoldur()
        {
            KitapDb ktpdb=new KitapDb();
            comboBox_Kitaplistesi.DataSource = ktpdb.DoldurKitap();
            comboBox_Kitaplistesi.DisplayMember = "Kat_Ad";
            comboBox_Kitaplistesi.ValueMember = "Kat_Id";
        }

        private void comboBox_Kitaplistesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
