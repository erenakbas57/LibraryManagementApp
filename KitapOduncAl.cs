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
    public partial class KitapOduncAl : Form
    {
        public KitapOduncAl()
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

        private void KitapOduncAl_Load(object sender, EventArgs e)
        {
            OduncData();
        }

        void OduncData()
        {
            
            da = new SQLiteDataAdapter("select uyeid,ad,soyad,phone,kitap,rafid,alistarihi,sontarih,teslim from odunc where teslim='Teslim Edilmedi'", baglanti);
            ds = new DataSet();
            baglanti.Open();

            da.Fill(ds, "kihmed");

            dgw1.DataSource = ds.Tables["kihmed"];
            baglanti.Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            

            string teslim = dgw1.CurrentRow.Cells["teslim"].Value.ToString();


            if (teslim == "Teslim Edildi")
            {
                MessageBox.Show("Bu Kitap Zaten Teslim Alındı");
            }
            else
            {
                DialogResult secenek = MessageBox.Show("Kitabı teslim alma işlemini onaylıyor musunuz?", "Ödünç Teslim Alma Penceresi", MessageBoxButtons.YesNo);
                if (secenek == DialogResult.Yes)
                {
                    komut = new SQLiteCommand();
                    baglanti.Open();
                    komut.Connection = baglanti;

                    string rafid = dgw1.CurrentRow.Cells["rafid"].Value.ToString();


                    komut.CommandText = $@"update Books set durum='Mevcut' where rafid like '{rafid}'";
                    komut.ExecuteNonQuery();

                    string bugun = DateTime.Today.ToString("yyyyMMdd");

                    komut.CommandText = $@"update odunc set teslim='Teslim Edildi' where rafid like '{rafid}'";
                    komut.ExecuteNonQuery();

                    int uyeid = Convert.ToInt32(dgw1.CurrentRow.Cells["uyeid"].Value);

                    komut.CommandText = $@"select okitaptoplam from Uyeler where ID like {uyeid}";
                    int okitaptoplam = Convert.ToInt32(komut.ExecuteScalar());
                    okitaptoplam += 1;

                    komut.CommandText = $@"update Uyeler set okitaptoplam={okitaptoplam} where ID like {uyeid}";
                    komut.ExecuteNonQuery();

                    baglanti.Close();
                }
                else if (secenek == DialogResult.No)
                {

                }
            }

            
            OduncData();

            uyeAdtbx.Clear();
            uyeSoyadtbx.Clear();
            kitapAdtbx.Clear();
        }

        private void tbxAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SQLiteCommand("select uyeid,ad,soyad,kitap,rafid,alistarihi,sontarih,teslim from odunc where ad Like '%" + tbxAra.Text + "%'", baglanti);
            da = new SQLiteDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void dgw1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            uyeAdtbx.Text = dgw1.CurrentRow.Cells["ad"].Value.ToString();
            uyeSoyadtbx.Text = dgw1.CurrentRow.Cells["soyad"].Value.ToString();
            kitapAdtbx.Text = dgw1.CurrentRow.Cells["kitap"].Value.ToString();

            DateTime sontarih = (DateTime)dgw1.CurrentRow.Cells["sontarih"].Value;
            DateTime bugun = DateTime.Today;

            if (sontarih<bugun)
            {
                
                TimeSpan kalangun = sontarih - bugun;//Sonucu zaman olarak döndürür
                double toplamGun = kalangun.TotalDays;
                toplamGun *= -1;
                lbltutar.Visible = true;
                lbltutarad.Visible = true;

                lbltutar.Text = $"{toplamGun} ₺";
            }

        }

    }
}
