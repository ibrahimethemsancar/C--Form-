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
    public partial class frmdoktorpaneli : Form
    {
        public frmdoktorpaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmdoktorpaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from tbl_doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand komut = new SqlCommand("select bransad from tbl_branslar", bgl.baglanti());

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_doktorlar (doktorad,doktorsoyad,doktorbrans,doktortc,doktorsifre)  values(@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtid.Text);
            komut.Parameters.AddWithValue("@d2", textBox1.Text);
            komut.Parameters.AddWithValue("@d3", comboBox1.Text);
            komut.Parameters.AddWithValue("@d4", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@d5", textBox2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("doktor eklendi");
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_doktorlar where doktortc=@d1", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", maskedTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("kayıt silindi", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_doktorlar set doktorad=@d1,doktorsoyad=@d2, doktorbrans=@d3,doktorsifre=@d4 where doktortc=@d5", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtid.Text);
            komut.Parameters.AddWithValue("@d2", textBox1.Text);
            komut.Parameters.AddWithValue("@d3", comboBox1.Text);
            komut.Parameters.AddWithValue("@d4", textBox2.Text);
            komut.Parameters.AddWithValue("@d5", maskedTextBox1.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("doktor bilgisi güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
