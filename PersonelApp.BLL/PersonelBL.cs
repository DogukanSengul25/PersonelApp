// Decompiled with JetBrains decompiler
// Type: PersonelApp.BLL.PersonelBL
// Assembly: PersonelApp.BLL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 169F96C9-24CF-4AA2-8B1A-5AA582828C9B
// Assembly location: C:\Users\Dogukan\source\repos\PersonelApp\PersonelApp\bin\Debug\PersonelApp.BLL.dll

using PersonelApp.DAL;
using PersonelApp.MODEL;
using System;
using System.Data.SqlClient;

namespace PersonelApp.BLL
{
    public class PersonelBL
    {
        private Helper hlp = new Helper();

        public bool Personel_Ekle(Personel personel)
        {
            return this.hlp.ExecuteNonQuery("Insert into Personel values(@Adı,@Soyadı,@TC_Kimlik,@Cinsiyet,@KullaniciAdi,@Sifre,@YetkiID)", new SqlParameter[7]
            {
        new SqlParameter("@KullaniciAdi", (object) personel.KullaniciAdi),
        new SqlParameter("@Sifre", (object) personel.Sifre),
        new SqlParameter("@YetkiID", (object) personel.YetkiID),
        new SqlParameter("@Adı", (object) personel.Personel_ad),
        new SqlParameter("@Soyadı", (object) personel.Personel_soyad),
        new SqlParameter("@TC_Kimlik", (object) personel.Personel_tc),
        new SqlParameter("@Cinsiyet", (object) personel.Personel_cinsiyet)
            }) > 0;
        }

        public Personel PersonelBul(Personel per)
        {
            SqlDataReader sqlDataReader = this.hlp.ExecuteReader("Select * from Personel where TC_Kimlik=@TC", new SqlParameter[1]
            {
        new SqlParameter("@TC", (object) per.Personel_tc)
            });
            if (sqlDataReader.Read())
            {
                per.Personel_ad = sqlDataReader["Adı"].ToString();
                per.Personel_soyad = sqlDataReader["Soyadı"].ToString();
                per.Personel_cinsiyet = sqlDataReader["Cinsiyet"].ToString();
                per.Personel_tc = sqlDataReader["TC_Kimlik"].ToString();
                per.KullaniciAdi = sqlDataReader["KullaniciAdi"].ToString();
                per.Sifre = sqlDataReader["Sifre"].ToString();
                per.YetkiID = Convert.ToInt32(sqlDataReader["YetkiID"]);
                per.PersonelID = Convert.ToInt32(sqlDataReader["ID"]);
            }
            sqlDataReader.Close();
            return per;
        }

        public bool Personel_Guncelle(Personel personel)
        {
            return this.hlp.ExecuteNonQuery("UPDATE into Personel Set Personel_ad=@Adı,Personel_soyad=@Soyadı,personel_tc=@TC_Kimlik,personel_cinsiyet=@Cinsiyet)", new SqlParameter[4]
            {
        new SqlParameter("@Adı", (object) personel.Personel_ad),
        new SqlParameter("@Soyadı", (object) personel.Personel_soyad),
        new SqlParameter("@TC_Kimlik", (object) personel.Personel_tc),
        new SqlParameter("@Cinsiyet", (object) personel.Personel_cinsiyet)
            }) > 0;
        }

        public bool Personel_Sil(Personel personel)
        {
            return this.hlp.ExecuteNonQuery("Delete from Personel where ID=@ID", new SqlParameter[1]
            {
        new SqlParameter("@ID", (object) personel.PersonelID)
            }) > 0;
        }

        public void Dispose()
        {
            this.hlp.Dispose();
        }
    }
}
