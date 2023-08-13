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
    public partial class KitapGecikme : Form
    {
        public KitapGecikme()
        {
            InitializeComponent();
        }

        SQLiteDataAdapter da;
        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kihmed.db;Version=3");
        DataSet ds;

        private void KitapGecikme_Load(object sender, EventArgs e)
        {
            sonListele();
        }

        void sonListele()
        {

            string bugun = DateTime.Today.ToString("yyyyMMdd");
            string uc = DateTime.Today.AddDays(3).ToString("yyyyMMdd");
            string deger = $@"select ad,soyad,phone,kitap,sontarih from odunc where sontarih between '{bugun}' and '{uc}' and teslim='Teslim Edilmedi'";
            da = new SQLiteDataAdapter(deger, baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kihmed");
            dgw2.DataSource = ds.Tables["kihmed"];
            baglanti.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
