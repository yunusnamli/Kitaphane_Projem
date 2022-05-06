using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kitaphane
{
    public class Yazar : IEntity
    {
        private int yazar_ıd;

        public int Yazar_ıd
        {
            get { return yazar_ıd; }
            set { yazar_ıd = value; }
        }
        private string yazar_ad;

        public string Yazar_ad
        {
            get { return yazar_ad; }
            set { yazar_ad = value; }
        }
        private string ozgecmis;

        public string Ozgecmis
        {
            get { return ozgecmis; }
            set { ozgecmis = value; }
        }
        private string yazar_resim;

        public string Yazar_resim
        {
            get { return yazar_resim; }
            set { yazar_resim = value; }
        }

        public Yazar()
        {
            this.yazar_ad = "";
            this.yazar_ıd=0;
            this.yazar_resim="";
            this.ozgecmis="";
        }
    }
}
