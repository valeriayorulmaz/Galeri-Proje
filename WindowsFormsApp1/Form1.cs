using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AGaleriEntities1 db = new AGaleriEntities1();

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        public bool Giris(string kadi, string sifre)
        {
            var login = from kullanici in db.Kullanicis
                        where kullanici.KullaniciAd == kadi &&
                        kullanici.KullaniciSifre == sifre
                        select kullanici;
            
            if (login.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Giris(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Giriş Başarılı");

                AracForm go = new AracForm();
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kullanici save = new Kullanici();
            save.KullaniciAd = textBox4.Text;
            save.KullaniciSifre = textBox3.Text;
            save.Telefon = Convert.ToInt32(textBox6.Text);
            save.Adres = textBox5.Text;
            save.Mail = textBox7.Text;
            save.SubeNo = Convert.ToInt32(textBox8.Text);
            db.Kullanicis.Add(save);
            db.SaveChanges();

            AracForm menu = new AracForm();
            menu.Show();
            this.Hide();
        }
    }
}
