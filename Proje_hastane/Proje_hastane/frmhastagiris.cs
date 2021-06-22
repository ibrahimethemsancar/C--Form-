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
    public partial class frmhastagiris : Form
    {
        public frmhastagiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi baglanti = new sqlbaglantisi();

        private void lnkuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmhastakayit gec = new frmhastakayit();
            gec.Show();
            this.Hide();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select *from tbl_hastalar where hastatc=@p1 and hastasifre=@p2", baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastadetay gec = new FrmHastadetay();
                gec.tc = msktc.Text;
                gec.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC no veya şifre girdiniz");
            }
            baglanti.baglanti().Close();

        }
    }
}
