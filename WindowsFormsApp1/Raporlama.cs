using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Raporlama : Form
    {
        public Raporlama()
        {
            InitializeComponent();
        }
        AGaleriEntities1 db = new AGaleriEntities1();

        SqlConnection conn = new SqlConnection("Server=DESKTOP-76I04D2\\SQLEXPRESS;Database=AGaleri;Integrated Security=true");

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

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlama rapor = new Raporlama();
            rapor.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "S1";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "S2";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "S3";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "S4";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "S5";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
