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
    public partial class frmbilgiduzenle : Form
    {
        public frmbilgiduzenle()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmbilgiduzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = tc;
            SqlCommand komut = new SqlCommand("select * from tbl_hastalar where hastatc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                msktelefon.Text = dr[4].ToString();
                txtsifre.Text = dr[5].ToString();
                cmbcinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tbl_hastalar set HastaAd=@p1,HastaSoyad=@p2,Hastatelefon=@p3,Hastasifre=@p4,hastacinsiyet=@p5 where hastatc=@p6", bgl.baglanti());    
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut.Parameters.AddWithValue("@p5", cmbcinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", msktc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
        }
    }
}
