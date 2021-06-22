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
    public partial class frmbrans : Form
    {
        public frmbrans()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void frmbrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from tbl_branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_branslar (bransad) values (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", textBox1.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("branş eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_branslar where bransid=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş silindi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update  tbl_branslar set bransad=@p1 where bransid=@p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş güncellendi");
        }
    }
}
