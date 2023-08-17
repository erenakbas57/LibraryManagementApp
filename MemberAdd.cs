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
    public partial class MemberAdd : Form
    {
        public MemberAdd()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kihmed.db; Version=3");
        SQLiteCommand komut;
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelad.Visible = false;
            labelsoyad.Visible = false;
            labeltel.Visible = false;
            labeladres.Visible = false;
            lblWarninga.Visible = false;


            if (adtbx.Text == "" | soyadtbx.Text == "" | telefontbx.Text.Length != 11 | adrestbx.Text == "")
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
                if (sayi == 0)
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


                string deger = "insert into Uyeler(ID,adddt,name,surname,phone,address,okitaptoplam) values ('" + uyeno + "','" + kayit + "','" + adtbx.Text + "','" + soyadtbx.Text + "','" + telefontbx.Text + "','" + adrestbx.Text + "','" + 0 + "')";


                komut.CommandText = deger;

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt Başarılı");

                adtbx.Clear();
                soyadtbx.Clear();
                telefontbx.Clear();
                adrestbx.Clear();


            }
        }

        private void telefontbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
