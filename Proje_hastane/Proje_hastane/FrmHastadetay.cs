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
    public partial class FrmHastadetay : Form
    {
        public FrmHastadetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void lbltc_Click(object sender, EventArgs e)
        {

        }

        private void FrmHastadetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;
            //Ad Soyad çekme
            SqlCommand komut = new SqlCommand("select HastaAd,HastaSoyad from tbl_hastalar where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from tbl_randevular where HastaTc = " + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //branşları çekme
            SqlCommand komut2 = new SqlCommand("select BransAd from tbl_branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from tbl_doktorlar where Doktorbrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbdoktor.Items.Add(dr[0] + " " + dr[1]);

            }
            bgl.baglanti().Close();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *from tbl_randevular where randevubrans='" + cmbbrans.Text +"'"+ " and randevudoktor= '"+ cmbdoktor.Text+"'and randevudurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void lnkbilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmbilgiduzenle gec = new frmbilgiduzenle();
            gec.tc = lbltc.Text;
            gec.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtİd.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void randevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_randevular set randevudurum=1,hastatc=@p1, hastasikayet=@p2 where randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            komut.Parameters.AddWithValue("@p2", rchsikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtİd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu alındı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
