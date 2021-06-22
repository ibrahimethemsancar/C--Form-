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
    public partial class frmdoktorgiris : Form
    {
        public frmdoktorgiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select *from tbl_doktorlar where doktortc=@d1 and doktorsifre=@d2", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@d2", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmdoktordetay gec = new frmdoktordetay();
                gec.tcno = maskedTextBox1.Text;
                gec.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc ve şifre girdiniz", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            bgl.baglanti().Close();

        }
    }
}
