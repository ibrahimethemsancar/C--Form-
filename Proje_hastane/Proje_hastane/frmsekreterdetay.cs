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
    public partial class frmsekreterdetay : Form
    {
        public frmsekreterdetay()
        {
            InitializeComponent();
        }
        public string tcnumara;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmsekreterdetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tcnumara;

            // Ad Soyad
            SqlCommand komut1 = new SqlCommand("select SekreterAdSoyad from tbl_sekreter where sekretertc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();
            }
            bgl.ToString().ToString();

            //Branşları datagride aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select bransad from tbl_branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            // doktorları listeye aktarma

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (doktorad + ' ' + doktorsoyad) as 'doktorlar' , doktorbrans from tbl_doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //branşı comboboxa aktarma

            SqlCommand komut = new SqlCommand("select bransad from tbl_branslar", bgl.baglanti());

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbbrans.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into tbl_randevular (randevutarih,randevusaat,randevubrans,randevudoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("randevu oluşturuldu");
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("select doktorad,doktorsoyad from tbl_doktorlar where doktorbrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbdoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();

        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_duyurular (duyuru) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", rchduyuru.Text);
            
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("duyuru oluşturuldu");
        }

        private void btndoktorguncelle_Click(object sender, EventArgs e)
        {
            frmdoktorpaneli gec = new frmdoktorpaneli();
            gec.Show();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            frmbrans gec = new frmbrans();
            gec.Show();
        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            frmrandevulistesi gec = new frmrandevulistesi();
            gec.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmduyurular gec = new frmduyurular();
            gec.Show();
        }
    }
}
