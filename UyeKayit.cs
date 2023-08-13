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
    public partial class UyeKayit : Form
    {
        public UyeKayit()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kihmed.db; Version=3");
        SQLiteCommand komut;

        private void UyeKayit_Load(object sender, EventArgs e)
        {
           
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            labelad.Visible = false;
            labelsoyad.Visible = false;
            labeltel.Visible = false;

            labelogrenim.Visible = false;
            labeladres.Visible = false;
            lblWarninga.Visible = false;


            if (adtbx.Text == "" | soyadtbx.Text == "" | telefontbx.Text.Length != 11 | ogrenimcbx.Text == "" | adrestbx.Text == "")
            {

                if (adtbx.Text == "")
                {
                    labelad.Visible = true;
                    lblWarninga.Visible = true;
                    lblWarninga.Text = "          Lütfen boş veya \n eksik alanları doldurunuz";
                }

                if (soyadtbx.Text == "")
                {
                    labelsoyad.Visible = true;
                    lblWarninga.Visible = true;
                    lblWarninga.Text = "          Lütfen boş veya \n eksik alanları doldurunuz";
                }

                if (telefontbx.Text.Length != 11)
                {
                    labeltel.Visible = true;
                    lblWarninga.Visible = true;
                    lblWarninga.Text = "          Lütfen boş veya \n eksik alanları doldurunuz";
                }


                if (ogrenimcbx.Text == "")
                {
                    labelogrenim.Visible = true;
                    lblWarninga.Visible = true;
                    lblWarninga.Text = "          Lütfen boş veya \n eksik alanları doldurunuz";
                }

                if (adrestbx.Text == "")
                {
                    labeladres.Visible = true;
                    lblWarninga.Visible = true;
                    lblWarninga.Text = "          Lütfen boş veya \n eksik alanları doldurunuz";
                }

            }

            else
            {
                komut = new SQLiteCommand();
                baglanti.Open();
                komut.Connection = baglanti;

                string dtnow = DateTime.Today.ToString("yyMM");

                string kayit = DateTime.Today.ToString("dd.MM.yyyy");

                komut.CommandText = $"select count(*) from Uyeler where ID like '{dtnow}%' ";
                int sayi = Convert.ToInt32(komut.ExecuteScalar());
                string uyeid = "";
                int uyeno;
                if (sayi==0)
                {
                    uyeid = $"{dtnow}10";
                    uyeno = Convert.ToInt32(uyeid);
                }
                else
                {
                    komut.CommandText = $"select ID from Uyeler where ID like '{dtnow}%' order by ID desc limit 1 ";
                    uyeno = Convert.ToInt32(komut.ExecuteScalar());
                    uyeno += 1;
                }
                

                string deger = "insert into Uyeler(ID,adddt,name,surname,phone,education,address,okitaptoplam) values ('" + uyeno + "','" + kayit + "','" + adtbx.Text + "','" + soyadtbx.Text + "','" + telefontbx.Text + "','" + ogrenimcbx.Text + "','" + adrestbx.Text + "','" + 0 + "')";


                komut.CommandText = deger;

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt Başarılı");

                adtbx.Clear();
                soyadtbx.Clear();
                telefontbx.Clear();
                adrestbx.Clear();
                ogrenimcbx.SelectedItem = null;
                

                
            }
        }





        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void telefontbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tcnotbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
