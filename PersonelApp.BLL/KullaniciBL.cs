// Decompiled with JetBrains decompiler
// Type: PersonelApp.BLL.KullaniciBL
// Assembly: PersonelApp.BLL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 169F96C9-24CF-4AA2-8B1A-5AA582828C9B
// Assembly location: C:\Users\Dogukan\source\repos\PersonelApp\PersonelApp\bin\Debug\PersonelApp.BLL.dll

using PersonelApp.DAL;
using PersonelApp.MODEL;
using System;
using System.Data.SqlClient;

namespace PersonelApp.BLL
{
    public class KullaniciBL : IDisposable
    {
        private Helper hlp;

        public void Dispose()
        {
            this.hlp.Dispose();
        }

        public Kullanici Giris(Kullanici k)
        {
            this.hlp = new Helper();
            SqlDataReader sqlDataReader = this.hlp.ExecuteReader("Select YetkiID from Personel where KullaniciAdi=@KullaniciAd and Sifre=@Sifre", new SqlParameter[2]
            {
        new SqlParameter("@KullaniciAd", (object) k.KullaniciAdi),
        new SqlParameter("@Sifre", (object) k.Sifre)
            });
            if (sqlDataReader.Read())
                k.YetkiID = Convert.ToInt32(sqlDataReader["YetkiID"]);
            return k;
        }
    }
}
