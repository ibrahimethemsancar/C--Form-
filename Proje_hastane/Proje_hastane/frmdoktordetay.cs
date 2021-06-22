using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_hastane
{
    public partial class frmdoktordetay : Form
    {
        public frmdoktordetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tcno;

        private void frmdoktordetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tcno;

            //doktor ad soyad
            SqlCommand komut = new SqlCommand("select doktorad,doktorsoyad from tbl_doktorlar where doktortc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tcno);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from tbl_randevular where randevudoktor='" + lbladsoyad.Text+ "'", bgl.baglanti());
            
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            frmdoktorbilgiduzenle gec = new frmdoktorbilgiduzenle();
            gec.tcno = lbltc.Text;
            gec.Show();
            this.Hide();
        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            frmduyurular gec = new frmduyurular();
            gec.Show();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
