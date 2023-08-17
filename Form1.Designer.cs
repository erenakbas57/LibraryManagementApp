
namespace Kutuphanecsharp
{
    partial class PanelSideMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelSideMenu));
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.PanelArayuz = new System.Windows.Forms.Panel();
            this.btnRezevasyon = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.panelSettingsSubMenu = new System.Windows.Forms.Panel();
            this.btnKitapAyarlari = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelBufeSubMenu = new System.Windows.Forms.Panel();
            this.btnBufeKasa = new System.Windows.Forms.Button();
            this.BtnBufeStok = new System.Windows.Forms.Button();
            this.BtnBufeSatis = new System.Windows.Forms.Button();
            this.btnBufe = new System.Windows.Forms.Button();
            this.panelMemberSubMenu = new System.Windows.Forms.Panel();
            this.btnMemberSearch = new System.Windows.Forms.Button();
            this.btnMemberUpdate = new System.Windows.Forms.Button();
            this.btnMemberAdd = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.panelBookSubMenu = new System.Windows.Forms.Panel();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.btnBookLoan = new System.Windows.Forms.Button();
            this.btnBookLoan1 = new System.Windows.Forms.Button();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.panelUstSolMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUstMenu = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnGecikme = new System.Windows.Forms.Button();
            this.PanelArayuz.SuspendLayout();
            this.panelSettingsSubMenu.SuspendLayout();
            this.panelBufeSubMenu.SuspendLayout();
            this.panelMemberSubMenu.SuspendLayout();
            this.panelBookSubMenu.SuspendLayout();
            this.panelUstSolMenu.SuspendLayout();
            this.panelUstMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Goldenrod;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMenu.Location = new System.Drawing.Point(0, 110);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(246, 45);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "ANA MENÜ";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBooks.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.Location = new System.Drawing.Point(0, 155);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBooks.Size = new System.Drawing.Size(246, 45);
            this.btnBooks.TabIndex = 2;
            this.btnBooks.Text = "KİTAPLIK";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // PanelArayuz
            // 
            this.PanelArayuz.BackColor = System.Drawing.Color.Goldenrod;
            this.PanelArayuz.Controls.Add(this.btnRezevasyon);
            this.PanelArayuz.Controls.Add(this.btnStatistics);
            this.PanelArayuz.Controls.Add(this.panelSettingsSubMenu);
            this.PanelArayuz.Controls.Add(this.btnSettings);
            this.PanelArayuz.Controls.Add(this.panelBufeSubMenu);
            this.PanelArayuz.Controls.Add(this.btnBufe);
            this.PanelArayuz.Controls.Add(this.panelMemberSubMenu);
            this.PanelArayuz.Controls.Add(this.btnMembers);
            this.PanelArayuz.Controls.Add(this.panelBookSubMenu);
            this.PanelArayuz.Controls.Add(this.btnBooks);
            this.PanelArayuz.Controls.Add(this.btnMenu);
            this.PanelArayuz.Controls.Add(this.panelUstSolMenu);
            this.PanelArayuz.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelArayuz.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PanelArayuz.Location = new System.Drawing.Point(0, 0);
            this.PanelArayuz.Name = "PanelArayuz";
            this.PanelArayuz.Size = new System.Drawing.Size(246, 810);
            this.PanelArayuz.TabIndex = 11;
            // 
            // btnRezevasyon
            // 
            this.btnRezevasyon.BackColor = System.Drawing.Color.Goldenrod;
            this.btnRezevasyon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRezevasyon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRezevasyon.FlatAppearance.BorderSize = 0;
            this.btnRezevasyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezevasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezevasyon.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRezevasyon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRezevasyon.Location = new System.Drawing.Point(0, 920);
            this.btnRezevasyon.Name = "btnRezevasyon";
            this.btnRezevasyon.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRezevasyon.Size = new System.Drawing.Size(246, 45);
            this.btnRezevasyon.TabIndex = 11;
            this.btnRezevasyon.Text = "REZERVASYON";
            this.btnRezevasyon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRezevasyon.UseVisualStyleBackColor = false;
            this.btnRezevasyon.Click += new System.EventHandler(this.btnRezevasyon_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.Goldenrod;
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStatistics.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.Location = new System.Drawing.Point(0, 875);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStatistics.Size = new System.Drawing.Size(246, 45);
            this.btnStatistics.TabIndex = 10;
            this.btnStatistics.Text = "İSTATİSTİKLER";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // panelSettingsSubMenu
            // 
            this.panelSettingsSubMenu.Controls.Add(this.btnKitapAyarlari);
            this.panelSettingsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettingsSubMenu.Location = new System.Drawing.Point(0, 830);
            this.panelSettingsSubMenu.Name = "panelSettingsSubMenu";
            this.panelSettingsSubMenu.Size = new System.Drawing.Size(246, 45);
            this.panelSettingsSubMenu.TabIndex = 9;
            // 
            // btnKitapAyarlari
            // 
            this.btnKitapAyarlari.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnKitapAyarlari.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKitapAyarlari.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKitapAyarlari.FlatAppearance.BorderSize = 0;
            this.btnKitapAyarlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapAyarlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapAyarlari.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnKitapAyarlari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapAyarlari.Location = new System.Drawing.Point(0, 0);
            this.btnKitapAyarlari.Name = "btnKitapAyarlari";
            this.btnKitapAyarlari.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnKitapAyarlari.Size = new System.Drawing.Size(246, 45);
            this.btnKitapAyarlari.TabIndex = 5;
            this.btnKitapAyarlari.Text = "Kitap Ayarları";
            this.btnKitapAyarlari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapAyarlari.UseVisualStyleBackColor = false;
            this.btnKitapAyarlari.Click += new System.EventHandler(this.btnKitapAyarlari_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 785);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(246, 45);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "AYARLAR";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panelBufeSubMenu
            // 
            this.panelBufeSubMenu.Controls.Add(this.btnBufeKasa);
            this.panelBufeSubMenu.Controls.Add(this.BtnBufeStok);
            this.panelBufeSubMenu.Controls.Add(this.BtnBufeSatis);
            this.panelBufeSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBufeSubMenu.Location = new System.Drawing.Point(0, 650);
            this.panelBufeSubMenu.Name = "panelBufeSubMenu";
            this.panelBufeSubMenu.Size = new System.Drawing.Size(246, 135);
            this.panelBufeSubMenu.TabIndex = 7;
            // 
            // btnBufeKasa
            // 
            this.btnBufeKasa.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBufeKasa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBufeKasa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBufeKasa.FlatAppearance.BorderSize = 0;
            this.btnBufeKasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBufeKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBufeKasa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBufeKasa.Image = ((System.Drawing.Image)(resources.GetObject("btnBufeKasa.Image")));
            this.btnBufeKasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBufeKasa.Location = new System.Drawing.Point(0, 90);
            this.btnBufeKasa.Name = "btnBufeKasa";
            this.btnBufeKasa.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBufeKasa.Size = new System.Drawing.Size(246, 45);
            this.btnBufeKasa.TabIndex = 7;
            this.btnBufeKasa.Text = "Kasa";
            this.btnBufeKasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBufeKasa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBufeKasa.UseVisualStyleBackColor = false;
            this.btnBufeKasa.Click += new System.EventHandler(this.btnBufeKasa_Click);
            // 
            // BtnBufeStok
            // 
            this.BtnBufeStok.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnBufeStok.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBufeStok.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBufeStok.FlatAppearance.BorderSize = 0;
            this.BtnBufeStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBufeStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBufeStok.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnBufeStok.Image = ((System.Drawing.Image)(resources.GetObject("BtnBufeStok.Image")));
            this.BtnBufeStok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBufeStok.Location = new System.Drawing.Point(0, 45);
            this.BtnBufeStok.Name = "BtnBufeStok";
            this.BtnBufeStok.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnBufeStok.Size = new System.Drawing.Size(246, 45);
            this.BtnBufeStok.TabIndex = 6;
            this.BtnBufeStok.Text = "Stok";
            this.BtnBufeStok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBufeStok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBufeStok.UseVisualStyleBackColor = false;
            this.BtnBufeStok.Click += new System.EventHandler(this.BtnBufeStok_Click);
            // 
            // BtnBufeSatis
            // 
            this.BtnBufeSatis.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnBufeSatis.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBufeSatis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBufeSatis.FlatAppearance.BorderSize = 0;
            this.BtnBufeSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBufeSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBufeSatis.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnBufeSatis.Image = ((System.Drawing.Image)(resources.GetObject("BtnBufeSatis.Image")));
            this.BtnBufeSatis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBufeSatis.Location = new System.Drawing.Point(0, 0);
            this.BtnBufeSatis.Name = "BtnBufeSatis";
            this.BtnBufeSatis.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnBufeSatis.Size = new System.Drawing.Size(246, 45);
            this.BtnBufeSatis.TabIndex = 4;
            this.BtnBufeSatis.Text = "Satış ";
            this.BtnBufeSatis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBufeSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBufeSatis.UseVisualStyleBackColor = false;
            this.BtnBufeSatis.Click += new System.EventHandler(this.BtnBufeSatis_Click);
            // 
            // btnBufe
            // 
            this.btnBufe.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBufe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBufe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBufe.FlatAppearance.BorderSize = 0;
            this.btnBufe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBufe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBufe.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBufe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBufe.Location = new System.Drawing.Point(0, 605);
            this.btnBufe.Name = "btnBufe";
            this.btnBufe.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBufe.Size = new System.Drawing.Size(246, 45);
            this.btnBufe.TabIndex = 6;
            this.btnBufe.Text = "BÜFE";
            this.btnBufe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBufe.UseVisualStyleBackColor = false;
            this.btnBufe.Click += new System.EventHandler(this.btnBufe_Click);
            // 
            // panelMemberSubMenu
            // 
            this.panelMemberSubMenu.Controls.Add(this.btnMemberSearch);
            this.panelMemberSubMenu.Controls.Add(this.btnMemberUpdate);
            this.panelMemberSubMenu.Controls.Add(this.btnMemberAdd);
            this.panelMemberSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMemberSubMenu.Location = new System.Drawing.Point(0, 470);
            this.panelMemberSubMenu.Name = "panelMemberSubMenu";
            this.panelMemberSubMenu.Size = new System.Drawing.Size(246, 135);
            this.panelMemberSubMenu.TabIndex = 5;
            // 
            // btnMemberSearch
            // 
            this.btnMemberSearch.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMemberSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemberSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMemberSearch.FlatAppearance.BorderSize = 0;
            this.btnMemberSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMemberSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMemberSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnMemberSearch.Image")));
            this.btnMemberSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberSearch.Location = new System.Drawing.Point(0, 90);
            this.btnMemberSearch.Name = "btnMemberSearch";
            this.btnMemberSearch.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMemberSearch.Size = new System.Drawing.Size(246, 45);
            this.btnMemberSearch.TabIndex = 7;
            this.btnMemberSearch.Text = "Üye Ara";
            this.btnMemberSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMemberSearch.UseVisualStyleBackColor = false;
            this.btnMemberSearch.Click += new System.EventHandler(this.btnMemberSearch_Click);
            // 
            // btnMemberUpdate
            // 
            this.btnMemberUpdate.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMemberUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemberUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMemberUpdate.FlatAppearance.BorderSize = 0;
            this.btnMemberUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMemberUpdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMemberUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnMemberUpdate.Image")));
            this.btnMemberUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberUpdate.Location = new System.Drawing.Point(0, 45);
            this.btnMemberUpdate.Name = "btnMemberUpdate";
            this.btnMemberUpdate.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMemberUpdate.Size = new System.Drawing.Size(246, 45);
            this.btnMemberUpdate.TabIndex = 5;
            this.btnMemberUpdate.Text = "Üye Güncelle";
            this.btnMemberUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMemberUpdate.UseVisualStyleBackColor = false;
            this.btnMemberUpdate.Click += new System.EventHandler(this.btnMemberUpdate_Click);
            // 
            // btnMemberAdd
            // 
            this.btnMemberAdd.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMemberAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemberAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMemberAdd.FlatAppearance.BorderSize = 0;
            this.btnMemberAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMemberAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMemberAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnMemberAdd.Image")));
            this.btnMemberAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberAdd.Location = new System.Drawing.Point(0, 0);
            this.btnMemberAdd.Name = "btnMemberAdd";
            this.btnMemberAdd.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMemberAdd.Size = new System.Drawing.Size(246, 45);
            this.btnMemberAdd.TabIndex = 4;
            this.btnMemberAdd.Text = "Üye Ekle";
            this.btnMemberAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMemberAdd.UseVisualStyleBackColor = false;
            this.btnMemberAdd.Click += new System.EventHandler(this.btnMemberAdd_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.Color.Goldenrod;
            this.btnMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMembers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMembers.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(0, 425);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMembers.Size = new System.Drawing.Size(246, 45);
            this.btnMembers.TabIndex = 4;
            this.btnMembers.Text = "ÜYELİK";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.UseVisualStyleBackColor = false;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // panelBookSubMenu
            // 
            this.panelBookSubMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelBookSubMenu.Controls.Add(this.btnKitapGuncelle);
            this.panelBookSubMenu.Controls.Add(this.btnBookLoan);
            this.panelBookSubMenu.Controls.Add(this.btnBookLoan1);
            this.panelBookSubMenu.Controls.Add(this.btnBookSearch);
            this.panelBookSubMenu.Controls.Add(this.btnBookAdd);
            this.panelBookSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBookSubMenu.Location = new System.Drawing.Point(0, 200);
            this.panelBookSubMenu.Name = "panelBookSubMenu";
            this.panelBookSubMenu.Size = new System.Drawing.Size(246, 225);
            this.panelBookSubMenu.TabIndex = 3;
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnKitapGuncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKitapGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKitapGuncelle.FlatAppearance.BorderSize = 0;
            this.btnKitapGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapGuncelle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnKitapGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnKitapGuncelle.Image")));
            this.btnKitapGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapGuncelle.Location = new System.Drawing.Point(0, 180);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnKitapGuncelle.Size = new System.Drawing.Size(246, 45);
            this.btnKitapGuncelle.TabIndex = 7;
            this.btnKitapGuncelle.Text = "Kitap Güncelle";
            this.btnKitapGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKitapGuncelle.UseVisualStyleBackColor = false;
            this.btnKitapGuncelle.Click += new System.EventHandler(this.btnKitapGuncelle_Click);
            // 
            // btnBookLoan
            // 
            this.btnBookLoan.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBookLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookLoan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBookLoan.FlatAppearance.BorderSize = 0;
            this.btnBookLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookLoan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBookLoan.Image = ((System.Drawing.Image)(resources.GetObject("btnBookLoan.Image")));
            this.btnBookLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookLoan.Location = new System.Drawing.Point(0, 135);
            this.btnBookLoan.Name = "btnBookLoan";
            this.btnBookLoan.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBookLoan.Size = new System.Drawing.Size(246, 45);
            this.btnBookLoan.TabIndex = 6;
            this.btnBookLoan.Text = "Kitap Ödünç Ver";
            this.btnBookLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookLoan.UseVisualStyleBackColor = false;
            this.btnBookLoan.Click += new System.EventHandler(this.btnBookLoan_Click);
            // 
            // btnBookLoan1
            // 
            this.btnBookLoan1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBookLoan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookLoan1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBookLoan1.FlatAppearance.BorderSize = 0;
            this.btnBookLoan1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookLoan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookLoan1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBookLoan1.Image = ((System.Drawing.Image)(resources.GetObject("btnBookLoan1.Image")));
            this.btnBookLoan1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookLoan1.Location = new System.Drawing.Point(0, 90);
            this.btnBookLoan1.Name = "btnBookLoan1";
            this.btnBookLoan1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBookLoan1.Size = new System.Drawing.Size(246, 45);
            this.btnBookLoan1.TabIndex = 5;
            this.btnBookLoan1.Text = "Kitap Teslim Al";
            this.btnBookLoan1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookLoan1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookLoan1.UseVisualStyleBackColor = false;
            this.btnBookLoan1.Click += new System.EventHandler(this.btnBookLoan1_Click);
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBookSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBookSearch.FlatAppearance.BorderSize = 0;
            this.btnBookSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBookSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnBookSearch.Image")));
            this.btnBookSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookSearch.Location = new System.Drawing.Point(0, 45);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBookSearch.Size = new System.Drawing.Size(246, 45);
            this.btnBookSearch.TabIndex = 4;
            this.btnBookSearch.Text = "Kitap Ara";
            this.btnBookSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookSearch.UseVisualStyleBackColor = false;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBookAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBookAdd.FlatAppearance.BorderSize = 0;
            this.btnBookAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBookAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnBookAdd.Image")));
            this.btnBookAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookAdd.Location = new System.Drawing.Point(0, 0);
            this.btnBookAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBookAdd.Size = new System.Drawing.Size(246, 45);
            this.btnBookAdd.TabIndex = 3;
            this.btnBookAdd.Text = "Kitap Ekle";
            this.btnBookAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookAdd.UseVisualStyleBackColor = false;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // panelUstSolMenu
            // 
            this.panelUstSolMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelUstSolMenu.BackColor = System.Drawing.Color.LightGreen;
            this.panelUstSolMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUstSolMenu.Controls.Add(this.label2);
            this.panelUstSolMenu.Controls.Add(this.label1);
            this.panelUstSolMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUstSolMenu.Location = new System.Drawing.Point(0, 0);
            this.panelUstSolMenu.Name = "panelUstSolMenu";
            this.panelUstSolMenu.Size = new System.Drawing.Size(246, 110);
            this.panelUstSolMenu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "KİTAP KAHVE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "KİHMED";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUstMenu
            // 
            this.panelUstMenu.BackColor = System.Drawing.Color.LightGreen;
            this.panelUstMenu.Controls.Add(this.lblName);
            this.panelUstMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUstMenu.Location = new System.Drawing.Point(246, 0);
            this.panelUstMenu.Name = "panelUstMenu";
            this.panelUstMenu.Size = new System.Drawing.Size(1036, 110);
            this.panelUstMenu.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(434, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(206, 44);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "ANASAYFA";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.btnGecikme);
            this.panel1.Location = new System.Drawing.Point(246, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 863);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(294, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(512, 70);
            this.label3.TabIndex = 2;
            this.label3.Text = "KİHMED KİTAP KAHVE";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.LightGray;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Location = new System.Drawing.Point(1002, 654);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(34, 23);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGecikme
            // 
            this.btnGecikme.BackColor = System.Drawing.Color.LightGray;
            this.btnGecikme.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGecikme.FlatAppearance.BorderSize = 0;
            this.btnGecikme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGecikme.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGecikme.Location = new System.Drawing.Point(0, 818);
            this.btnGecikme.Name = "btnGecikme";
            this.btnGecikme.Size = new System.Drawing.Size(1036, 45);
            this.btnGecikme.TabIndex = 0;
            this.btnGecikme.UseVisualStyleBackColor = false;
            this.btnGecikme.Visible = false;
            this.btnGecikme.Click += new System.EventHandler(this.btnGecikme_Click);
            // 
            // PanelSideMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1282, 810);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelUstMenu);
            this.Controls.Add(this.PanelArayuz);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PanelSideMenu";
            this.Text = "KİHMED Kitap & Kahve";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelArayuz.ResumeLayout(false);
            this.panelSettingsSubMenu.ResumeLayout(false);
            this.panelBufeSubMenu.ResumeLayout(false);
            this.panelMemberSubMenu.ResumeLayout(false);
            this.panelBookSubMenu.ResumeLayout(false);
            this.panelUstSolMenu.ResumeLayout(false);
            this.panelUstSolMenu.PerformLayout();
            this.panelUstMenu.ResumeLayout(false);
            this.panelUstMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Panel PanelArayuz;
        private System.Windows.Forms.Panel panelBookSubMenu;
        private System.Windows.Forms.Button btnBookLoan1;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Panel panelUstSolMenu;
        private System.Windows.Forms.Panel panelMemberSubMenu;
        private System.Windows.Forms.Button btnMemberUpdate;
        private System.Windows.Forms.Button btnMemberAdd;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnMemberSearch;
        private System.Windows.Forms.Button btnBookLoan;
        private System.Windows.Forms.Button btnBufe;
        private System.Windows.Forms.Panel panelBufeSubMenu;
        private System.Windows.Forms.Button BtnBufeStok;
        private System.Windows.Forms.Button BtnBufeSatis;
        private System.Windows.Forms.Panel panelSettingsSubMenu;
        private System.Windows.Forms.Button btnKitapAyarlari;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnBufeKasa;
        private System.Windows.Forms.Panel panelUstMenu;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGecikme;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKitapGuncelle;
        private System.Windows.Forms.Button btnRezevasyon;
    }
}

