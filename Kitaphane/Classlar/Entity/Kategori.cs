using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kitaphane
{
    public class Kategori : IEntity
    {
        private string kat_ad;
        private int kat_id;

        public Kategori()
        {
            this.kat_id = 0;
            this.kat_ad = "";
        }

        public int Kat_id
        {
            get { return kat_id; }
            set { kat_id = value; }
        }

        public string Kat_ad
        {
            get { return kat_ad; }
            set { kat_ad = value; }
        }
    }
}
