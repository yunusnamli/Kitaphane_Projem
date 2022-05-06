using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kitaphane
{
    public class Yayinevi : IEntity
    {
        private int yayin_id;

        public int Yayin_id
        {
            get { return yayin_id; }
            set { yayin_id = value; }
        }
        private string yayin_ad;

        public string Yayin_ad
        {
            get { return yayin_ad; }
            set { yayin_ad = value; }
        }
        private string yayin_tel;

        public string Yayin_tel
        {
            get { return yayin_tel; }
            set { yayin_tel = value; }
        }
        private string yayin_adres;

        public string Yayin_adres
        {
            get { return yayin_adres; }
            set { yayin_adres = value; }
        }
        private string yayin_fax;

        public string Yayin_fax
        {
            get { return yayin_fax; }
            set { yayin_fax = value; }
        }
        private string yayin_email;

        public string Yayin_email
        {
            get { return yayin_email; }
            set { yayin_email = value; }
        }

        public Yayinevi()
        {
            this.yayin_ad="";
            this.yayin_adres="";
            this.yayin_email="";
            this.yayin_fax="";
            this.yayin_id=0;
            this.yayin_tel = "";
        }
    }
}
