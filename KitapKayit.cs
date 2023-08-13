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
using System.Collections;

namespace Kutuphanecsharp
{
    public partial class KitapKayit : Form
    {
        public KitapKayit()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kihmed.db;Version=3");
        SQLiteCommand komut;
        SQLiteDataReader dr;


        


        private void KitapKayit_Load(object sender, EventArgs e)
        {
            
            RafAdd();
            CategoryAdd();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            lblad.Visible = false;
            lblyazar.Visible = false;
            lblcategory.Visible = false;
            lblyayinevi.Visible = false;
            lblraf.Visible = false;
            lblwarning.Visible = false;
            lblyayinevi.Visible = false;

            if (tbxad.Text == "" | tbxyazar.Text=="" | cbxCategory.Text == "" | tbxyayinevi.Text == "" | rafcbx.Text=="")
            {
                lblwarning.Text = "Lütfen boş veya eksik\n  alanları doldurunuz!";
                if (tbxad.Text == "")
                {
                    lblad.Visible = true;
                    lblwarning.Visible = true;
                }
                if (tbxyazar.Text == "")
                {
                    lblyazar.Visible = true;
                    lblwarning.Visible = true;
                }
                if (cbxCategory.Text == "")
                {
                    lblcategory.Visible = true;
                    lblwarning.Visible = true;
                }
                if (tbxyayinevi.Text == "")
                {
                    lblyayinevi.Visible = true;
                    lblwarning.Visible = true;
                }
                if (rafcbx.Text == "")
                {
                    lblraf.Visible = true;
                    lblwarning.Visible = true;
                }
            }
            else
            {
                komut = new SQLiteCommand();
                

                baglanti.Open();
                komut.Connection = baglanti;


                

                komut.CommandText = $"select rafname from raf where ID like '{rafcbx.SelectedIndex}'";
                string rafad = komut.ExecuteScalar().ToString();

                komut.CommandText = $"select count(*) from Books where rafid like '{rafad}%'";
                int seciliraf = Convert.ToInt32(komut.ExecuteScalar());

                
                string rafisim = "";
                
                
                seciliraf  += 1;
                rafisim = $"{rafad}{seciliraf}";
               

                rafisimlbl.Text = rafisim;
                string durum = "Mevcut";
                string ekle = $"insert into Books(rafid,book,author,category,publisher,durum) values ('" + rafisimlbl.Text + "','" + tbxad.Text + "','" + tbxyazar.Text + "','" + cbxCategory.Text + "','" + tbxyayinevi.Text + "','"+ durum  +"')";
                

                komut.CommandText = ekle;

                komut.ExecuteNonQuery();
                baglanti.Close();

                tbxad.Clear();
                tbxyazar.Clear();
                cbxCategory.SelectedItem = null;
                tbxyayinevi.Clear();
                rafcbx.SelectedItem = null;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void RafAdd()
        {
            
            baglanti.Open();

            komut = new SQLiteCommand("select * from raf", baglanti);
            komut.ExecuteNonQuery();

            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                rafcbx.Items.Add(dr["rafname"]);
            }


            baglanti.Close();

        }

        void CategoryAdd()
        {
            baglanti.Open();

            komut = new SQLiteCommand("select * from category",baglanti);
            komut.ExecuteNonQuery();
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                cbxCategory.Items.Add(dr["categoryname"]);
            }

            baglanti.Close();
        }
    }
}
