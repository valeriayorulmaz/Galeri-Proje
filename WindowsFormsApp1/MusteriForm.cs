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
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }

        AGaleriEntities1 db = new AGaleriEntities1();

        private void araçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracForm arac = new AracForm();
            arac.Show();
            this.Hide();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriForm musteri = new MusteriForm();
            musteri.Show();
            this.Hide();
        }

        private void şubelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubeForm sube = new SubeForm();
            sube.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Musteris.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri save = new Musteri();
            save.AdSoyad = textBox1.Text;
            save.Telefon = Convert.ToInt32(textBox2.Text);
            save.DTarih = Convert.ToDateTime(dateTimePicker1.Text);
            save.Bakiye = Convert.ToInt32(textBox4.Text);
            save.Adres = textBox5.Text;
            db.Musteris.Add(save);
            db.SaveChanges();
            dataGridView1.DataSource = db.Musteris.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            var guncelle = db.Musteris.Where(x => x.MusteriNo == id).FirstOrDefault();
            guncelle.AdSoyad = textBox1.Text;
            guncelle.Telefon = Convert.ToInt32(textBox2.Text);
            guncelle.DTarih = Convert.ToDateTime(dateTimePicker1.Text);
            guncelle.Bakiye = Convert.ToInt32(textBox4.Text);
            guncelle.Adres = textBox5.Text;
            db.SaveChanges();
            dataGridView1.DataSource = db.Musteris.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            var sil = db.Musteris.Where(a => a.MusteriNo == id).FirstOrDefault();
            db.Musteris.Remove(sil);
            db.SaveChanges();
            dataGridView1.DataSource = db.Musteris.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Tag = row.Cells["MusteriNo"].Value.ToString();
            textBox1.Text = row.Cells["AdSoyad"].Value.ToString();
            textBox2.Text = row.Cells["Telefon"].Value.ToString();
            dateTimePicker1.Text = row.Cells["DTarih"].Value.ToString();
            textBox4.Text = row.Cells["Bakiye"].Value.ToString();
            textBox5.Text = row.Cells["Adres"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {

        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlama rapor = new Raporlama();
            rapor.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Musteris.Where(x => x.AdSoyad.Contains(textBox1.Text)).ToList();

        }
    }
}
