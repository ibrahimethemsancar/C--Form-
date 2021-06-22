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
    public partial class frmsekretergiris : Form
    {
        public frmsekretergiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select *from tbl_sekreter where Sekretersifre=@p1 and sekretertc=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmsekreterdetay fr = new frmsekreterdetay();
                fr.tcnumara = maskedTextBox1.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı tc veya şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
