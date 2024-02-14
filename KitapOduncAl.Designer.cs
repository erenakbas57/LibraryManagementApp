
namespace Kutuphanecsharp
{
    partial class KitapOduncAl
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.kitapAdtbx = new System.Windows.Forms.TextBox();
            this.uyeSoyadtbx = new System.Windows.Forms.TextBox();
            this.uyeAdtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAra = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgw1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.uyeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rafid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alistarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sontarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltutarad = new System.Windows.Forms.Label();
            this.lbltutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(999, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.White;
            this.btnKayit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKayit.Location = new System.Drawing.Point(573, 441);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(137, 51);
            this.btnKayit.TabIndex = 63;
            this.btnKayit.Text = "TESLİM AL";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // kitapAdtbx
            // 
            this.kitapAdtbx.BackColor = System.Drawing.Color.White;
            this.kitapAdtbx.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.kitapAdtbx.Location = new System.Drawing.Point(420, 480);
            this.kitapAdtbx.Multiline = true;
            this.kitapAdtbx.Name = "kitapAdtbx";
            this.kitapAdtbx.Size = new System.Drawing.Size(100, 22);
            this.kitapAdtbx.TabIndex = 62;
            // 
            // uyeSoyadtbx
            // 
            this.uyeSoyadtbx.BackColor = System.Drawing.Color.White;
            this.uyeSoyadtbx.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.uyeSoyadtbx.Location = new System.Drawing.Point(420, 426);
            this.uyeSoyadtbx.Multiline = true;
            this.uyeSoyadtbx.Name = "uyeSoyadtbx";
            this.uyeSoyadtbx.Size = new System.Drawing.Size(100, 22);
            this.uyeSoyadtbx.TabIndex = 61;
            // 
            // uyeAdtbx
            // 
            this.uyeAdtbx.BackColor = System.Drawing.Color.White;
            this.uyeAdtbx.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.uyeAdtbx.Location = new System.Drawing.Point(420, 374);
            this.uyeAdtbx.Multiline = true;
            this.uyeAdtbx.Name = "uyeAdtbx";
            this.uyeAdtbx.Size = new System.Drawing.Size(100, 22);
            this.uyeAdtbx.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(299, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "KİTAP ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(316, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "SOYAD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(345, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "AD :";
            // 
            // tbxAra
            // 
            this.tbxAra.BackColor = System.Drawing.Color.White;
            this.tbxAra.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbxAra.Location = new System.Drawing.Point(439, 42);
            this.tbxAra.Name = "tbxAra";
            this.tbxAra.Size = new System.Drawing.Size(123, 22);
            this.tbxAra.TabIndex = 64;
            this.tbxAra.TextChanged += new System.EventHandler(this.tbxAra_TextChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dgw1
            // 
            this.dgw1.AllowUserToAddRows = false;
            this.dgw1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgw1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw1.BackgroundColor = System.Drawing.Color.White;
            this.dgw1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgw1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgw1.ColumnHeadersHeight = 40;
            this.dgw1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uyeid,
            this.ad,
            this.soyad,
            this.phone,
            this.kitap,
            this.rafid,
            this.alistarihi,
            this.sontarih,
            this.teslim});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgw1.DoubleBuffered = true;
            this.dgw1.EnableHeadersVisualStyles = false;
            this.dgw1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgw1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(234)))));
            this.dgw1.HeaderForeColor = System.Drawing.Color.White;
            this.dgw1.Location = new System.Drawing.Point(12, 79);
            this.dgw1.Name = "dgw1";
            this.dgw1.ReadOnly = true;
            this.dgw1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgw1.RowHeadersWidth = 51;
            this.dgw1.RowTemplate.DividerHeight = 3;
            this.dgw1.RowTemplate.Height = 24;
            this.dgw1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw1.Size = new System.Drawing.Size(977, 272);
            this.dgw1.TabIndex = 65;
            this.dgw1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw1_CellClick_1);
            // 
            // uyeid
            // 
            this.uyeid.DataPropertyName = "uyeid";
            this.uyeid.HeaderText = "ÜYE İD";
            this.uyeid.MinimumWidth = 6;
            this.uyeid.Name = "uyeid";
            this.uyeid.ReadOnly = true;
            // 
            // ad
            // 
            this.ad.DataPropertyName = "ad";
            this.ad.HeaderText = "AD";
            this.ad.MinimumWidth = 6;
            this.ad.Name = "ad";
            this.ad.ReadOnly = true;
            // 
            // soyad
            // 
            this.soyad.DataPropertyName = "soyad";
            this.soyad.HeaderText = "SOYAD";
            this.soyad.MinimumWidth = 6;
            this.soyad.Name = "soyad";
            this.soyad.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "TELEFON";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // kitap
            // 
            this.kitap.DataPropertyName = "kitap";
            this.kitap.HeaderText = "KİTAP";
            this.kitap.MinimumWidth = 6;
            this.kitap.Name = "kitap";
            this.kitap.ReadOnly = true;
            // 
            // rafid
            // 
            this.rafid.DataPropertyName = "rafid";
            this.rafid.HeaderText = "RAF";
            this.rafid.MinimumWidth = 6;
            this.rafid.Name = "rafid";
            this.rafid.ReadOnly = true;
            // 
            // alistarihi
            // 
            this.alistarihi.DataPropertyName = "alistarihi";
            this.alistarihi.HeaderText = "ALIŞ TARİHİ";
            this.alistarihi.MinimumWidth = 6;
            this.alistarihi.Name = "alistarihi";
            this.alistarihi.ReadOnly = true;
            // 
            // sontarih
            // 
            this.sontarih.DataPropertyName = "sontarih";
            this.sontarih.HeaderText = "SON TARİH";
            this.sontarih.MinimumWidth = 6;
            this.sontarih.Name = "sontarih";
            this.sontarih.ReadOnly = true;
            // 
            // teslim
            // 
            this.teslim.DataPropertyName = "teslim";
            this.teslim.HeaderText = "DURUM";
            this.teslim.MinimumWidth = 6;
            this.teslim.Name = "teslim";
            this.teslim.ReadOnly = true;
            // 
            // lbltutarad
            // 
            this.lbltutarad.AutoSize = true;
            this.lbltutarad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltutarad.ForeColor = System.Drawing.Color.Red;
            this.lbltutarad.Location = new System.Drawing.Point(299, 541);
            this.lbltutarad.Name = "lbltutarad";
            this.lbltutarad.Size = new System.Drawing.Size(137, 18);
            this.lbltutarad.TabIndex = 66;
            this.lbltutarad.Text = "Geç getirme ücreti :";
            this.lbltutarad.Visible = false;
            // 
            // lbltutar
            // 
            this.lbltutar.AutoSize = true;
            this.lbltutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltutar.ForeColor = System.Drawing.Color.Red;
            this.lbltutar.Location = new System.Drawing.Point(459, 541);
            this.lbltutar.Name = "lbltutar";
            this.lbltutar.Size = new System.Drawing.Size(0, 18);
            this.lbltutar.TabIndex = 67;
            this.lbltutar.Visible = false;
            // 
            // KitapOduncAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1036, 644);
            this.Controls.Add(this.lbltutar);
            this.Controls.Add(this.lbltutarad);
            this.Controls.Add(this.dgw1);
            this.Controls.Add(this.tbxAra);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.kitapAdtbx);
            this.Controls.Add(this.uyeSoyadtbx);
            this.Controls.Add(this.uyeAdtbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitapOduncAl";
            this.Text = "KitapOduncAl";
            this.Load += new System.EventHandler(this.KitapOduncAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.TextBox kitapAdtbx;
        private System.Windows.Forms.TextBox uyeSoyadtbx;
        private System.Windows.Forms.TextBox uyeAdtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAra;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgw1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap;
        private System.Windows.Forms.DataGridViewTextBoxColumn rafid;
        private System.Windows.Forms.DataGridViewTextBoxColumn alistarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sontarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslim;
        private System.Windows.Forms.Label lbltutarad;
        private System.Windows.Forms.Label lbltutar;
    }
}