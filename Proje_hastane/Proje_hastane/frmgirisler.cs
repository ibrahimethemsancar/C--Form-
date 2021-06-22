using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_hastane
{
    public partial class frmgirisler : Form
    {
        public frmgirisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmhastagiris gec = new frmhastagiris();
            gec.Show();
             this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmdoktorgiris fr = new frmdoktorgiris();
            fr.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmsekretergiris gec = new frmsekretergiris();
            gec.Show();
            this.Hide();
        }
    }
}
