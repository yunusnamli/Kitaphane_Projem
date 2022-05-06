using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kitaphane
{
    public class Kitap : IEntity
    {
        private int kitap_id;

        public int Kitap_id
        {
            get { return kitap_id; }
            set { kitap_id = value; }
        }
        private string kitap_ad;

        public string Kitap_ad
        {
            get { return kitap_ad; }
            set { kitap_ad = value; }
        }
        private Kategori kat_no;

        public Kategori Kat_no
        {
            get { return kat_no; }
            set { kat_no = value; }
        }
        private Yazar yazar_no;

        public Yazar Yazar_no
        {
            get { return yazar_no; }
            set { yazar_no = value; }
        }
        private Yayinevi yayin_no;

        public Yayinevi Yayin_no
        {
            get { return yayin_no; }
            set { yayin_no = value; }
        }
        private string ozet;

        public string Ozet
        {
            get { return ozet; }
            set { ozet = value; }
        }
        private string kapak_resim;

        public string Kapak_resim
        {
            get { return kapak_resim; }
            set { kapak_resim = value; }
        }
        private int fiyat;

        public int Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
        private int basim_yili;

        public int Basim_yili
        {
            get { return basim_yili; }
            set { basim_yili = value; }
        }

        public Kitap()
        {
            this.basim_yili=0;  
            this.fiyat=0;
            this.ozet="";
            this.yazar_no=new Yazar();
            this.kat_no=new Kategori();
            this.kitap_id=0;
            this.kitap_ad ="";
            this.yayin_no=new Yayinevi();
        }
    }
}
