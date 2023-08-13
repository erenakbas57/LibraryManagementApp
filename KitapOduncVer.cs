using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphanecsharp
{
    public partial class KitapOduncVer : Form
    {
        public KitapOduncVer()
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

        private void KitapOdunc_Load(object sender, EventArgs e)
        {
            KitapData();
            UyeData();
        }


        void KitapData()
        {
            baglanti = new SQLiteConnection("Data Source=kihmed.db; Version=3");
            da = new SQLiteDataAdapter("select rafid,book,author,publisher,durum from Books", baglanti);
            ds = new DataSet();
            baglanti.Open();

            da.Fill(ds, "kihmed");

            dgwKitap.DataSource = ds.Tables["kihmed"];
            baglanti.Close();
        }

        void UyeData()
        {
            baglanti = new SQLiteConnection("Data Source=kihmed.db; Version=3");
            da = new SQLiteDataAdapter("select ID,name,surname,phone,birthdate,phone,address from Uyeler", baglanti);
            ds = new DataSet();
            baglanti.Open();

            da.Fill(ds, "kihmed");

            dgwUye.DataSource = ds.Tables["kihmed"];
            baglanti.Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            lblad.Visible = false;
            lblsoyad.Visible = false;
            lblkitap.Visible = false;
            lblwarning.Visible = false;
            lblwarning.Text = "";


            komut = new SQLiteCommand();
            baglanti.Open();
            komut.Connection = baglanti;

            string durum = dgwKitap.CurrentRow.Cells["durum"].Value.ToString();

            if (kitapAdtbx.Text == "" | uyeAdtbx.Text == "" | uyeSoyadtbx.Text == "")
            {
                if (kitapAdtbx.Text == "" & uyeAdtbx.Text == "")
                {
                    lblad.Visible = true;
                    lblsoyad.Visible = true;
                    lblkitap.Visible = true;
                    lblwarning.Text = "Lütfen kitap ve üye seçin";
                    lblwarning.Visible = true;
                }
                if (kitapAdtbx.Text == "" & uyeAdtbx.Text != "")
                {
                    lblkitap.Visible = true;
                    lblwarning.Visible = true;
                    lblwarning.Text = "lütfen kitap seçiniz";
                }
                if (uyeAdtbx.Text == "" & uyeSoyadtbx.Text == "" & kitapAdtbx.Text != "")
                {
                    lblad.Visible = true;
                    lblsoyad.Visible = true;
                    lblwarning.Visible = true;
                    lblwarning.Text = "lütfen üye seçiniz";
                }
            }
            else
            {
                if (durum == "Ödünç Verildi")
                {
                    MessageBox.Show("Kitap şuanda mevcut değil");
                }
                else
                {
                    DialogResult secenek = MessageBox.Show("Kitabı teslim etme işlemini onaylıyor musunuz?", "Ödünç Teslim Etme Penceresi", MessageBoxButtons.YesNo);

                    if (secenek == DialogResult.Yes)
                    {
                        int uyeid = Convert.ToInt32(dgwUye.CurrentRow.Cells["ID"].Value);
                        string rafid = dgwKitap.CurrentRow.Cells["rafid"].Value.ToString();

                        komut.CommandText = $@"select phone from Uyeler where ID='{uyeid}'";
                        string phone = komut.ExecuteScalar().ToString();

                        string bugun = DateTime.Now.ToString("yyyyMMdd");
                        string deger = DateTime.MinValue.ToString("yyyyMMdd");
                        string sontarih = DateTime.Now.AddDays(15).ToString("yyyyMMdd");

                        string ekle = @"insert into odunc(uyeid,ad,soyad,phone,kitap,rafid,alistarihi,sontarih,teslim) values('" + uyeid + "','" + uyeAdtbx.Text + "','" + uyeSoyadtbx.Text + "','" + phone + "','" + kitapAdtbx.Text + "','" + rafid + "','" + bugun + "','" + sontarih + "','" + "Teslim Edilmedi" + "')";

                        komut.CommandText = ekle;
                        komut.ExecuteNonQuery();

                        MessageBox.Show("Kitap Ödünç Verildi");

                        string kitapguncelle = $@"update Books set durum='Ödünç Verildi' where rafid='{rafid}'";
                        komut.CommandText = kitapguncelle;
                        komut.ExecuteNonQuery();

                        uyeAdtbx.Clear();
                        uyeSoyadtbx.Clear();
                        kitapAdtbx.Clear();
                    }
                    else if (secenek == DialogResult.No)
                    {

                    }
                }
            }

            baglanti.Close();
            KitapData();
            UyeData();

        }

        private void tbxAraKitap_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SQLiteCommand("select rafid,book,author,publisher,durum from Books where book Like '%" + tbxAraKitap.Text + "%'", baglanti);
            da = new SQLiteDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwKitap.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void tbxAraUye_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SQLiteCommand("select ID,name,surname,birthdate,phone,address from Uyeler where name Like '%" + tbxAraUye.Text + "%'", baglanti);
            da = new SQLiteDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwUye.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void dgwKitap_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            kitapAdtbx.Text = dgwKitap.CurrentRow.Cells["book"].Value.ToString();
        }

        private void dgwUye_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            uyeAdtbx.Text = dgwUye.CurrentRow.Cells["name"].Value.ToString();
            uyeSoyadtbx.Text = dgwUye.CurrentRow.Cells["surname"].Value.ToString();
        }
    }
}
