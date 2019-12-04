// Decompiled with JetBrains decompiler
// Type: PersonelApp.MODEL.Urun
// Assembly: PersonelApp.MODEL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C4F66F27-0340-47E9-A050-4D7A132F40B2
// Assembly location: C:\Users\Dogukan\source\repos\PersonelApp\PersonelApp\bin\Debug\PersonelApp.MODEL.dll

namespace PersonelApp.MODEL
{
    public class Urun
    {
        private string urun_kodu;
        private string urun_ad;
        private string urun_renk;
        private int stok_mik;
        private int fiyat;

        public int Urun_kategoriID { get; set; }

        public string Urun_kodu
        {
            get
            {
                return this.urun_kodu;
            }
            set
            {
                this.urun_kodu = value.Trim();
            }
        }

        public string Urun_ad
        {
            get
            {
                return this.urun_ad;
            }
            set
            {
                this.urun_ad = value.Trim();
            }
        }

        public int Stok_mik
        {
            get
            {
                return this.stok_mik;
            }
            set
            {
                this.stok_mik = value;
            }
        }

        public int Fiyat
        {
            get
            {
                return this.fiyat;
            }
            set
            {
                this.fiyat = value;
            }
        }

        public string Urun_renk
        {
            get
            {
                return this.urun_renk;
            }
            set
            {
                this.urun_renk = value.Trim();
            }
        }
    }
}
