// Decompiled with JetBrains decompiler
// Type: PersonelApp.MODEL.Personel
// Assembly: PersonelApp.MODEL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C4F66F27-0340-47E9-A050-4D7A132F40B2
// Assembly location: C:\Users\Dogukan\source\repos\PersonelApp\PersonelApp\bin\Debug\PersonelApp.MODEL.dll

namespace PersonelApp.MODEL
{
    public class Personel
    {
        private string personel_ad;
        private string personel_soyad;
        private string personel_cinsiyet;
        private string personel_tc;

        public string Personel_tc
        {
            get
            {
                return this.personel_tc;
            }
            set
            {
                this.personel_tc = value;
            }
        }

        public string Personel_ad
        {
            get
            {
                return this.personel_ad;
            }
            set
            {
                this.personel_ad = value;
            }
        }

        public string Personel_soyad
        {
            get
            {
                return this.personel_soyad;
            }
            set
            {
                this.personel_soyad = value;
            }
        }

        public string Personel_cinsiyet
        {
            get
            {
                return this.personel_cinsiyet;
            }
            set
            {
                this.personel_cinsiyet = value;
            }
        }

        public string KullaniciAdi { get; set; }

        public string Sifre { get; set; }

        public int YetkiID { get; set; }

        public int PersonelID { get; set; }
    }
}
