using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kutuphanecsharp
{
    public partial class BufeSatis : Form
    {
        public BufeSatis()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kihmed.db;Version=3");
        SQLiteDataReader dr;
        SQLiteCommand komut;

        private void BufeSatis_Load(object sender, EventArgs e)
        {
            UrunEkle();


            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cbxAd.SelectedItem == null || nudAdet.Value == 0)
            {
                if (cbxAd.SelectedItem == null)
                {

                }

                if (nudAdet.Value == 0)
                {

                }
            }
            else
            {
                lbxAd.Items.Add(cbxAd.Text);
                lbxAdet.Items.Add(nudAdet.Value);

                komut = new SQLiteCommand();

                baglanti.Open();
                komut.Connection = baglanti;

                string ad = cbxAd.SelectedItem.ToString();


                komut.CommandText = $"select fiyat from bufe where urunad like '{ad}'";
                double urunfiyat = Convert.ToDouble(komut.ExecuteScalar());
               
                

                baglanti.Close();
                double fiyat = Convert.ToDouble(urunfiyat) * Convert.ToDouble(nudAdet.Value);
                string f = fiyat.ToString();
                lbxFiyat.Items.Add(f);
                
                //double tutar = Convert.ToDouble(lblToplam.Text);
                //tutar += Convert.ToDouble(f) ;

                double toplam = 0;
                for (int i = 0; i < lbxFiyat.Items.Count; i++)
                {
                    toplam += Convert.ToDouble(lbxFiyat.Items[i]);
                        
                }


                lblToplam.Text = toplam.ToString() ;
                nudAdet.Value = 0;
                cbxAd.SelectedItem = null;
            }
        }

        void UrunEkle()
        {
            baglanti.Open();
            

            
            komut = new SQLiteCommand("select urunad from bufe where adet>0", baglanti);
            komut.ExecuteNonQuery();

            dr = komut.ExecuteReader();

             while (dr.Read())
             {
                 cbxAd.Items.Add(dr["urunad"]);
             }

            baglanti.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lbxAd.Items.Clear();
            lbxAdet.Items.Clear();
            lbxFiyat.Items.Clear();
            cbxAd.SelectedItem = null;
            nudAdet.Value = 0;
            lblToplam.Text = "0";
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            if (lbxFiyat.Items.Count != 0)
            {
                baglanti.Open();
                komut.Connection = baglanti;

                int dongu = lbxAdet.Items.Count;

                for (int index = 0; index < dongu; index++)
                {

                    string cikar = $"update bufe set adet=adet-{lbxAdet.Items[index]} where urunad like '{lbxAd.Items[index]}'";
                    komut.CommandText = cikar;
                    komut.ExecuteNonQuery();
                }

                for (int index = 0; index < dongu; index++)
                {

                    string urun = lbxAd.Items[index].ToString();
                    double tane = Convert.ToDouble(lbxAdet.Items[index]);

                    komut.CommandText = $"select fiyat from bufe where urunad like '{urun}'";
                    double fiyat = Convert.ToDouble(komut.ExecuteScalar());
                    fiyat *= tane;

                    string sfiyat = fiyat.ToString();
                    sfiyat = sfiyat.Replace(",", ".");


                    string bugun = DateTime.Today.ToString("yyyyMMdd");

                    string ekle = $@"insert into kasa(urun,adet,ucret,tarih) values('" + urun + "','" + tane + "','" + sfiyat + "','" + bugun + "')";
                    komut.CommandText = ekle;
                    komut.ExecuteNonQuery();
                }

                cbxAd.Items.Clear();

                komut = new SQLiteCommand("select urunad from bufe where adet>0", baglanti);
                komut.ExecuteNonQuery();

                dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    cbxAd.Items.Add(dr["urunad"]);
                }
                dr.Close();
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lütfen ürün ekleyin");
            }
            
            lbxAd.Items.Clear();
            lbxAdet.Items.Clear();
            lbxFiyat.Items.Clear();
            cbxAd.SelectedItem = null;
            nudAdet.Value = 0;
            lblToplam.Text = "0";

        }

        private void cbxAd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
