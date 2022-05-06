using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kitaphane
{
    public class Uye : IEntity
    {
        private int uye_id;

        public int Uye_id
        {
            get { return uye_id; }
            set { uye_id = value; }
        }
        private string uye_ad;

        public string Uye_ad
        {
            get { return uye_ad; }
            set { uye_ad = value; }
        }
        private string uye_soyad;

        public string Uye_soyad
        {
            get { return uye_soyad; }
            set { uye_soyad = value; }
        }
        private string uye_adres;

        public string Uye_adres
        {
            get { return uye_adres; }
            set { uye_adres = value; }
        }
        private string uye_tel;

        public string Uye_tel
        {
            get { return uye_tel; }
            set { uye_tel = value; }
        }
        private string uye_email;

        public string Uye_email
        {
            get { return uye_email; }
            set { uye_email = value; }
        }
        private int sicil_no;

        public int Sicil_no
        {
            get { return sicil_no; }
            set { sicil_no = value; }
        }

        public Uye()
        {
            this.sicil_no=0;
            this.uye_ad="";
            this.uye_adres="";
            this.uye_email="";
            this.uye_id=0;
            this.uye_soyad="";
            this.uye_tel = "";
        }
    }
}
