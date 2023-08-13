
namespace Kutuphanecsharp
{
    partial class BufeKasa
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
            this.lblgunluk = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblaylik = new System.Windows.Forms.Label();
            this.dtpfirst = new System.Windows.Forms.DateTimePicker();
            this.dtplast = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnCiroEkle = new System.Windows.Forms.Button();
            this.lbltarih = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgw1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgw2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gunluk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw2)).BeginInit();
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
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(240, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 52;
            this.label1.Text = "Günlük Satış :";
            // 
            // lblgunluk
            // 
            this.lblgunluk.AutoSize = true;
            this.lblgunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgunluk.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblgunluk.Location = new System.Drawing.Point(452, 510);
            this.lblgunluk.Name = "lblgunluk";
            this.lblgunluk.Size = new System.Drawing.Size(32, 32);
            this.lblgunluk.TabIndex = 53;
            this.lblgunluk.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(581, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 32);
            this.label5.TabIndex = 56;
            this.label5.Text = "Aylık Satış :";
            // 
            // lblaylik
            // 
            this.lblaylik.AutoSize = true;
            this.lblaylik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblaylik.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblaylik.Location = new System.Drawing.Point(762, 510);
            this.lblaylik.Name = "lblaylik";
            this.lblaylik.Size = new System.Drawing.Size(32, 32);
            this.lblaylik.TabIndex = 57;
            this.lblaylik.Text = "0";
            // 
            // dtpfirst
            // 
            this.dtpfirst.CustomFormat = "yyyy.MM.dd";
            this.dtpfirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfirst.Location = new System.Drawing.Point(73, 362);
            this.dtpfirst.Name = "dtpfirst";
            this.dtpfirst.Size = new System.Drawing.Size(134, 22);
            this.dtpfirst.TabIndex = 59;
            // 
            // dtplast
            // 
            this.dtplast.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtplast.Location = new System.Drawing.Point(321, 362);
            this.dtplast.Name = "dtplast";
            this.dtplast.Size = new System.Drawing.Size(134, 22);
            this.dtplast.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(276, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Satış :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(225, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 62;
            this.label3.Text = "arasında";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSonuc.Location = new System.Drawing.Point(349, 411);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(23, 25);
            this.lblSonuc.TabIndex = 63;
            this.lblSonuc.Text = "0";
            this.lblSonuc.Visible = false;
            // 
            // btnHesapla
            // 
            this.btnHesapla.FlatAppearance.BorderSize = 0;
            this.btnHesapla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHesapla.Location = new System.Drawing.Point(135, 409);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(84, 27);
            this.btnHesapla.TabIndex = 64;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnCiroEkle
            // 
            this.btnCiroEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCiroEkle.Location = new System.Drawing.Point(710, 354);
            this.btnCiroEkle.Name = "btnCiroEkle";
            this.btnCiroEkle.Size = new System.Drawing.Size(155, 43);
            this.btnCiroEkle.TabIndex = 67;
            this.btnCiroEkle.Text = "Günlük Kazancı Ekle";
            this.btnCiroEkle.UseVisualStyleBackColor = true;
            this.btnCiroEkle.Click += new System.EventHandler(this.btnCiroEkle_Click);
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Location = new System.Drawing.Point(972, 577);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(48, 17);
            this.lbltarih.TabIndex = 68;
            this.lbltarih.Text = "SİLME";
            this.lbltarih.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this.dgw1;
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
            this.urun,
            this.adet,
            this.ucret,
            this.tarih});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgw1.DoubleBuffered = true;
            this.dgw1.EnableHeadersVisualStyles = false;
            this.dgw1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgw1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(234)))));
            this.dgw1.HeaderForeColor = System.Drawing.Color.White;
            this.dgw1.Location = new System.Drawing.Point(39, 39);
            this.dgw1.Name = "dgw1";
            this.dgw1.ReadOnly = true;
            this.dgw1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgw1.RowHeadersWidth = 51;
            this.dgw1.RowTemplate.DividerHeight = 3;
            this.dgw1.RowTemplate.Height = 24;
            this.dgw1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw1.Size = new System.Drawing.Size(466, 297);
            this.dgw1.TabIndex = 69;
            // 
            // urun
            // 
            this.urun.DataPropertyName = "urun";
            this.urun.HeaderText = "ÜRÜN";
            this.urun.MinimumWidth = 6;
            this.urun.Name = "urun";
            this.urun.ReadOnly = true;
            // 
            // adet
            // 
            this.adet.DataPropertyName = "adet";
            this.adet.HeaderText = "ADET";
            this.adet.MinimumWidth = 6;
            this.adet.Name = "adet";
            this.adet.ReadOnly = true;
            // 
            // ucret
            // 
            this.ucret.DataPropertyName = "ucret";
            this.ucret.HeaderText = "ÜCRET";
            this.ucret.MinimumWidth = 6;
            this.ucret.Name = "ucret";
            this.ucret.ReadOnly = true;
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "TARİH";
            this.tarih.MinimumWidth = 6;
            this.tarih.Name = "tarih";
            this.tarih.ReadOnly = true;
            // 
            // dgw2
            // 
            this.dgw2.AllowUserToAddRows = false;
            this.dgw2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgw2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgw2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw2.BackgroundColor = System.Drawing.Color.White;
            this.dgw2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgw2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgw2.ColumnHeadersHeight = 40;
            this.dgw2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gunluk,
            this.ciro});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgw2.DoubleBuffered = true;
            this.dgw2.EnableHeadersVisualStyles = false;
            this.dgw2.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgw2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(234)))));
            this.dgw2.HeaderForeColor = System.Drawing.Color.White;
            this.dgw2.Location = new System.Drawing.Point(627, 39);
            this.dgw2.Name = "dgw2";
            this.dgw2.ReadOnly = true;
            this.dgw2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgw2.RowHeadersWidth = 51;
            this.dgw2.RowTemplate.DividerHeight = 3;
            this.dgw2.RowTemplate.Height = 24;
            this.dgw2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw2.Size = new System.Drawing.Size(333, 297);
            this.dgw2.TabIndex = 70;
            // 
            // gunluk
            // 
            this.gunluk.DataPropertyName = "gunluk";
            this.gunluk.HeaderText = "GÜN";
            this.gunluk.MinimumWidth = 6;
            this.gunluk.Name = "gunluk";
            this.gunluk.ReadOnly = true;
            // 
            // ciro
            // 
            this.ciro.DataPropertyName = "ciro";
            this.ciro.HeaderText = "TUTAR";
            this.ciro.MinimumWidth = 6;
            this.ciro.Name = "ciro";
            this.ciro.ReadOnly = true;
            // 
            // BufeKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 603);
            this.Controls.Add(this.dgw2);
            this.Controls.Add(this.dgw1);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.btnCiroEkle);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtplast);
            this.Controls.Add(this.dtpfirst);
            this.Controls.Add(this.lblaylik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblgunluk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BufeKasa";
            this.Text = "BufeKasa";
            this.Load += new System.EventHandler(this.BufeKasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblgunluk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblaylik;
        private System.Windows.Forms.DateTimePicker dtpfirst;
        private System.Windows.Forms.DateTimePicker dtplast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnCiroEkle;
        private System.Windows.Forms.Label lbltarih;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgw1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucret;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgw2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gunluk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciro;
    }
}