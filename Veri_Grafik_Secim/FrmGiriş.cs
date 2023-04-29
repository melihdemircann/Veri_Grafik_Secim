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

namespace Veri_Grafik_Secim
{
    public partial class FrmGiriş : Form
    {
        public FrmGiriş()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-PV2GBD4;Initial Catalog=DBSECIMPROJE;Integrated Security=True");
        private void BtnnOyGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into DBSECENEK (ILCEADI,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1",TxtilceAd.Text);          
            komut.Parameters.AddWithValue("@p2",TxtA.Text);          
            komut.Parameters.AddWithValue("@p3",TxtB.Text);          
            komut.Parameters.AddWithValue("@p4",TxtC.Text);          
            komut.Parameters.AddWithValue("@p5",TxtD.Text);          
            komut.Parameters.AddWithValue("@p6",TxtE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("OY GİRİŞİ GERÇEKLEŞTİRİLDİ");
        }

        private void BtnnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }
    }
}
