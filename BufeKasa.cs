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
    public partial class BufeKasa : Form
    {
        public BufeKasa()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kihmed.db;Version=3");
        SQLiteDataAdapter da;
        DataSet ds;
        SQLiteCommand komut;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BufeKasa_Load(object sender, EventArgs e)
        {
            ciroListele();
            listele();
            gunlukTopla();
            aylikTopla();
        }

        void listele()
        {
            da = new SQLiteDataAdapter("select urun,adet,ucret,tarih from kasa", baglanti);
            ds = new DataSet();
            baglanti.Open();

            da.Fill(ds, "kihmed");

            dgw1.DataSource = ds.Tables["kihmed"];
            baglanti.Close();
        }

        void ciroListele()
        {
            string ay = DateTime.Today.ToString("yyyyMM");
            string deger = $@"select gunluk,ciro from ciro where gunluk like '{ay}%'";
            da = new SQLiteDataAdapter(deger,baglanti);
            ds = new DataSet();
            baglanti.Open();

            da.Fill(ds,"kihmed");

            dgw2.DataSource = ds.Tables["kihmed"];
            baglanti.Close();
        }
        

        void gunlukTopla()
        {
            baglanti.Open();
            komut = new SQLiteCommand();
            komut.Connection = baglanti;

            string bugun = DateTime.Today.ToString("yyyyMMdd");

            komut.CommandText = $"select count(ucret) from kasa where tarih='{bugun}'";
            int sayi = Convert.ToInt32(komut.ExecuteScalar());

            if (sayi != 0)
            {

                komut.CommandText = $@"select sum(ucret) from kasa where tarih='{bugun}'";
                double deger = Convert.ToDouble(komut.ExecuteScalar());

                string gfiyat = deger.ToString();
                gfiyat = gfiyat.Replace(",",".");

                lblgunluk.Text = $"{gfiyat} ₺";
            }
            else
            {
                lblgunluk.Text = "0 ₺";
            }
            baglanti.Close();
        }

        void aylikTopla()
        {
            baglanti.Open();
            komut = new SQLiteCommand();
            komut.Connection = baglanti;

            string dt = DateTime.Today.ToString("yyyyMM");

            komut.CommandText = $@"select count(ucret) from kasa where tarih like '{dt}%'";
            int sayi = Convert.ToInt32(komut.ExecuteScalar());
            
            if (sayi != 0)
            {

                komut.CommandText = $@"select sum(ucret) from kasa where tarih like '{dt}%'";
                double deger = Convert.ToDouble(komut.ExecuteScalar());

                string afiyat = deger.ToString();
                afiyat = afiyat.Replace(",",".");

                lblaylik.Text = $"{afiyat} ₺";

            }
            else
            {
                lblaylik.Text = "0 ₺";
            }
            baglanti.Close();
        }


        void araTopla()
        {
            baglanti.Open();
            komut = new SQLiteCommand();
            komut.Connection = baglanti;

            string first = dtpfirst.Value.Date.ToString("yyyyMMdd");
            first = first.Replace(".",string.Empty);

            string last = dtplast.Value.Date.ToString("yyyyMMdd");
            last = last.Replace(".",string.Empty);

            komut.CommandText = $@"select count(*) from kasa where tarih>= '{first}' and tarih<= '{last}'";
            int sayi = Convert.ToInt32(komut.ExecuteScalar());

            if (sayi == 0)
            {
                lblSonuc.Text = "0 ₺";
                lblSonuc.Visible = true;
            }
            else
            {
                komut.CommandText = $@"select sum(ucret) from kasa where tarih>= '{first}' and tarih<= '{last}' ";
                double deger = Convert.ToDouble(komut.ExecuteScalar());

                if (deger == 0)
                {
                    lblSonuc.Visible = true;
                    lblSonuc.Text = "0 ₺";
                }
                else
                {
                    lblSonuc.Visible = true;
                    lblSonuc.Text = $"{deger} ₺";
                }
            }

            

            baglanti.Close();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            araTopla();
        }

        private void btnCiroEkle_Click(object sender, EventArgs e)
        {
            string bugun = DateTime.Now.ToString("yyyyMMdd");

            lbltarih.Text = bugun;

            baglanti.Open();


            string kontrol = $"select count(*) from ciro where gunluk='{bugun}'";
            komut.CommandText = kontrol;
            int kayit = Convert.ToInt32(komut.ExecuteScalar());

            if (kayit==1)
            {
                foreach (DataGridViewRow dgw in dgw2.SelectedRows)
                {
                    if (dgw2.RowCount > 0)
                    {
                        
                        komut.CommandText = $"select sum(ucret) from kasa where tarih='{bugun}'";
                        double fiyat = Convert.ToDouble(komut.ExecuteScalar());

                        string sfiyat = fiyat.ToString();
                        sfiyat = sfiyat.Replace(",", ".");

                        string guncelle = $"update ciro set gunluk=@gunluk,ciro=@ciro where gunluk='{bugun}'";
                        
                        

                        komut = new SQLiteCommand(guncelle, baglanti);
                        komut.Parameters.AddWithValue("@gunluk", bugun);
                        komut.Parameters.AddWithValue("@ciro", sfiyat);


                        komut.ExecuteNonQuery();

                        baglanti.Close();
                        ciroListele();
                    }
                }
            }
            else
            {
                
                komut = new SQLiteCommand();
                komut.Connection = baglanti;

                komut.CommandText = $@"select count(*) from kasa where tarih='{bugun}'";
                int sayi = Convert.ToInt32(komut.ExecuteScalar());

                if (sayi == 0)
                {
                    MessageBox.Show("Kayıt edilecek veri yok");
                }
                else
                {
                    komut.CommandText = $"select sum(ucret) from kasa where tarih='{bugun}'";
                    double fiyat = Convert.ToDouble(komut.ExecuteScalar());

                    string sfiyat = fiyat.ToString();
                    sfiyat = sfiyat.Replace(",", ".");

                    string ekle = "insert into ciro(gunluk,ciro) values ('" + bugun + "','" + sfiyat + "')";
                    komut.CommandText = ekle;
                    komut.ExecuteNonQuery();
                }

                baglanti.Close();
                ciroListele();
            }

            baglanti.Close();
        }
    }
}
