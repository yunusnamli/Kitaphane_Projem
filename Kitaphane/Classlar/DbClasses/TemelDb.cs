using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;//Bunları yazki sql komutlarını algılasın.
using System.Configuration;//add references de ve system.configuration yanına tik koy
using System.Data.SqlClient;

namespace Kitaphane
{
    public abstract class TemelDb
    {
        //toolboxdan abstract class fln ekleyerek acılır.
        string yol;//Projede kullan
        public SqlConnection baglanti;
        public SqlDataReader okuyucu;
        public SqlDataAdapter adaptor;
        public DataTable tablo;
        public SqlCommand komut;
        //view tıkla server explorer tıkla ve +priz işaretine tıklayıp serverını bul sonra veri tabanına tıkla server explorerdan ve propertiesden orayı kopyalave app.confige girip
        //<?xml version="1.0" encoding="utf-8" ?>
//<configuration>
//  <configSections>
//  </configSections>
//  <connectionStrings>
    

//    <add  name="VeriYolu" connectionString="Data Source=WEB1-SERVER2\SQLEXPRESS;Initial Catalog=Kitaphane11;Persist Security Info=True;User ID=nt11;Password=***********"/>
//  </connectionStrings>
//</configuration>                 
        //Bunları bulundur.
        public TemelDb()
        {
            yol = ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString;

        }
        public void Baglan()
        {
            baglanti = new SqlConnection(yol);
            if (baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        abstract public void Ekle(IEntity varlik);
        abstract public void Guncelle(IEntity varlik);
        abstract public void Sil(IEntity varlik);
        abstract public void Ara(IEntity varlik);
        //abstract ları kategoridb fln hepsini sag tıkla intelli sense tıkla implement et
        //images dosyasını ctrl c yapıp solution explorer yapıştır.
    }
}
