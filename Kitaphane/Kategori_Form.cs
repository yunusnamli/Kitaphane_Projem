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
    public partial class Kategori_Form : Form
    {
        int i = 0;//genel olarak kullanılacak bir terim.
        public Kategori_Form()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Anasayfa_Click(object sender, EventArgs e)
        {
            AnaForm frm = new AnaForm();//ana sayfayı gormek ıcın tanıttık
            frm.Show();//frm goster
            this.Hide();//anasayfa tusuna basınca kategori modulu kapanıcak
        }
        
        private void btn_katekle_Click(object sender, EventArgs e)
        {
            Kategori kat = new Kategori();
            kat.Kat_ad = textbox_Katad.Text;//textbox_kat ad içindeki kat.kat_ad a atılacak.
            try//hata olabilecek kodlar.
            {
                KategoriDb katdb = new KategoriDb();
                katdb.Ekle(kat);
                if (timer_kat.Enabled==false)
                {
                    timer_kat.Enabled = true;
                    lbl_katmesaj.Visible = true;
                    lbl_katmesaj.Text = "kategori adı eklendi";
                    textbox_Katad.Text = "";
                    KategoriListele();//metotdur. comboboxdır Kategori formuna tıklayıp acılacak.cunku kategoriye ait
                    i = 0;
                }
            }
            catch (Exception)//hata cıktıgı zaman yapacagı kodlar.
            {
                lbl_katmesaj.Visible = true;
                lbl_katmesaj.Text = "Ekleme başarısız oldu";
                
            }

        }

        private void Kategori_Form_Load(object sender, EventArgs e)
        {
            KategoriListele();//burdan acılacak.//kategori formu boş alanı.
        }

        private void KategoriListele()
        {
            KategoriDb katdb = new KategoriDb();
         cmbBox_Katadliste.DataSource = katdb.Listele();//listele metodu ac
         cmbBox_Katadliste.DisplayMember = "Kat_Ad";//sqlde yazan kategori adları gelicek ve //içine adları tut
         cmbBox_Katadliste.ValueMember = "Kat_Id";//sqlde yazan kategori Id gelicek ve // içine idleri tut
        }

        private void timer_kat_Tick(object sender, EventArgs e)
        {
            i++;
            if(i==2)//false olduktan sonra 2 saniye gecicek ve kapatıcak
            {
                lbl_katmesaj.Visible = false;
                timer_kat.Enabled = false;
            }
        }

        private void btn_katguncelle_Click(object sender, EventArgs e)
        {
            Kategori kat = new Kategori();
            KategoriDb katdb = new KategoriDb();
            kat.Kat_id = Convert.ToInt16(cmbBox_Katadliste.SelectedValue);
            kat.Kat_ad = txtbox_yeniad.Text;
            try
            {
                katdb.Guncelle(kat);
                if (timer_kat.Enabled==false)
                {
                    timer_kat.Enabled = true;
                    lbl_katmesaj.Visible = true;
                    lbl_katmesaj.Text = "güncelleme başarı ile sonuclandı";
                    txtbox_yeniad.Text = "";
                    KategoriListele();
                    i = 0;
                }
            }
            catch (Exception)
            {
                lbl_katmesaj.Visible = true;
                lbl_katmesaj.Text = "guncelleme başarısız.";
                
            }
        }
    }
}
