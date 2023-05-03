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
    public partial class SubeForm : Form
    {
        public SubeForm()
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
            dataGridView1.DataSource = db.Subelers.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subeler save = new Subeler();
            save.Ad = textBox1.Text;
            save.CalisanSayisi = Convert.ToInt32(textBox2.Text);
            save.Ciro = Convert.ToInt32(textBox3.Text);
            db.Subelers.Add(save);
            db.SaveChanges();
            dataGridView1.DataSource = db.Subelers.ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            var guncelle = db.Subelers.Where(x=>x.SubeNo == id).FirstOrDefault();
            guncelle.Ad = textBox1.Text;
            guncelle.CalisanSayisi = Convert.ToInt32(textBox2.Text);
            guncelle.Ciro = Convert.ToInt32(textBox3.Text);
            db.SaveChanges();
            dataGridView1.DataSource = db.Subelers.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            var sil = db.Subelers.Where(a => a.SubeNo == id).FirstOrDefault();
            db.Subelers.Remove(sil);
            db.SaveChanges();
            dataGridView1.DataSource = db.Subelers.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Tag = row.Cells["SubeNo"].Value.ToString();
            textBox1.Text = row.Cells["Ad"].Value.ToString();
            textBox2.Text = row.Cells["CalisanSayisi"].Value.ToString();
            textBox3.Text = row.Cells["Ciro"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            dataGridView1.DataSource = db.Subelers.Where(x => x.Ad.Contains(textBox3.Text)).ToList();

        }
    }
}
