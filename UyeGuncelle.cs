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
    public partial class UyeGuncelle : Form
    {
        public UyeGuncelle()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kihmed.db; Version=3");
        SQLiteDataAdapter da;
        DataSet ds;
        private void UyeGuncelle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            labeladg.Visible = false;
            labelsoyadg.Visible = false;
            labeltelg.Visible = false;
            labeltcg.Visible = false;
            labeldtg.Visible = false;
            labelgenderg.Visible = false;
            labelogrenimg.Visible = false;
            labeladresg.Visible = false;
            lblWarning.Visible = false;


            string gun = dtpg.Value.Day.ToString();
            string ay = dtpg.Value.Month.ToString();
            string yil = dtpg.Value.Year.ToString();

            string dtg = $"{gun}.{ay}.{yil}";

            lbldtg.Text = dtg;


            if (adtbxg.Text == "" | soyadtbxg.Text == "" | telefontbxg.Text.Length != 11 | tcnotbxg.Text.Length != 11 | lbldtg.Text == "" | ogrenimcbxg.Text == "" | adrestbxg.Text == "" | gendercbxg.Text == "")
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

                if (tcnotbxg.Text.Length != 11)
                {
                    labeltcg.Visible = true;
                    lblWarning.Visible = true;
                    lblWarning.Text = "          Lütfen boş veya \n eksik alanları doldurunuz";
                }

                if (lbldtg.Text == "")
                {
                    labeldtg.Visible = true;
                    lblWarning.Visible = true;
                    lblWarning.Text = "          Lütfen boş veya \n eksik alanları doldurunuz";
                }

                if (ogrenimcbxg.Text == "")
                {
                    labelogrenimg.Visible = true;
                    lblWarning.Visible = true;
                    lblWarning.Text = "          Lütfen boş veya \n eksik alanları doldurunuz";
                }

                if (adrestbxg.Text == "")
                {
                    labeladresg.Visible = true;
                    lblWarning.Visible = true;
                    lblWarning.Text = "          Lütfen boş veya \n eksik alanları doldurunuz";
                }

                if (gendercbxg.Text == "")
                {
                    labelgenderg.Visible = true;
                    lblWarning.Visible = true;
                    lblWarning.Text = "          Lütfen boş veya \n eksik alanları doldurunuz";
                }
            }

            else
            {
                foreach (DataGridViewRow drow in dgw1.SelectedRows)
                {
                    baglanti.Open();

                    string update = $@"update Uyeler set name=@name , surname=@surname , phone=@phone , tc=@tc , birthdate=@birthdate , gender=@gender , education=@education , address=@address where ID=@ID";

                    SQLiteCommand cmd = new SQLiteCommand(update, baglanti);
                    cmd.Parameters.AddWithValue("@ID", dgw1.SelectedCells[0].Value);
                    cmd.Parameters.AddWithValue("@name", adtbxg.Text);
                    cmd.Parameters.AddWithValue("@surname", soyadtbxg.Text);
                    cmd.Parameters.AddWithValue("@phone", telefontbxg.Text);
                    cmd.Parameters.AddWithValue("@tc", tcnotbxg.Text);
                    cmd.Parameters.AddWithValue("@birthdate", lbldtg.Text);
                    cmd.Parameters.AddWithValue("@gender", gendercbxg.Text);
                    cmd.Parameters.AddWithValue("@education", ogrenimcbxg.Text);
                    cmd.Parameters.AddWithValue("@address", adrestbxg.Text);

                    cmd.ExecuteNonQuery();



                    baglanti.Close();
                }
                adtbxg.Clear();
                soyadtbxg.Clear();
                telefontbxg.Clear();
                tcnotbxg.Clear();
                dtpg.Value = DateTime.Today;
                gendercbxg.Text = null;
                ogrenimcbxg.Text = null;
                adrestbxg.Clear();
                listele();

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void telefontbxg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tcnotbxg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void listele()
        {

            da = new SQLiteDataAdapter("select ID,name,surname,phone,tc,birthdate,gender,education,address from Uyeler", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kihmed");
            dgw1.DataSource = ds.Tables["kihmed"];
            baglanti.Close();

        }

        private void dgw1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            adtbxg.Text = dgw1.CurrentRow.Cells["name"].Value.ToString();
            soyadtbxg.Text = dgw1.CurrentRow.Cells["surname"].Value.ToString();
            telefontbxg.Text = dgw1.CurrentRow.Cells["phone"].Value.ToString();
            tcnotbxg.Text = dgw1.CurrentRow.Cells["tc"].Value.ToString();
            gendercbxg.Text = dgw1.CurrentRow.Cells["gender"].Value.ToString();
            ogrenimcbxg.Text = dgw1.CurrentRow.Cells["education"].Value.ToString();
            adrestbxg.Text = dgw1.CurrentRow.Cells["address"].Value.ToString();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            da = new SQLiteDataAdapter($"Select ID,name,surname,phone,tc,birthdate,gender,education,address from Uyeler where {name} Like '%" + tbxara.Text + "%'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kihmed");
            dgw1.DataSource = ds.Tables["kihmed"];
            baglanti.Close();
        }
    }
}
