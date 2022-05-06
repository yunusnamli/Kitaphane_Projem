using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;//Bunları yazki sql komutlarını algılasın.
using System.Configuration;//add references de ve system.configuration yanına tik koy
using System.Data.SqlClient;
namespace Kitaphane
{
    public class KategoriDb : TemelDb
    {
        public override void Ekle(IEntity varlik)
        {
   Kategori gelen = (Kategori)varlik;
   Baglan();
   komut = new SqlCommand("insert into Tbl_Kategori values(@Kat_Ad)",baglanti);
   komut.Parameters.AddWithValue("@katad", gelen.Kat_ad);
   komut.ExecuteNonQuery();
   baglanti.Close();
   baglanti.Dispose();
        }

        public override void Guncelle(IEntity varlik)
        {
      Kategori gelen = (Kategori)varlik;
      Baglan();
      komut = new SqlCommand("update Tbl_Kategori set Kat_Ad=@katad where Kat_Id=@id",baglanti);
      komut.Parameters.AddWithValue("@katad", gelen.Kat_ad);//@ işareti burdan 
      komut.Parameters.AddWithValue("@id", gelen.Kat_id);
      baglanti.Close();
      baglanti.Dispose();
                //@ işareti burdan sql giden veri
        }

        public override void Sil(IEntity varlik)
        {
            throw new NotImplementedException();
        }

        public override void Ara(IEntity varlik)
        {
            throw new NotImplementedException();
        }

        internal object Listele()
        {
            Baglan();
            komut = new SqlCommand("select *from Tbl_Kategori", baglanti);
            komut.ExecuteNonQuery();
            tablo = new DataTable();
            adaptor = new SqlDataAdapter();
            adaptor = new SqlDataAdapter(komut);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;

        }

        internal object DoldurKategori()
        {
            Baglan();
            komut = new SqlCommand("Select *from Tbl_Kategori", baglanti);
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
