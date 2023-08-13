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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kihmed.db;Version=3");
        SQLiteCommand komut;
        SQLiteDataAdapter da;
        DataSet ds;
        SQLiteDataReader dr;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KitapIstatistik_Load(object sender, EventArgs e)
        {
            AylikEnlbl();
            Listele();

            baglanti.Open();
            komut = new SQLiteCommand();
            komut.Connection = baglanti;

            string ay = DateTime.Today.ToString("MM");
            string yil = DateTime.Today.ToString("yyyy");
            string deger = $@"select count(*) from odunc where sontarih like '{yil}{ay}__' group by uyeid order by count(kitap) desc";
            komut.CommandText = deger;
            int adet = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();

            if (adet != 0)
            {
                lblAy.Visible = true;
                lblAyAd.Visible = true;
            }
            
        }

        void AylikEnlbl()
        {
            
            komut = new SQLiteCommand();
            komut.Connection = baglanti;

            string ay = DateTime.Today.ToString("MM");
            string yaziay = DateTime.Today.ToString("MMMM");
            string yil = DateTime.Today.ToString("yyyy");

            lblAy.Text = $"{yaziay} ayı en çok kitap okuyan";

            baglanti.Open();
            komut.CommandText = $@"select uyeid,ad,soyad,count(kitap) from odunc where sontarih like '{yil}{ay}__' group by uyeid order by count(kitap) desc limit 1";
            dr = komut.ExecuteReader();
            

            if (dr.Read())
            {
                string ad = dr["ad"].ToString();
                string soyad = dr["soyad"].ToString();
                lblAyAd.Text = $"{ad.ToUpper()} {soyad.ToUpper()}";
            }
            dr.Close();
            baglanti.Close();

        }

        void Listele()
        {
            string ay = DateTime.Today.ToString("MM");
            string yil = DateTime.Today.ToString("yyyy");

            string deger = $@"select uyeid as 'ÜYE NO',ad as 'AD',soyad as 'SOYAD',count(kitap) as 'Toplam Kitap' from odunc where sontarih like '{yil}{ay}__' group by uyeid order by count(kitap) desc";
            da = new SQLiteDataAdapter(deger, baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kihmed");
            dgw.DataSource = ds.Tables["kihmed"];
            baglanti.Close();
        }



    }
}
