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
using System.Reflection.Emit;

namespace Veri_Grafik_Secim
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-PV2GBD4;Initial Catalog=DBSECIMPROJE;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //İlçe Adlarını Combobox'a çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select ILCEADI from DBSECENEK", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            baglanti.Close();

            //Grafiğe Toplam Sonuçları Getirme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select SUM(APARTI),SUM(BPARTI),SUM(CPARTI),SUM(DPARTI),SUM(EPARTI) from DBSECENEK", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", dr2[4]);
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from DBSECENEK where ILCEADI=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                
                LblAA.Text = dr[2].ToString();
                LblBB.Text = dr[3].ToString();
                LblCC.Text = dr[4].ToString();
                LblDD.Text = dr[5].ToString();
                LblEE.Text = dr[6].ToString(); 

                double A,B,C,D,E,ayuzde,byuzde,cyuzde,dyuzde,eyuzde,toplam;

                A = Convert.ToInt64(dr[2]);
                B = Convert.ToInt64(dr[3]);
                C = Convert.ToInt64(dr[4]);
                D = Convert.ToInt64(dr[5]);
                E = Convert.ToInt64(dr[6]);

                toplam = A + B + C + D + E;

                ayuzde = A * 100 / toplam;
                byuzde = B * 100 / toplam;
                cyuzde = C * 100 / toplam;
                dyuzde = D * 100 / toplam;
                eyuzde = E * 100 / toplam;

                LblA.Text = "%" + ayuzde.ToString("0.00");
                LblB.Text = "%" + byuzde.ToString("0.00");
                LblC.Text = "%" + cyuzde.ToString("0.00");
                LblD.Text = "%" + dyuzde.ToString("0.00");
                LblE.Text = "%" + eyuzde.ToString("0.00");

                // Değişken adları ve değerleri için bir sözlük oluştur
                Dictionary<string, double> degiskenler = new Dictionary<string, double>()
                {
                 {"A Parti", A},
                 {"B Parti", B},
                 {"C Parti", C},
                 {"D Parti", D},
                 {"E Parti", E}
                };

                // Değişkenleri büyükten küçüğe sırala
                var siraliDegiskenler = degiskenler.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                // Sıralanmış değişkenleri doğru şekilde label'lara yazdır
                LblSira1.Text = siraliDegiskenler.ElementAt(0).Key;
                LblSira2.Text = siraliDegiskenler.ElementAt(1).Key;
                LblSira3.Text = siraliDegiskenler.ElementAt(2).Key;
                LblSira4.Text = siraliDegiskenler.ElementAt(3).Key;
                LblSira5.Text = siraliDegiskenler.ElementAt(4).Key;



            }
            baglanti.Close();
        }
    }
}
