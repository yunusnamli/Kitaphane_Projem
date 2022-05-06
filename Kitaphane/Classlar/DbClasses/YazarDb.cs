using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace Kitaphane
{
    public class YazarDb : TemelDb
    {
        public override void Ekle(IEntity varlik)
        {
            Yazar Gelen = (Yazar)varlik;
            Baglan();
            komut = new SqlCommand("insert into Tbl_Yazar(Yazar_Ad,Ozgecmis,Yazar_Resim)values(@ad,@gecmis,@resim)", baglanti);
            komut.Parameters.AddWithValue("@ad", Gelen.Yazar_ad);
            komut.Parameters.AddWithValue("@gecmis", Gelen.Ozgecmis);
            komut.Parameters.AddWithValue("@resim", Gelen.Yazar_resim);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override void Guncelle(IEntity varlik)
        {
            Yazar gelen = (Yazar)varlik;
            Baglan();
            komut = new SqlCommand("update Tbl_Yazar set Yazar_Ad=@ad,Ozgecmis=@gecmis,Yazar_Resim=@resim where Yazar_Id=@ıd",baglanti);
            komut.Parameters.AddWithValue("@ad", gelen.Yazar_ad);
            komut.Parameters.AddWithValue("@gecmis", gelen.Ozgecmis);
            komut.Parameters.AddWithValue("@resim", gelen.Yazar_resim);
            komut.Parameters.AddWithValue("@Id", gelen.Yazar_ıd);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
            
        }

        public override void Sil(IEntity varlik)
        {
            throw new NotImplementedException();
        }

        public override void Ara(IEntity varlik)
        {
            throw new NotImplementedException();
        }

        internal void Getir(Yazar yzr)
        {
            Baglan();
            komut = new SqlCommand("select *from Tbl_Yazar where Yazar_Ad Yazar_Ad=@ad",baglanti);
            komut.Parameters.AddWithValue("@ad",yzr.Yazar_ad);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                yzr.Yazar_ıd = Convert.ToInt32(okuyucu["Yazar_Id"]);
                yzr.Yazar_ad = okuyucu["Yazar_Ad"].ToString();
                yzr.Ozgecmis = okuyucu["Ozgecmis"].ToString();
                yzr.Yazar_resim = okuyucu["Yazar_Resim"].ToString();
            }
            baglanti.Close();
            baglanti.Dispose();
        }

        internal object DoldurYazar()
        {
            Baglan();
            komut = new SqlCommand("select *from Tbl_Yazar", baglanti);
            komut.ExecuteNonQuery();
            tablo = new DataTable();
            adaptor = new SqlDataAdapter();
            adaptor = new SqlDataAdapter(komut);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }
    }
}
