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

namespace Seçim_İstatistik_ve_Grafik_Sistemi
{
    public partial class FRMOYGİRİS : Form
    {
        public FRMOYGİRİS()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U1QPTUU\\SQLEXPRESS;Initial Catalog=DBSECİMPROJE;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOyGiris_Click(object sender, EventArgs e)
        {
          baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBL_ILCE (İLCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValue("@P1", txtİlceAd.Text);
            komut.Parameters.AddWithValue("@P2", txtA.Text);
            komut.Parameters.AddWithValue("@P3", txtB.Text);
            komut.Parameters.AddWithValue("@P4", txtC.Text);
            komut.Parameters.AddWithValue("@P5", txtD.Text);
            komut.Parameters.AddWithValue("@P6", txtE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girşi Gerçekleşti");
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FRM_Grafikler fr = new FRM_Grafikler();
            fr.Show();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
