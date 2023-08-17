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
using System.IO;

namespace Kutuphanecsharp
{
    public partial class PanelSideMenu : Form
    {
        public PanelSideMenu()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=kihmed.db;Version=3");
        SQLiteCommand komut;

        private Form activeForm = null;

        int tempIndex;
        Random random;

        private void Form1_Load(object sender, EventArgs e)
        {
            customizeDesign();

            CreateDb();

            lblName.Text = "ANA MENÜ";

            Alert();

        }


        void CreateDb()
        {
            if (!File.Exists("kihmed.db"))
            {
                SQLiteConnection.CreateFile("kihmed.db");
                baglanti.Open();

                #region Üyelik Tablosu
                string uye = @"CREATE TABLE Uyeler(
                                ID INTEGER NOT NULL,
                                adddt text not null,
                                name text not null,
                                surname text not null,
                                phone text not null,
                                address text not null,
                                okitaptoplam int not null
                                );";
                
                
                komut = new SQLiteCommand(uye, baglanti);

                komut.ExecuteNonQuery();

                
                #endregion

                #region Kitap Tablosu
                string book = @"CREATE TABLE Books(
                             ID INTEGER PRIMARY KEY AUTOINCREMENT,
                             rafid text not null,
                             book text not null,
                             author text not null,
                             category text not null,
                             publisher text not null,
                             durum text not null
                             );";

                komut = new SQLiteCommand(book, baglanti);
                komut.ExecuteNonQuery();

                #endregion

                #region Raf Tablosu
                string raf = @"create table raf(
                                    ID integer not null,
                                    rafname text not null);";


                komut = new SQLiteCommand(raf, baglanti);
                komut.ExecuteNonQuery();

                #endregion

