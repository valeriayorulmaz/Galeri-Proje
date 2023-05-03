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
    public partial class AracForm : Form
    {
        public AracForm()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Araclar save = new Araclar();
            save.Fiyat = Convert.ToInt32(textBox1.Text);
            save.Adet = Convert.ToInt32(textBox2.Text);
            save.Marka = textBox3.Text;
            save.Model = textBox4.Text;
            save.Yıl = Convert.ToInt32(textBox5.Text);
            save.SubeNo = Convert.ToInt32(textBox6.Text);
            save.MüsteriNo = Convert.ToInt32(textBox7.Text);
            db.Araclars.Add(save);
            db.SaveChanges();
            dataGridView1.DataSource = db.Araclars.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Araclars.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            var guncelle = db.Araclars.Where(x => x.AracNo == id).FirstOrDefault();
            guncelle.Fiyat = Convert.ToInt32(textBox1.Text);
            guncelle.Adet = Convert.ToInt32(textBox2.Text);
            guncelle.Marka = textBox3.Text;
            guncelle.Model = textBox4.Text;
            guncelle.Yıl = Convert.ToInt32(textBox5.Text);
            guncelle.SubeNo = Convert.ToInt32(textBox6.Text);
            guncelle.MüsteriNo = Convert.ToInt32(textBox7.Text);
            db.SaveChanges();
            dataGridView1.DataSource = db.Araclars.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            var sil = db.Araclars.Where(a => a.AracNo == id).FirstOrDefault();
            db.Araclars.Remove(sil);
            db.SaveChanges();
            dataGridView1.DataSource = db.Araclars.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Araclars.Where(x => x.Marka.Contains(textBox3.Text)).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Tag = row.Cells["AracNo"].Value.ToString();
            textBox1.Text = row.Cells["Fiyat"].Value.ToString();
            textBox2.Text = row.Cells["Adet"].Value.ToString();
            textBox3.Text = row.Cells["Marka"].Value.ToString();
            textBox4.Text = row.Cells["Model"].Value.ToString();
            textBox5.Text = row.Cells["Yıl"].Value.ToString();
            textBox6.Text = row.Cells["SubeNo"].Value.ToString();
            textBox7.Text = row.Cells["MüsteriNo"].Value.ToString();

        }

        private void AracForm_Load(object sender, EventArgs e)
        {
           
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlama rapor = new Raporlama();
            rapor.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
