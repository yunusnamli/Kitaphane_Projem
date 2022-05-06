using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;//Bunları yazki sql komutlarını algılasın.
using System.Configuration;//add references de ve system.configuration yanına tik koy
using System.Data.SqlClient;

namespace Kitaphane
{
    public class YayineviDb : TemelDb
    {
        public override void Ekle(IEntity varlik)
        {
            Yayinevi gelen = (Yayinevi)varlik;//veritabanından gelen yayievleri
            Baglan();
            komut = new SqlCommand("insert into Tbl_Yayinevi(Yayin_Ad,Yayin_Adres,Yayin_Tel,Yayin_Fax,Yayin_Email) values(@ad,@adres,@tel,@fax,@mail",baglanti);//atama yapıldı.
            komut.Parameters.AddWithValue("@ad", gelen.Yayin_ad);
            komut.Parameters.AddWithValue("@adres", gelen.Yayin_adres);
            komut.Parameters.AddWithValue("@tel", gelen.Yayin_tel);
            komut.Parameters.AddWithValue("@fax", gelen.Yayin_fax);
            komut.Parameters.AddWithValue("@mail", gelen.Yayin_email);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override void Guncelle(IEntity varlik)
        {
            Yayinevi gelen = (Yayinevi)varlik;
            Baglan();
            komut = new SqlCommand("update Tbl_Yayinevi set Yayin_Ad=@ad,Yayin_Adres=@adres,Yayin_Tel=@tel,Yayin_Fax=@fax,Yayin_Email=@mail",baglanti);
            komut.Parameters.AddWithValue("@id", gelen.Yayin_id);
            komut.Parameters.AddWithValue("@ad", gelen.Yayin_ad);
            komut.Parameters.AddWithValue("@adres", gelen.Yayin_adres);
            komut.Parameters.AddWithValue("@tel", gelen.Yayin_tel);
            komut.Parameters.AddWithValue("@fax", gelen.Yayin_fax);
            komut.Parameters.AddWithValue("@mail", gelen.Yayin_email);
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

        internal List<string> Doldur()
        {
         List<string> dizi = new List<string>();
       Baglan();
       komut = new SqlCommand("select Yayin_Ad from Tbl_Yayinevi", baglanti);
       komut.ExecuteNonQuery();
       okuyucu = komut.ExecuteReader();//veri tabanındakı yerlerı tek tek okıcak
            while(okuyucu.Read())
            {
                dizi.Add(okuyucu["Yayin_Ad"].ToString());
            }
            baglanti.Close();
            baglanti.Dispose();
            return dizi;
        }

        internal void Getir(Yayinevi yayin)
        {
            Baglan();
            komut=new SqlCommand("select*from Tbl_Yayinevi where Yayin_Ad=@ad",baglanti);
            komut.Parameters.AddWithValue("@ad",yayin.Yayin_ad);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                yayin.Yayin_id = Convert.ToInt32(okuyucu["Yayin_Id"]);
                yayin.Yayin_adres = okuyucu["Yayin_Adres"].ToString();
                yayin.Yayin_email = okuyucu["Yayin_Email"].ToString();
                yayin.Yayin_fax = okuyucu["Yayin_Fax"].ToString();
                yayin.Yayin_tel = okuyucu["Yayin_Tel"].ToString();   
            }
        }

        internal object DoldurYayinevi()
        {
            Baglan();
            komut = new SqlCommand("select *from Tbl_Yayinevi", baglanti);
            komut.ExecuteNonQuery();
            tablo =new DataTable();
            adaptor = new SqlDataAdapter();
            adaptor = new SqlDataAdapter(komut);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }
    }
}
