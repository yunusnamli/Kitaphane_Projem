using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Kitaphane
{
    public class UyeDb : TemelDb
    {
        public override void Ekle(IEntity varlik)
        {
            Uye gelen = (Uye)varlik;
            Baglan();
            komut = new SqlCommand("insert into Tbl_Uye(Uye_Ad,Sicil_No,Uye_Adres,Uye_Mail,Uye_Tel) valuse(@ad,@sicilno,@adres,@email,@tel", baglanti);
            komut.Parameters.AddWithValue("@ad",gelen.Uye_ad);
            komut.Parameters.AddWithValue("@sicilno", gelen.Sicil_no);
            komut.Parameters.AddWithValue("@adres", gelen.Uye_adres);
            komut.Parameters.AddWithValue("@email",gelen.Uye_email);
            komut.Parameters.AddWithValue("@tel",gelen.Uye_tel);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override void Guncelle(IEntity varlik)
        {
            Uye gelen = (Uye)varlik;
            Baglan();
            komut = new SqlCommand("update Tbl_Uye set Uye_Ad=@ad,Sicil_No=@sicilno,Uye_Adres=@adres,Uye_Email=@email,Uye_Tel=@tel where Uye_Id=@Id", baglanti);
            komut.Parameters.AddWithValue("@ad", gelen.Uye_ad);
            komut.Parameters.AddWithValue("@sicilno", gelen.Sicil_no);
            komut.Parameters.AddWithValue("@adres", gelen.Uye_adres);
            komut.Parameters.AddWithValue("@email", gelen.Uye_email);
            komut.Parameters.AddWithValue("@tel", gelen.Uye_tel);
            komut.Parameters.AddWithValue("@id",gelen.Uye_id);
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

        internal void Getir(Uye uy)
        {
            Baglan();
            komut = new SqlCommand("select *from Tbl_Uye where Sicil_No=@sicilno", baglanti);
            komut.Parameters.AddWithValue("@sicil", uy.Sicil_no.ToString());
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                uy.Uye_ad = okuyucu["Uye_Ad"].ToString();
                uy.Uye_adres = okuyucu["Uye_Adres"].ToString();
                uy.Uye_id = Convert.ToInt16(okuyucu["Uye_Id"]);
                uy.Uye_email = okuyucu["Uye_Email"].ToString();
                uy.Uye_tel = okuyucu["Uye_Tel"].ToString();
                uy.Sicil_no =Convert.ToInt16(okuyucu["Sicil_No"].ToString());
            }
            baglanti.Close();
            baglanti.Dispose();
        }

        internal void GetirAd(Uye uy)
        {
            Baglan();
            komut = new SqlCommand("select *from Tbl_Uye where Uye_Ad=@ad", baglanti);
            komut.Parameters.AddWithValue("@ad", uy.Uye_ad);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                uy.Uye_ad = okuyucu["Uye_Ad"].ToString();
                uy.Uye_adres = okuyucu["Uye_Adres"].ToString();
                uy.Uye_id = Convert.ToInt16(okuyucu["Uye_Id"]);
                uy.Uye_email = okuyucu["Uye_Email"].ToString();
                uy.Uye_tel = okuyucu["Uye_Tel"].ToString();
                uy.Sicil_no = Convert.ToInt16(okuyucu["Sicil_No"].ToString());
            }
            baglanti.Close();
            baglanti.Dispose();
        }

        internal void Bul(Uye uy)
        {
            Baglan();
            komut = new SqlCommand("select Uye_Id,Uye_Ad from where Sicil_No=@sicil", baglanti);
            komut.Parameters.AddWithValue("@sicil",uy.Sicil_no);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                uy.Uye_ad = okuyucu["Uye_Ad"].ToString();
                uy.Uye_id = Convert.ToInt16(okuyucu["Uye_Id"]);

            }
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}
