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
    public partial class KitapAra : Form
    {
        public KitapAra()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti;
        SQLiteCommand komut;
        SQLiteDataAdapter da;
        DataSet ds;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = "";

            if (rbtnName.Checked == true)
            {
                name = "book";
            }
            else if (rbtnAuthor.Checked == true)
            {
                name = "author";
            }
            else if (rbtnCategory.Checked == true)
            {
                name = "category";
            }


            komut = new SQLiteCommand($"Select rafid,book,author,publisher,category,durum from Books where {name} Like '%" + tbxSearch.Text + "%'", baglanti);
            da = new SQLiteDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        public void listele()
        {
            baglanti = new SQLiteConnection("Data Source=kihmed.db; Version=3");
            da = new SQLiteDataAdapter("select rafid,book,author,publisher,category,durum from Books", baglanti);
            ds = new DataSet();
            baglanti.Open();

            da.Fill(ds, "kihmed");

            dgw1.DataSource = ds.Tables["kihmed"];
            baglanti.Close();

        }

        private void rbtnName_CheckedChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = true;
        }

        private void rbtnAuthor_CheckedChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = true;
        }

        private void rbtnCategory_CheckedChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = true;
        }

        private void KitapAra_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Kitabı silmek istediğinize emin misiniz?", "Silme Onay Penceresi", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dgw1.SelectedRows)  //Seçili Satırları Silme
                {
                    baglanti.Open();
                    string id = drow.Cells[0].Value.ToString();
                    string sql = "DELETE FROM Books WHERE rafid=@rafid";
                    komut = new SQLiteCommand(sql, baglanti);

                    komut.Parameters.AddWithValue("@rafid", id);

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                listele();
            }
            else if (secenek == DialogResult.No)
            {

            }
        }

        private void tbxArama_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SQLiteCommand("Select rafid,book,author,publisher,category,durum from Books where book Like '%" + tbxArama.Text + "%'", baglanti);
            da = new SQLiteDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }


    }
}
