using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Kitaphane
{
    public class SatisDb : TemelDb
    {
        public override void Ekle(IEntity varlik)
        {
            Satis gelen = (Satis)varlik;
            Baglan();
            komut = new SqlCommand("instert into Tbl_Satis(Uye_No,Kitap_No,Adet) values (@Uye,@kitapno,@adet)",baglanti);
            komut.Parameters.AddWithValue("@uyeno",gelen.Uye_no.Uye_id);
            komut.Parameters.AddWithValue("@kitapno", gelen.Kitap_no.Kitap_id);
            komut.Parameters.AddWithValue("@adet", gelen.Adet);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override void Guncelle(IEntity varlik)
        {
            throw new NotImplementedException();
        }

        public override void Sil(IEntity varlik)
        {
            throw new NotImplementedException();
        }

        public override void Ara(IEntity varlik)
        {
            throw new NotImplementedException();
        }
    }
}
