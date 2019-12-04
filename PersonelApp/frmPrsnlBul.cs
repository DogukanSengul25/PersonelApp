// Decompiled with JetBrains decompiler
// Type: PersonelApp.frmPrsnlBul
// Assembly: PersonelApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3BC205F9-70FF-4C45-AA5E-543DF553AE14
// Assembly location: C:\Users\Dogukan\source\repos\PersonelApp\PersonelApp\bin\Debug\PersonelApp.exe

using PersonelApp.BLL;
using PersonelApp.MODEL;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PersonelApp
{
    public class frmPrsnlBul : Form
    {
        private IContainer components = (IContainer)null;
        private frmIslem frm;
        private TextBox txtTc;
        private Button btnBul;

        public frmPrsnlBul()
        {
            this.InitializeComponent();
        }

        public frmPrsnlBul(frmIslem frm)
        {
            this.InitializeComponent();
            this.frm = frm;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Personel per = new Personel();
            PersonelBL personelBl = new PersonelBL();
            per.Personel_tc = this.txtTc.Text.Trim();
            Personel personel = personelBl.PersonelBul(per);
            this.frm.personelID = personel.PersonelID;
            this.frm.txtprsnlAd.Text = personel.Personel_ad;
            this.frm.txtprsnlCinsiyet.Text = personel.Personel_cinsiyet;
            this.frm.txtprsnlSoyad.Text = personel.Personel_soyad;
            this.frm.txtprsnlKullanici.Text = personel.KullaniciAdi;
            this.frm.txtprsnlSifre.Text = personel.Sifre;
            this.frm.txtprsnlTc.Text = personel.Personel_tc;
            this.frm.cmbprsnlYetki.SelectedValue = (object)personel.YetkiID;
            this.frm.btnPrsnlEkle.Text = "Güncelle";
            this.frm.btnPrsnlSil.Visible = true;
            this.frm.btnPrsnlVazgec.Visible = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTc = new TextBox();
            this.btnBul = new Button();
            this.SuspendLayout();
            this.txtTc.Location = new Point(69, 37);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new Size(121, 20);
            this.txtTc.TabIndex = 0;
            this.btnBul.Location = new Point(115, 78);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new Size(75, 23);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "button1";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new EventHandler(this.btnBul_Click);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(253, 140);
            this.Controls.Add((Control)this.btnBul);
            this.Controls.Add((Control)this.txtTc);
            this.Name = nameof(frmPrsnlBul);
            this.Text = nameof(frmPrsnlBul);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
