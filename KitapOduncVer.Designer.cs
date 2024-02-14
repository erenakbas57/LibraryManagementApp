
namespace Kutuphanecsharp
{
    partial class KitapOduncVer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uyeAdtbx = new System.Windows.Forms.TextBox();
            this.uyeSoyadtbx = new System.Windows.Forms.TextBox();
            this.kitapAdtbx = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.lblwarning = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblkitap = new System.Windows.Forms.Label();
            this.tbxAraKitap = new System.Windows.Forms.TextBox();
            this.tbxAraUye = new System.Windows.Forms.TextBox();
            this.dgwKitap = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.rafid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgwUye = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUye)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(993, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(372, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "AD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(343, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "SOYAD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(326, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "KİTAP ADI :";
            // 
            // uyeAdtbx
            // 
            this.uyeAdtbx.BackColor = System.Drawing.Color.White;
            this.uyeAdtbx.Enabled = false;
            this.uyeAdtbx.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.uyeAdtbx.Location = new System.Drawing.Point(447, 431);
            this.uyeAdtbx.Multiline = true;
            this.uyeAdtbx.Name = "uyeAdtbx";
            this.uyeAdtbx.Size = new System.Drawing.Size(124, 30);
            this.uyeAdtbx.TabIndex = 53;
            // 
            // uyeSoyadtbx
            // 
            this.uyeSoyadtbx.BackColor = System.Drawing.Color.White;
            this.uyeSoyadtbx.Enabled = false;
            this.uyeSoyadtbx.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.uyeSoyadtbx.Location = new System.Drawing.Point(447, 483);
            this.uyeSoyadtbx.Multiline = true;
            this.uyeSoyadtbx.Name = "uyeSoyadtbx";
            this.uyeSoyadtbx.Size = new System.Drawing.Size(124, 30);
            this.uyeSoyadtbx.TabIndex = 54;
            // 
            // kitapAdtbx
            // 
            this.kitapAdtbx.BackColor = System.Drawing.Color.White;
            this.kitapAdtbx.Enabled = false;
            this.kitapAdtbx.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.kitapAdtbx.Location = new System.Drawing.Point(447, 537);
            this.kitapAdtbx.Multiline = true;
            this.kitapAdtbx.Name = "kitapAdtbx";
            this.kitapAdtbx.Size = new System.Drawing.Size(124, 30);
            this.kitapAdtbx.TabIndex = 55;
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.White;
            this.btnKayit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKayit.Location = new System.Drawing.Point(588, 471);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(137, 51);
            this.btnKayit.TabIndex = 56;
            this.btnKayit.Text = "ÖDÜNÇ VER";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwarning.ForeColor = System.Drawing.Color.Red;
            this.lblwarning.Location = new System.Drawing.Point(607, 537);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(0, 22);
            this.lblwarning.TabIndex = 57;
            this.lblwarning.Visible = false;
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblad.ForeColor = System.Drawing.Color.Red;
            this.lblad.Location = new System.Drawing.Point(424, 432);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(17, 22);
            this.lblad.TabIndex = 58;
            this.lblad.Text = "*";
            this.lblad.Visible = false;
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoyad.ForeColor = System.Drawing.Color.Red;
            this.lblsoyad.Location = new System.Drawing.Point(424, 481);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(17, 22);
            this.lblsoyad.TabIndex = 59;
            this.lblsoyad.Text = "*";
            this.lblsoyad.Visible = false;
            // 
            // lblkitap
            // 
            this.lblkitap.AutoSize = true;
            this.lblkitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkitap.ForeColor = System.Drawing.Color.Red;
            this.lblkitap.Location = new System.Drawing.Point(424, 537);
            this.lblkitap.Name = "lblkitap";
            this.lblkitap.Size = new System.Drawing.Size(17, 22);
            this.lblkitap.TabIndex = 60;
            this.lblkitap.Text = "*";
            this.lblkitap.Visible = false;
            // 
            // tbxAraKitap
            // 
            this.tbxAraKitap.BackColor = System.Drawing.Color.White;
            this.tbxAraKitap.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbxAraKitap.Location = new System.Drawing.Point(16, 48);
            this.tbxAraKitap.Name = "tbxAraKitap";
            this.tbxAraKitap.Size = new System.Drawing.Size(100, 22);
            this.tbxAraKitap.TabIndex = 61;
            this.tbxAraKitap.TextChanged += new System.EventHandler(this.tbxAraKitap_TextChanged);
            // 
            // tbxAraUye
            // 
            this.tbxAraUye.BackColor = System.Drawing.Color.White;
            this.tbxAraUye.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbxAraUye.Location = new System.Drawing.Point(16, 251);
            this.tbxAraUye.Name = "tbxAraUye";
            this.tbxAraUye.Size = new System.Drawing.Size(100, 22);
            this.tbxAraUye.TabIndex = 62;
            this.tbxAraUye.TextChanged += new System.EventHandler(this.tbxAraUye_TextChanged);
            // 
            // dgwKitap
            // 
            this.dgwKitap.AllowUserToAddRows = false;
            this.dgwKitap.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgwKitap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKitap.BackgroundColor = System.Drawing.Color.White;
            this.dgwKitap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwKitap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwKitap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwKitap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwKitap.ColumnHeadersHeight = 40;
            this.dgwKitap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rafid,
            this.book,
            this.author,
            this.publisher,
            this.durum});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwKitap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgwKitap.DoubleBuffered = true;
            this.dgwKitap.EnableHeadersVisualStyles = false;
            this.dgwKitap.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgwKitap.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(234)))));
            this.dgwKitap.HeaderForeColor = System.Drawing.Color.White;
            this.dgwKitap.Location = new System.Drawing.Point(133, 48);
            this.dgwKitap.Name = "dgwKitap";
            this.dgwKitap.ReadOnly = true;
            this.dgwKitap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwKitap.RowHeadersWidth = 51;
            this.dgwKitap.RowTemplate.DividerHeight = 3;
            this.dgwKitap.RowTemplate.Height = 24;
            this.dgwKitap.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwKitap.Size = new System.Drawing.Size(837, 174);
            this.dgwKitap.TabIndex = 66;
            this.dgwKitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKitap_CellClick_1);
            // 
            // rafid
            // 
            this.rafid.DataPropertyName = "rafid";
            this.rafid.HeaderText = "RAF";
            this.rafid.MinimumWidth = 6;
            this.rafid.Name = "rafid";
            this.rafid.ReadOnly = true;
            // 
            // book
            // 
            this.book.DataPropertyName = "book";
            this.book.HeaderText = "KİTAP";
            this.book.MinimumWidth = 6;
            this.book.Name = "book";
            this.book.ReadOnly = true;
            // 
            // author
            // 
            this.author.DataPropertyName = "author";
            this.author.HeaderText = "YAZAR";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // publisher
            // 
            this.publisher.DataPropertyName = "publisher";
            this.publisher.HeaderText = "YAYINEVİ";
            this.publisher.MinimumWidth = 6;
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            // 
            // durum
            // 
            this.durum.DataPropertyName = "durum";
            this.durum.HeaderText = "DURUM";
            this.durum.MinimumWidth = 6;
            this.durum.Name = "durum";
            this.durum.ReadOnly = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dgwUye
            // 
            this.dgwUye.AllowUserToAddRows = false;
            this.dgwUye.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgwUye.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwUye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUye.BackgroundColor = System.Drawing.Color.White;
            this.dgwUye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwUye.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwUye.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwUye.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwUye.ColumnHeadersHeight = 40;
            this.dgwUye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.surname,
            this.birthdate,
            this.phone,
            this.address});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwUye.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgwUye.DoubleBuffered = true;
            this.dgwUye.EnableHeadersVisualStyles = false;
            this.dgwUye.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgwUye.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(234)))));
            this.dgwUye.HeaderForeColor = System.Drawing.Color.White;
            this.dgwUye.Location = new System.Drawing.Point(133, 251);
            this.dgwUye.Name = "dgwUye";
            this.dgwUye.ReadOnly = true;
            this.dgwUye.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwUye.RowHeadersWidth = 51;
            this.dgwUye.RowTemplate.DividerHeight = 3;
            this.dgwUye.RowTemplate.Height = 24;
            this.dgwUye.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwUye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwUye.Size = new System.Drawing.Size(837, 174);
            this.dgwUye.TabIndex = 67;
            this.dgwUye.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUye_CellClick_1);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "AD";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.DataPropertyName = "surname";
            this.surname.HeaderText = "SOYAD";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // birthdate
            // 
            this.birthdate.DataPropertyName = "birthdate";
            this.birthdate.HeaderText = "DOĞUM TARİHİ";
            this.birthdate.MinimumWidth = 6;
            this.birthdate.Name = "birthdate";
            this.birthdate.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "TELEFON";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "ADRES";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // KitapOduncVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1030, 603);
            this.Controls.Add(this.dgwUye);
            this.Controls.Add(this.dgwKitap);
            this.Controls.Add(this.tbxAraUye);
            this.Controls.Add(this.tbxAraKitap);
            this.Controls.Add(this.lblkitap);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.kitapAdtbx);
            this.Controls.Add(this.uyeSoyadtbx);
            this.Controls.Add(this.uyeAdtbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitapOduncVer";
            this.Text = "KitapOdunc";
            this.Load += new System.EventHandler(this.KitapOdunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uyeAdtbx;
        private System.Windows.Forms.TextBox uyeSoyadtbx;
        private System.Windows.Forms.TextBox kitapAdtbx;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblkitap;
        private System.Windows.Forms.TextBox tbxAraKitap;
        private System.Windows.Forms.TextBox tbxAraUye;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwKitap;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rafid;
        private System.Windows.Forms.DataGridViewTextBoxColumn book;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn durum;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwUye;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}