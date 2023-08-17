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
    public partial class MemberSearch : Form
    {
        public MemberSearch()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kihmed.db; Version=3");
        SQLiteCommand komut;
        SQLiteDataAdapter da;
        DataSet ds;

        private void UyeAra_Load(object sender, EventArgs e)
        {
            listele();
        }

        public void listele()
        {
            
            da = new SQLiteDataAdapter("select ID,name,surname,phone,address from Uyeler", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kihmed");
            dgw1.DataSource = ds.Tables["kihmed"];
            baglanti.Close();

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SQLiteCommand("Select ID,name,surname,phone,address,okitaptoplam from Uyeler where name Like '%" + tbxSearch.Text + "%'", baglanti);
            da = new SQLiteDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Üyeliği silmek istediğinize emin misiniz?", "Silme Onay Penceresi", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dgw1.SelectedRows)  //Seçili Satırları Silme
                {
                    baglanti.Open();
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    string sql = "DELETE FROM Uyeler WHERE ID=@ID";
                    komut = new SQLiteCommand(sql, baglanti);
                    komut.Parameters.AddWithValue("@ID", id);

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                listele();
            }
            else if (secenek == DialogResult.No)
            {

            }
        }
    }
}
