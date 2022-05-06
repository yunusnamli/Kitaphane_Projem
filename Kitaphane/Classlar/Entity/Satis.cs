using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kitaphane
{
    public class Satis : IEntity
    {
        private int satis_id;

        public int Satis_id
        {
            get { return satis_id; }
            set { satis_id = value; }
        }
        private Uye uye_no;

        public Uye Uye_no
        {
            get { return uye_no; }
            set { uye_no = value; }
        }
        private Kitap kitap_no;

        public Kitap Kitap_no
        {
            get { return kitap_no; }
            set { kitap_no = value; }
        }
        private int adet;

        public int Adet
        {
            get { return adet; }
            set { adet = value; }
        }

        public Satis()
        {
            this.adet=0;
            this.kitap_no=new Kitap();
            this.satis_id=0;
            this.uye_no=new Uye();
            
        }
    }
}
