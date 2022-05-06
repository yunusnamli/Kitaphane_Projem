using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Kitaphane
{
    public class KitapDb : TemelDb
    {
        public override void Ekle(IEntity varlik)
        {
            Kitap gelen = (Kitap)varlik;
            Baglan();
            komut = new SqlCommand("insert into Tbl_Kitap(Kitap_Ad,Ozet,Fiyat,Basim_Yili,Kat_No,Yazar_No,Yayin_No,Kapak_Resim) values(@ad,@ozet,@fiyat,@basyil,@katno,@yazno,@yayno,@resim)",baglanti);
            komut.Parameters.AddWithValue("@ad", gelen.Kitap_ad);
            komut.Parameters.AddWithValue("@ozet", gelen.Ozet);
            komut.Parameters.AddWithValue("@fiyat", gelen.Fiyat);
            komut.Parameters.AddWithValue("@basyili", gelen.Basim_yili);
            komut.Parameters.AddWithValue("@katno", gelen.Kat_no.Kat_id);
            komut.Parameters.AddWithValue("@yayno", gelen.Yayin_no.Yayin_id);
            komut.Parameters.AddWithValue("@kapakresmi", gelen.Kapak_resim);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override void Guncelle(IEntity varlik)
        {
            Kitap gelen = (Kitap)varlik;
            Baglan();
            komut = new SqlCommand("update Tbl_Kitap set Kitap_Ad=@ad,Kategori_No=@katno,Yazar_No=@yazar,Yayinevi_No=@yayno,Ozet=@ozet,Kapak_Resim=@resim,Fiyat=@fiyat,Basim_Yili=@basyili where Kitap_Id=@ıd",baglanti);
            komut.Parameters.AddWithValue("@ad", gelen.Kitap_ad);
            komut.Parameters.AddWithValue("@katno", gelen.Kat_no.Kat_id);
            komut.Parameters.AddWithValue("@yazar", gelen.Yazar_no.Yazar_ıd);
            komut.Parameters.AddWithValue("@yayno", gelen.Yayin_no.Yayin_id);
            komut.Parameters.AddWithValue("@ozet", gelen.Ozet);
            komut.Parameters.AddWithValue("@resim", gelen.Kapak_resim);
            komut.Parameters.AddWithValue("@fiyat", gelen.Fiyat);
            komut.Parameters.AddWithValue("@basyili", gelen.Basim_yili);
            komut.Parameters.AddWithValue("@id", gelen.Kitap_id);
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

        internal void Getir(Kitap ktp)
        {
            Baglan();
            komut = new SqlCommand("select *from Tbl_Kitap where Kitap_Ad=@ad", baglanti);
            komut.Parameters.AddWithValue("@ad", ktp.Kitap_ad);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                ktp.Kitap_id = Convert.ToInt16(okuyucu["Kitap_Id"]);
                ktp.Kat_no.Kat_id = Convert.ToInt16(okuyucu["Kategori_No"]);
                ktp.Yayin_no.Yayin_id = Convert.ToInt16(okuyucu["Yayin_No"]);
                ktp.Yazar_no.Yazar_ıd = Convert.ToInt16(okuyucu["Yazar_No"]);
                ktp.Kapak_resim = okuyucu["Kapak_Resim"].ToString();
                ktp.Fiyat = Convert.ToInt16(okuyucu["Fiyat"]);
                ktp.Ozet = okuyucu["Ozet"].ToString();
                ktp.Basim_yili = Convert.ToInt16(okuyucu["Basim_Yili"]);
            }
            baglanti.Close();
            baglanti.Dispose();
            
        }

        internal object DoldurKitap()
        {
            Baglan();
            komut = new SqlCommand("select *from Tbl_Kitap",baglanti);
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