                #region Kategori Tablosu
                string category = @"create table category(
                                    ID integer PRIMARY KEY AUTOINCREMENT,
                                    categoryname text not null);";

                komut = new SQLiteCommand(category,baglanti);
                komut.ExecuteNonQuery();

                #endregion

                #region Büfe Tablosu
                string bufe = @"create table bufe(
                                ID integer PRIMARY KEY AUTOINCREMENT,
                                urunad text not null,
                                fiyat double not null,
                                adet int not null);";
                komut = new SQLiteCommand(bufe,baglanti);
                komut.ExecuteNonQuery();

                #endregion

                #region Kasa Tablosu

                string kasa = @"create table kasa(
                                urun text not null,
                                adet int not null,
                                ucret double not null,
                                tarih date not null)";

                komut = new SQLiteCommand(kasa,baglanti);
                komut.ExecuteNonQuery();

                #endregion

                #region Ciro
                string ciro = @"create table ciro(
                                gunluk date not null,
                                ciro double not null)";

                komut = new SQLiteCommand(ciro,baglanti);
                komut.ExecuteNonQuery();

                #endregion

                #region Ödünç Kitap
                string odunc = @"create table odunc(
                                 id integer PRIMARY KEY autoincrement,
                                 uyeid int not null,
                                 ad text not null,
                                 soyad text not null,
                                 phone text not null,
                                 kitap text not null,
                                 rafid text not null,
                                 alistarihi date not null,
                                 sontarih date not null,
                                 teslim text not null
                                 )";
                komut = new SQLiteCommand(odunc,baglanti);
                komut.ExecuteNonQuery();
                #endregion

                baglanti.Close();
            }
        }


        private void customizeDesign()
        {
            panelBookSubMenu.Visible = false;
            panelMemberSubMenu.Visible = false;
            panelBufeSubMenu.Visible = false;
            panelSettingsSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelBookSubMenu.Visible == true)
                panelBookSubMenu.Visible = false;
            if (panelMemberSubMenu.Visible == true)
                panelMemberSubMenu.Visible = false;
            if (panelBufeSubMenu.Visible == true)
                panelBufeSubMenu.Visible = false;
            if (panelSettingsSubMenu.Visible == true)
                panelSettingsSubMenu.Visible = false;
               
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close(); 
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
            btnGecikme.Visible = false;
            btnKapat.Visible = false;

            Color color = SelectThemeColor();

            panelUstSolMenu.BackColor = ColorBrightness(color, -0.3);
            panelUstMenu.BackColor = color ; 

        }

        public static List<string> ColorList = new List<string>()
        {
            "#3F51B5",
            "#009688",
            "#FF5722",
            "#607D8B",
            "#FF9800",
            "#9C27B0",
            "#2196F3",
            "#EA676C",
            "#E41A4A",
            "#5978BB",
            "#018790",
            "#0E3441",
            "#00B0AD",
            "#721D47",
            "#EA4833",
            "#EF937E",
            "#F37521",
            "#A12059",
            "#126881",
            "#8BC240",
            "#364D5B",
            "#C7DC5B",
            "#0094BC",
            "#E4126B",
            "#43B76E",
            "#7BCFE9",
            "#B71C46"
        };
        
        public static Color ColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor<0)
            {
                correctionFactor += 1;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A,(byte)red, (byte)green, (byte)blue);
        }
        private Color  SelectThemeColor()
        {

            random = new Random();
            int index = random.Next(ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ColorList.Count);
            }
            tempIndex = index;
            string color = ColorList[index];
            return ColorTranslator.FromHtml(color);

        }


        

        #region KitapMenü
        private void btnBooks_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBookSubMenu);
            
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            openChildForm(new KitapKayit());
            hideSubMenu();
            lblName.Text = btnBookAdd.Text;
            
        }
        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            openChildForm(new KitapAra());
            hideSubMenu();
            lblName.Text = btnBookSearch.Text;
        }

        private void btnBookLoan1_Click(object sender, EventArgs e)
        {
            openChildForm(new KitapOduncAl());
            hideSubMenu();
            lblName.Text = btnBookLoan1.Text;
        }

        private void btnBookLoan_Click(object sender, EventArgs e)
        {
            openChildForm(new KitapOduncVer());
            hideSubMenu();
            lblName.Text = btnBookLoan.Text;
        }

        private void btnKitapGuncelle_Click(object sender, EventArgs e)
        {
            openChildForm(new KitapGuncelle());
            hideSubMenu();
            lblName.Text = btnKitapGuncelle.Text;
        }

        #endregion

        #region ÜyeMenü
        private void btnMembers_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMemberSubMenu);
        }


        private void btnMemberAdd_Click(object sender, EventArgs e)
        {
            openChildForm(new MemberAdd());
            hideSubMenu();
            lblName.Text = btnMemberAdd.Text;
        }
        private void btnMemberUpdate_Click(object sender, EventArgs e)
        {
            openChildForm(new MemberUpdate());
            hideSubMenu();
            lblName.Text = btnMemberUpdate.Text;
        }
        private void btnMemberSearch_Click(object sender, EventArgs e)
        {
            openChildForm(new MemberSearch());
            hideSubMenu();
            lblName.Text = btnMemberSearch.Text;
        }

        #endregion

        #region Büfe
        private void btnBufe_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBufeSubMenu);
        }

        private void BtnBufeSatis_Click(object sender, EventArgs e)
        {
            openChildForm(new BufeSatis());
            hideSubMenu();
            lblName.Text = BtnBufeSatis.Text;
        }

        private void BtnBufeStok_Click(object sender, EventArgs e)
        {
            openChildForm(new BufeStok());
            hideSubMenu();
            lblName.Text = BtnBufeStok.Text;
        }

        private void btnBufeKasa_Click(object sender, EventArgs e)
        {
            openChildForm(new BufeKasa());
            hideSubMenu();
            lblName.Text = btnBufeKasa.Text;

        }
        #endregion

        #region AyarMenü

        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSettingsSubMenu);
        }

        private void btnKitapAyarlari_Click(object sender, EventArgs e)
        {
            openChildForm(new AyarKitap());
            hideSubMenu();
            lblName.Text = btnKitapAyarlari.Text;
        }

        #endregion



        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            
            lblName.Text = btnMenu.Text;
            btnGecikme.Visible = true;
            btnKapat.Visible = true;

            Color color = SelectThemeColor();

            panelUstSolMenu.BackColor = ColorBrightness(color, -0.3);
            panelUstMenu.BackColor = color;

            Alert();

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            openChildForm(new Statistics());
            lblName.Text = btnStatistics.Text;
        }


        void Alert()
        {
            btnGecikme.Visible = false;
            btnKapat.Visible = false;
            baglanti.Open();
            komut = new SQLiteCommand();
            komut.Connection = baglanti;
            string bugun = DateTime.Today.ToString("yyyyMMdd");
            string uc = DateTime.Today.AddDays(3).ToString("yyyyMMdd");

            komut.CommandText = $@"select count(*) from odunc where sontarih between '{bugun}' and '{uc}' and teslim='Teslim Edilmedi'";
            int adet = Convert.ToInt32(komut.ExecuteScalar());

            baglanti.Close();
            if (adet != 0)
            {
                btnKapat.Visible = true;
                btnGecikme.Visible = true;
                btnGecikme.Text = $"Üç ve daha az günü kalan teslim edilmeyen {adet} adet kitap var";
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            btnKapat.Visible = false;
            btnGecikme.Visible = false;
        }

        private void btnGecikme_Click(object sender, EventArgs e)
        {
            openChildForm(new KitapGecikme());
        }

        private void btnRezevasyon_Click(object sender, EventArgs e)
        {
            openChildForm(new rezervasyon());
            hideSubMenu();
            lblName.Text = btnRezevasyon.Text;
        }
    }
}
