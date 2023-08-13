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
    public partial class BufeStok : Form
    {
        public BufeStok()
        {
            InitializeComponent();
        }
        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kihmed.db;Version=3");
        SQLiteCommand komut;
        SQLiteDataAdapter da;
        DataSet ds;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BufeStok_Load(object sender, EventArgs e)
        {
            listele();
            
        }

        void listele()
        {
            da = new SQLiteDataAdapter("select ID,urunad,fiyat,adet from bufe", baglanti);
            ds = new DataSet();
            baglanti.Open();

            da.Fill(ds, "kihmed");

            dgw1.DataSource = ds.Tables["kihmed"];
            baglanti.Close();
        }

        private void tbxAdd_Click(object sender, EventArgs e)
        {
            lblad.Visible = false;
            lblfiyat.Visible = false;
            lbladet.Visible = false;
            lblwarning.Visible = false;

            
            

            if (tbxAd.Text == "" || tbxFiyat.Text == "" || nudAdet.Value == 0)
            {
                if (tbxAd.Text == "")
                {
                    lblad.Visible = true;
                    lblwarning.Visible = true;
                }
                if (tbxFiyat.Text == "")
                {
                    lblfiyat.Visible = true;
                    lblwarning.Visible = true;
                }
                if (nudAdet.Value == 0)
                {
                    lbladet.Visible = true;
                    lblwarning.Visible = true;
                    
                }
            }
            
            else
            {
                komut = new SQLiteCommand();
                baglanti.Open();
                komut.Connection = baglanti;

                string fiyat = tbxFiyat.Text;

                fiyat = fiyat.Replace(",",".");
                tbxFiyat.Text = fiyat;

                string ekle = "insert into bufe(urunad,fiyat,adet) values('" + tbxAd.Text + "', '" + tbxFiyat.Text + "', '" + nudAdet.Text + "');";

                komut.CommandText = ekle;
                komut.ExecuteNonQuery();

                baglanti.Close();

                tbxAd.Clear();
                tbxFiyat.Clear();
                nudAdet.Value = 0;

                listele();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Ürünü silmek istediğinize emin misiniz?", "Silme Onay Penceresi", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dgw1.SelectedRows)  //Seçili Satırları Silme
                {
                    baglanti.Open();
                    int ID = Convert.ToInt32(drow.Cells[0].Value);
                    string sql = "DELETE FROM bufe WHERE ID=@ID";
                    komut = new SQLiteCommand(sql, baglanti);

                    komut.Parameters.AddWithValue("@ID", ID);

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                listele();
            }
            else if (secenek == DialogResult.No)
            {
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgw in dgw1.SelectedRows)
            {
                if (dgw1.RowCount >0)
                {
                    baglanti.Open();
                    
                    int miktar = Convert.ToInt32(nudgAdet.Text);
                    string guncelle = $"update bufe set urunad=@urunad , fiyat=@fiyat , adet=@adet where ID=@ID";

                    string fiyat = tbxgFiyat.Text;
                    fiyat = fiyat.Replace(",",".");
                    tbxgFiyat.Text = fiyat;

                    komut = new SQLiteCommand(guncelle, baglanti);
                    komut.Parameters.AddWithValue("@ID",dgw1.SelectedCells[0].Value);
                    komut.Parameters.AddWithValue("@urunad", tbxgAd.Text);
                    komut.Parameters.AddWithValue("@fiyat", tbxgFiyat.Text);
                    komut.Parameters.AddWithValue("@adet", miktar);


                    komut.ExecuteNonQuery();

                    baglanti.Close();
                    listele();
                }
            }
        }

        private void dgw1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tbxgAd.Text = dgw1.CurrentRow.Cells["urunad"].Value.ToString();
            tbxgFiyat.Text = dgw1.CurrentRow.Cells["fiyat"].Value.ToString();
            nudgAdet.Value = Convert.ToInt32(dgw1.CurrentRow.Cells["adet"].Value);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
