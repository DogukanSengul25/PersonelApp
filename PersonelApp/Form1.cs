// Decompiled with JetBrains decompiler
// Type: PersonelApp.Form1
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
    public class Form1 : Form
    {
        private IContainer components = (IContainer)null;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnGiris;
        private Label label2;
        private Label label3;

        public Form1()
        {
            this.InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            switch (new KullaniciBL().Giris(new Kullanici()
            {
                KullaniciAdi = this.textBox1.Text.Trim(),
                Sifre = this.textBox2.Text.Trim()
            }).YetkiID)
            {
                case 1:
                    frmIslem frmIslem = new frmIslem();
                    frmIslem.groupBox2.Visible = true;
                    frmIslem.Show();
                    this.Hide();
                    break;
                case 2:
                    new frmIslem().Show();
                    this.Hide();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label3.Hide();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
            this.label1 = new Label();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.btnGiris = new Button();
            this.label2 = new Label();
            this.label3 = new Label();
            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)162);
            this.label1.Location = new Point(113, 76);
            this.label1.Name = "label1";
            this.label1.Size = new Size(126, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            this.textBox1.Location = new Point(262, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(122, 20);
            this.textBox1.TabIndex = 1;
            this.textBox2.Location = new Point(262, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new Size(122, 20);
            this.textBox2.TabIndex = 2;
            this.btnGiris.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)162);
            this.btnGiris.Location = new Point(261, 150);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new Size(123, 34);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new EventHandler(this.btnGiris_Click);
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)162);
            this.label2.Location = new Point(113, 113);
            this.label2.Name = "label2";
            this.label2.Size = new Size(61, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.FromArgb(192, 0, 0);
            this.label3.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)162);
            this.label3.ForeColor = Color.Snow;
            this.label3.Location = new Point(114, 205);
            this.label3.Name = "label3";
            this.label3.Size = new Size(314, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parola veya Kullanıcı Adı Yanlış !";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
            this.ClientSize = new Size(563, 450);
            this.Controls.Add((Control)this.label3);
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.btnGiris);
            this.Controls.Add((Control)this.textBox2);
            this.Controls.Add((Control)this.textBox1);
            this.Controls.Add((Control)this.label1);
            this.Name = nameof(Form1);
            this.Text = nameof(Form1);
            this.Load += new EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
