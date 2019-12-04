// Decompiled with JetBrains decompiler
// Type: PersonelApp.frmBul
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
    public class frmBul : Form
    {
        private IContainer components = (IContainer)null;
        private frmIslem frm;
        private TextBox txtUrunKod;
        private Label label1;
        private Button btnBul;
        private Label label2;

        public frmBul()
        {
            this.InitializeComponent();
        }

        public frmBul(frmIslem frm)
        {
            this.frm = frm;
            this.InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            UrunBL urunBl = new UrunBL();
            Urun urun1 = new Urun();
            Urun urun2 = urunBl.Urun_Bul(this.txtUrunKod.Text.Trim());
            this.frm.txtAd.Text = urun2.Urun_ad;
            this.frm.txtAdet.Text = urun2.Stok_mik.ToString();
            this.frm.txtFiyat.Text = urun2.Fiyat.ToString();
            this.frm.txtKod.Text = urun2.Urun_kodu;
            this.frm.txtRenk.Text = urun2.Urun_renk;
            this.frm.urunKod = urun2.Urun_kodu.ToString();
            this.frm.cmbUrunKategori.SelectedValue = (object)urun2.Urun_kategoriID;
            this.frm.btnEkle.Text = "Güncelle";
            this.frm.btnSil.Visible = true;
            this.frm.btnVazgec.Visible = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUrunKod = new TextBox();
            this.label1 = new Label();
            this.btnBul = new Button();
            this.label2 = new Label();
            this.SuspendLayout();
            this.txtUrunKod.Location = new Point(97, 32);
            this.txtUrunKod.Name = "txtUrunKod";
            this.txtUrunKod.Size = new Size(100, 20);
            this.txtUrunKod.TabIndex = 0;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0, 13);
            this.label1.TabIndex = 1;
            this.btnBul.Location = new Point(97, 58);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new Size(75, 23);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new EventHandler(this.btnBul_Click);
            this.label2.AutoSize = true;
            this.label2.Location = new Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Barkod";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(250, 112);
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.btnBul);
            this.Controls.Add((Control)this.label1);
            this.Controls.Add((Control)this.txtUrunKod);
            this.Name = nameof(frmBul);
            this.Text = nameof(frmBul);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
