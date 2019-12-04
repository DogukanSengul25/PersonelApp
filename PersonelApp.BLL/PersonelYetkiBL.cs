// Decompiled with JetBrains decompiler
// Type: PersonelApp.BLL.PersonelYetkiBL
// Assembly: PersonelApp.BLL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 169F96C9-24CF-4AA2-8B1A-5AA582828C9B
// Assembly location: C:\Users\Dogukan\source\repos\PersonelApp\PersonelApp\bin\Debug\PersonelApp.BLL.dll

using PersonelApp.DAL;
using PersonelApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PersonelApp.BLL
{
    public class PersonelYetkiBL
    {
        private Helper hlp = new Helper();

        public List<PersonelYetki> YetkiListesi()
        {
            SqlDataReader sqlDataReader = this.hlp.ExecuteReader("Select ID, YetkiAd from PersonelYetki", (SqlParameter[])null);
            List<PersonelYetki> personelYetkiList = new List<PersonelYetki>();
            while (sqlDataReader.Read())
                personelYetkiList.Add(new PersonelYetki()
                {
                    YetkiAd = sqlDataReader["YetkiAd"].ToString(),
                    YetkiID = Convert.ToInt32(sqlDataReader["ID"])
                });
            sqlDataReader.Close();
            personelYetkiList.Insert(0, new PersonelYetki()
            {
                YetkiAd = "Seçiniz"
            });
            return personelYetkiList;
        }
    }
}
