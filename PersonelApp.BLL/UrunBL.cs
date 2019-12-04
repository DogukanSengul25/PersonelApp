// Decompiled with JetBrains decompiler
// Type: PersonelApp.BLL.UrunBL
// Assembly: PersonelApp.BLL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 169F96C9-24CF-4AA2-8B1A-5AA582828C9B
// Assembly location: C:\Users\Dogukan\source\repos\PersonelApp\PersonelApp\bin\Debug\PersonelApp.BLL.dll

using PersonelApp.DAL;
using PersonelApp.MODEL;
using System;
using System.Data.SqlClient;

namespace PersonelApp.BLL
{
    public class UrunBL : IDisposable
    {
        private Helper hlp = new Helper();

        public bool Urun_Ekle(Urun urun)
        {
            return this.hlp.ExecuteNonQuery("Insert into Urun_Tablosu values(@Urun_Ad,@Urun_Kod,@Urun_Renk,@Urun_Stok,@Urun_Fiyat,@UrunKatID)", new SqlParameter[6]
            {
        new SqlParameter("@UrunKatID", (object) urun.Urun_kategoriID),
        new SqlParameter("@Urun_Kod", (object) urun.Urun_kodu),
        new SqlParameter("@Urun_Renk", (object) urun.Urun_renk),
        new SqlParameter("@Urun_Ad", (object) urun.Urun_ad),
        new SqlParameter("@Urun_Stok", (object) urun.Stok_mik),
        new SqlParameter("@Urun_Fiyat", (object) urun.Fiyat)
            }) > 0;
        }

        public bool Urun_Guncelle(Urun urun)
        {
            return this.hlp.ExecuteNonQuery("UPDATE into Urun_Tablosu SET Urun_kodu=@Urun_Kod,Urun_renk=@Urun_Renk,Urun_ad=@Urun_Ad,Stok_mik=@Urun_Stok,urun.Fiyat=@Urun_Fiyat WHERE urun_kodu=@Urun_Kod)", new SqlParameter[5]
            {
        new SqlParameter("@Urun_Kod", (object) urun.Urun_kodu),
        new SqlParameter("@Urun_Renk", (object) urun.Urun_renk),
        new SqlParameter("@Urun_Ad", (object) urun.Urun_ad),
        new SqlParameter("@Urun_Stok", (object) urun.Stok_mik),
        new SqlParameter("@Urun_Fiyat", (object) urun.Fiyat)
            }) > 0;
        }

        public Urun Urun_Bul(string kod)
        {
            Urun urun = new Urun();
            SqlDataReader sqlDataReader = this.hlp.ExecuteReader("Select * from Urun_Tablosu WHERE Urun_Kod=@Urun_Kod", new SqlParameter[1]
            {
        new SqlParameter("@Urun_Kod", (object) kod)
            });
            if (sqlDataReader.Read())
            {
                urun.Urun_ad = sqlDataReader["Urun_Ad"].ToString();
                urun.Urun_kodu = kod;
                urun.Urun_renk = sqlDataReader["Urun_Renk"].ToString();
                urun.Fiyat = Convert.ToInt32(sqlDataReader["Urun_Fiyat"]);
                urun.Stok_mik = Convert.ToInt32(sqlDataReader["Urun_Stok"]);
                urun.Urun_kategoriID = Convert.ToInt32(sqlDataReader["Urun_KategoriID"]);
            }
            return urun;
        }

        public bool Urun_Sil(Urun urun)
        {
            return this.hlp.ExecuteNonQuery("Delete from Urun_Tablosu where Urun_Kod=@urun_kodu", new SqlParameter[1]
            {
        new SqlParameter("@urun_kodu", (object) urun.Urun_kodu)
            }) > 0;
        }

        public void Dispose()
        {
            this.hlp.Dispose();
        }
    }
}
