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
    public partial class KitapGuncelle : Form
    {
        public KitapGuncelle()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kihmed.db; Version=3");
        SQLiteDataAdapter da;
        DataSet ds;

        private void KitapGuncelle_Load(object sender, EventArgs e)
        {
            listele();

        }

        public void listele()
        {

            da = new SQLiteDataAdapter("select * from Books", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kihmed");
            dgw1.DataSource = ds.Tables["kihmed"];
            baglanti.Close();

        }

        private void btnara_Click(object sender, EventArgs e)
        {
            da = new SQLiteDataAdapter($"Select ID,name,surname,phone,address from Uyeler where name Like '%" + tbxara.Text + "%'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kihmed");
            dgw1.DataSource = ds.Tables["kihmed"];
            baglanti.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            labelraf.Visible = false;
            labelkitap.Visible = false;
            labelyazar.Visible = false;
            labelkategori.Visible = false;
            labelyayinevi.Visible = false;

            labelwarning.Visible = false;



            if (cbxraf.Text == "" | tbxad.Text == "" | tbxyazar.Text == "" | tbxyayinevi.Text == "" | cbxkategori.Text == "")
            {
                if (cbxraf.Text == "")
                {
                    labelwarning.Visible = true;
                    labelraf.Visible = true;
                    labelwarning.Text = "         Lütfen boş veya \n eksik alanları doldurunuz";
                }
                if (tbxad.Text == "")
                {
                    labelwarning.Visible = true;
                    labelkitap.Visible = true;
                    labelwarning.Text = "         Lütfen boş veya \n eksik alanları doldurunuz";
                }
                if (tbxyazar.Text == "")
                {
                    labelwarning.Visible = true;
                    labelyazar.Visible = true;
                    labelwarning.Text = "         Lütfen boş veya \n eksik alanları doldurunuz";
                }
                if (tbxyayinevi.Text == "")
                {
                    labelwarning.Visible = true;
                    labelyayinevi.Visible = true;
                    labelwarning.Text = "         Lütfen boş veya \n eksik alanları doldurunuz";
                }
                if (cbxkategori.Text == "")
                {
                    labelwarning.Visible = true;
                    labelkategori.Visible = true;
                    labelwarning.Text = "         Lütfen boş veya \n eksik alanları doldurunuz";
                }
            }
            else
            {
                foreach (DataGridViewRow drow in dgw1.SelectedRows)
                {
                    baglanti.Open();

                    string update = $@"update Books set rafid=@rafid , book=@book , author=@author , category=@category , publisher=@publisher where ID=@ID";

                    SQLiteCommand cmd = new SQLiteCommand(update, baglanti);
                    cmd.Parameters.AddWithValue("@ID", dgw1.SelectedCells[0].Value);
                    cmd.Parameters.AddWithValue("rafid", cbxraf.Text);
                    cmd.Parameters.AddWithValue("@book", tbxad.Text);
                    cmd.Parameters.AddWithValue("@author", tbxyazar.Text);
                    cmd.Parameters.AddWithValue("@category", cbxkategori.Text);
                    cmd.Parameters.AddWithValue("@publisher", tbxyayinevi.Text);

                    cmd.ExecuteNonQuery();



                    baglanti.Close();
                }

                tbxad.Clear();
                tbxyazar.Clear();
                cbxraf.Items.Clear();
                tbxyayinevi.Clear();
                cbxkategori.Items.Clear();
                
                
                listele();
            }

        }

        private void dgw1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxraf.Text = dgw1.CurrentRow.Cells["rafid"].Value.ToString();
            tbxad.Text = dgw1.CurrentRow.Cells["book"].Value.ToString();
            tbxyazar.Text = dgw1.CurrentRow.Cells["author"].Value.ToString();
            tbxyayinevi.Text = dgw1.CurrentRow.Cells["publisher"].Value.ToString();
            cbxkategori.Text = dgw1.CurrentRow.Cells["category"].Value.ToString();
        }

        private void tbxara_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
