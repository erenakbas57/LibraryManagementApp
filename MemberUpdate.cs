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
    public partial class MemberUpdate : Form
    {
        public MemberUpdate()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kihmed.db; Version=3");
        SQLiteDataAdapter da;
        DataSet ds;

        private void MemberUpdate_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            labeladg.Visible = false;
            labelsoyadg.Visible = false;
            labeltelg.Visible = false;
            labeladresg.Visible = false;
            lblWarning.Visible = false;


            if (adtbxg.Text == "" | soyadtbxg.Text == "" | telefontbxg.Text.Length != 11 | adrestbxg.Text == "")
            {
                if (adtbxg.Text == "")
                {
                    labeladg.Visible = true;
                    lblWarning.Visible = true;
                    lblWarning.Text = "          Lütfen boş veya \n eksik alanları doldurunuz";
                }

                if (soyadtbxg.Text == "")
                {
                    labelsoyadg.Visible = true;
                    lblWarning.Visible = true;
                    lblWarning.Text = "          Lütfen boş veya \n eksik alanları doldurunuz";
                }

                if (telefontbxg.Text.Length != 11)
                {
                    labeltelg.Visible = true;
                    lblWarning.Visible = true;
                    lblWarning.Text = "          Lütfen boş veya \n eksik alanları doldurunuz";
                }

                if (adrestbxg.Text == "")
                {
                    labeladresg.Visible = true;
                    lblWarning.Visible = true;
                    lblWarning.Text = "          Lütfen boş veya \n eksik alanları doldurunuz";
                }
            }

            else
            {
                foreach (DataGridViewRow drow in dgw1.SelectedRows)
                {
                    baglanti.Open();

                    string update = $@"update Uyeler set name=@name , surname=@surname , phone=@phone , address=@address where ID=@ID";

                    SQLiteCommand cmd = new SQLiteCommand(update, baglanti);
                    cmd.Parameters.AddWithValue("@ID", dgw1.SelectedCells[0].Value);
                    cmd.Parameters.AddWithValue("@name", adtbxg.Text);
                    cmd.Parameters.AddWithValue("@surname", soyadtbxg.Text);
                    cmd.Parameters.AddWithValue("@phone", telefontbxg.Text);
                    cmd.Parameters.AddWithValue("@address", adrestbxg.Text);

                    cmd.ExecuteNonQuery();



                    baglanti.Close();
                }
                adtbxg.Clear();
                soyadtbxg.Clear();
                telefontbxg.Clear();
                adrestbxg.Clear();
                listele();

            }

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
        private void btnara_Click(object sender, EventArgs e)
        {
            da = new SQLiteDataAdapter($"Select ID,name,surname,phone,address from Uyeler where {name} Like '%" + tbxara.Text + "%'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kihmed");
            dgw1.DataSource = ds.Tables["kihmed"];
            baglanti.Close();
        }
        
        private void dgw1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            adtbxg.Text = dgw1.CurrentRow.Cells["name"].Value.ToString();
            soyadtbxg.Text = dgw1.CurrentRow.Cells["surname"].Value.ToString();
            telefontbxg.Text = dgw1.CurrentRow.Cells["phone"].Value.ToString();
            adrestbxg.Text = dgw1.CurrentRow.Cells["address"].Value.ToString();
        }

        private void telefontbxg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


    }
}
