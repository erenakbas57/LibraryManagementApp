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
    public partial class AyarKitap : Form
    {
        public AyarKitap()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kihmed.db;Version=3");
        SQLiteCommand komut;
        SQLiteDataAdapter da;
        DataSet ds;


        private void AyarKitap_Load(object sender, EventArgs e)
        {
            Raflistele();
            Kategorilistele();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Raflistele()
        {

            da = new SQLiteDataAdapter("select ID,rafname from raf", baglanti);
            ds = new DataSet();
            baglanti.Open();

            da.Fill(ds, "kihmed");

            dgw1.DataSource = ds.Tables["kihmed"];
            baglanti.Close();
        }

        void Kategorilistele()
        {
            da = new SQLiteDataAdapter("select ID,categoryname from category", baglanti);
            ds = new DataSet();
            baglanti.Open();

            da.Fill(ds, "kihmed");

            dgw2.DataSource = ds.Tables["kihmed"];
            baglanti.Close();
        }

        private void btnrafadd_Click(object sender, EventArgs e)
        {
            raflbl.Visible = false;

            komut = new SQLiteCommand();

            if (tbxraf.Text != "")
            {
                baglanti.Open();
                komut.Connection = baglanti;

                komut.CommandText = "select count(*) from raf";
                int rafadet = Convert.ToInt32(komut.ExecuteScalar());
                
                if (rafadet == 0)
                {
                    int rafid = 0;

                    string add = $@"insert into raf(ID,rafname) values('{rafid}','{tbxraf.Text}');";
                    komut = new SQLiteCommand(add, baglanti);
                    komut.ExecuteNonQuery();
                    tbxraf.Clear();
                }
                else
                {

                    komut.CommandText = "select count(*) from raf order by ID desc limit 1";
                    int rafmax = Convert.ToInt32(komut.ExecuteScalar());

                    string add = $@"insert into raf(ID,rafname) values('{rafmax}','{tbxraf.Text}');";
                    komut = new SQLiteCommand(add, baglanti);
                    komut.ExecuteNonQuery();
                    
                    tbxraf.Clear();

                }

                baglanti.Close();
                Raflistele();

            }
            else
            {
                raflbl.Visible = true;
            }
        }

        private void tbxrafDelete_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SQLiteCommand("Select name from raf where rafname Like '%" + tbxrafDelete.Text + "%'", baglanti);
            da = new SQLiteDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnrafDelete_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Rafı silmek istediğinize emin misiniz?", "Silme Onay Penceresi", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dgw1.SelectedRows)  //Seçili Satırları Silme
                {
                    baglanti.Open();
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    string sql = "DELETE FROM raf WHERE ID=@id";
                    komut = new SQLiteCommand(sql, baglanti);
                    komut.Parameters.AddWithValue("@id", id);

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                Raflistele();
            }
            else if (secenek == DialogResult.No)
            {

            }
        }



        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            lblCategory.Visible = false;

            if (tbxCategoryAdd.Text != "")
            {
                baglanti.Open();


                string add = $@"insert into category(categoryname) values('{tbxCategoryAdd.Text}');";
                komut = new SQLiteCommand(add, baglanti);
                komut.ExecuteNonQuery();
                tbxCategoryAdd.Clear();

                baglanti.Close();


                Kategorilistele();
            }
            else
            {
                lblCategory.Visible = true;
            }
        }

        private void tbxCategoryDelete_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SQLiteCommand("Select name from category where categoryname Like '%" + tbxCategoryDelete.Text + "%'", baglanti);
            da = new SQLiteDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Kategoriyi silmek istediğinize emin misiniz?", "Silme Onay Penceresi", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dgw2.SelectedRows)  //Seçili Satırları Silme
                {
                    baglanti.Open();
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    string sql = "DELETE FROM category WHERE ID=@id";
                    komut = new SQLiteCommand(sql, baglanti);
                    komut.Parameters.AddWithValue("@id", id);

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                Kategorilistele();
            }
            else if (secenek == DialogResult.No)
            {

            }
        }


    }
}
