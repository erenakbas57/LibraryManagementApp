
namespace Kutuphanecsharp
{
    partial class KitapGuncelle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelwarning = new System.Windows.Forms.Label();
            this.cbxraf = new System.Windows.Forms.ComboBox();
            this.cbxkategori = new System.Windows.Forms.ComboBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labelkategori = new System.Windows.Forms.Label();
            this.labelyayinevi = new System.Windows.Forms.Label();
            this.labelyazar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelkitap = new System.Windows.Forms.Label();
            this.tbxad = new System.Windows.Forms.TextBox();
            this.labelraf = new System.Windows.Forms.Label();
            this.tbxyazar = new System.Windows.Forms.TextBox();
            this.tbxyayinevi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgw1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rafid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxara = new System.Windows.Forms.TextBox();
            this.btnara = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelwarning);
            this.groupBox1.Controls.Add(this.cbxraf);
            this.groupBox1.Controls.Add(this.cbxkategori);
            this.groupBox1.Controls.Add(this.lblWarning);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.labelkategori);
            this.groupBox1.Controls.Add(this.labelyayinevi);
            this.groupBox1.Controls.Add(this.labelyazar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labelkitap);
            this.groupBox1.Controls.Add(this.tbxad);
            this.groupBox1.Controls.Add(this.labelraf);
            this.groupBox1.Controls.Add(this.tbxyazar);
            this.groupBox1.Controls.Add(this.tbxyayinevi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(274, 305);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(426, 287);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KAYIT GÜNCELLE";
            // 
            // labelwarning
            // 
            this.labelwarning.AutoSize = true;
            this.labelwarning.Location = new System.Drawing.Point(161, 195);
            this.labelwarning.Name = "labelwarning";
            this.labelwarning.Size = new System.Drawing.Size(0, 22);
            this.labelwarning.TabIndex = 55;
            this.labelwarning.Visible = false;
            // 
            // cbxraf
            // 
            this.cbxraf.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbxraf.FormattingEnabled = true;
            this.cbxraf.Location = new System.Drawing.Point(160, 37);
            this.cbxraf.Name = "cbxraf";
            this.cbxraf.Size = new System.Drawing.Size(244, 30);
            this.cbxraf.TabIndex = 54;
            // 
            // cbxkategori
            // 
            this.cbxkategori.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbxkategori.FormattingEnabled = true;
            this.cbxkategori.Location = new System.Drawing.Point(161, 158);
            this.cbxkategori.Name = "cbxkategori";
            this.cbxkategori.Size = new System.Drawing.Size(244, 30);
            this.cbxkategori.TabIndex = 53;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(248, 364);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 18);
            this.lblWarning.TabIndex = 52;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(266, 240);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 39);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // labelkategori
            // 
            this.labelkategori.AutoSize = true;
            this.labelkategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelkategori.ForeColor = System.Drawing.Color.Red;
            this.labelkategori.Location = new System.Drawing.Point(133, 157);
            this.labelkategori.Name = "labelkategori";
            this.labelkategori.Size = new System.Drawing.Size(21, 25);
            this.labelkategori.TabIndex = 48;
            this.labelkategori.Text = "*";
            this.labelkategori.Visible = false;
            // 
            // labelyayinevi
            // 
            this.labelyayinevi.AutoSize = true;
            this.labelyayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelyayinevi.ForeColor = System.Drawing.Color.Red;
            this.labelyayinevi.Location = new System.Drawing.Point(133, 127);
            this.labelyayinevi.Name = "labelyayinevi";
            this.labelyayinevi.Size = new System.Drawing.Size(21, 25);
            this.labelyayinevi.TabIndex = 47;
            this.labelyayinevi.Text = "*";
            this.labelyayinevi.Visible = false;
            // 
            // labelyazar
            // 
            this.labelyazar.AutoSize = true;
            this.labelyazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelyazar.ForeColor = System.Drawing.Color.Red;
            this.labelyazar.Location = new System.Drawing.Point(133, 97);
            this.labelyazar.Name = "labelyazar";
            this.labelyazar.Size = new System.Drawing.Size(21, 25);
            this.labelyazar.TabIndex = 46;
            this.labelyazar.Text = "*";
            this.labelyazar.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(72, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 27);
            this.label9.TabIndex = 21;
            this.label9.Text = "RAF :";
            // 
            // labelkitap
            // 
            this.labelkitap.AutoSize = true;
            this.labelkitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelkitap.ForeColor = System.Drawing.Color.Red;
            this.labelkitap.Location = new System.Drawing.Point(133, 67);
            this.labelkitap.Name = "labelkitap";
            this.labelkitap.Size = new System.Drawing.Size(21, 25);
            this.labelkitap.TabIndex = 45;
            this.labelkitap.Text = "*";
            this.labelkitap.Visible = false;
            // 
            // tbxad
            // 
            this.tbxad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxad.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbxad.Location = new System.Drawing.Point(160, 72);
            this.tbxad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxad.Name = "tbxad";
            this.tbxad.Size = new System.Drawing.Size(245, 27);
            this.tbxad.TabIndex = 23;
            // 
            // labelraf
            // 
            this.labelraf.AutoSize = true;
            this.labelraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelraf.ForeColor = System.Drawing.Color.Red;
            this.labelraf.Location = new System.Drawing.Point(133, 37);
            this.labelraf.Name = "labelraf";
            this.labelraf.Size = new System.Drawing.Size(21, 25);
            this.labelraf.TabIndex = 44;
            this.labelraf.Text = "*";
            this.labelraf.Visible = false;
            // 
            // tbxyazar
            // 
            this.tbxyazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxyazar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbxyazar.Location = new System.Drawing.Point(160, 101);
            this.tbxyazar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxyazar.MaxLength = 11;
            this.tbxyazar.Name = "tbxyazar";
            this.tbxyazar.Size = new System.Drawing.Size(245, 27);
            this.tbxyazar.TabIndex = 24;
            // 
            // tbxyayinevi
            // 
            this.tbxyayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxyayinevi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbxyayinevi.Location = new System.Drawing.Point(160, 129);
            this.tbxyayinevi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxyayinevi.MaxLength = 11;
            this.tbxyayinevi.Name = "tbxyayinevi";
            this.tbxyayinevi.Size = new System.Drawing.Size(245, 27);
            this.tbxyayinevi.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(54, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 27;
            this.label2.Text = "KİTAP :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(45, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "YAZAR :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(19, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 27);
            this.label4.TabIndex = 29;
            this.label4.Text = "YAYINEVİ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(11, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 27);
            this.label6.TabIndex = 31;
            this.label6.Text = "KATEGORİ :";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgw1.ColumnHeadersHeight = 40;
            this.dgw1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.rafid,
            this.book,
            this.author,
            this.publisher,
            this.category,
            this.durum});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgw1.DoubleBuffered = true;
            this.dgw1.EnableHeadersVisualStyles = false;
            this.dgw1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgw1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(234)))));
            this.dgw1.HeaderForeColor = System.Drawing.Color.White;
            this.dgw1.Location = new System.Drawing.Point(61, 57);
            this.dgw1.Name = "dgw1";
            this.dgw1.ReadOnly = true;
            this.dgw1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgw1.RowHeadersWidth = 51;
            this.dgw1.RowTemplate.DividerHeight = 3;
            this.dgw1.RowTemplate.Height = 24;
            this.dgw1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw1.Size = new System.Drawing.Size(868, 243);
            this.dgw1.TabIndex = 51;
            this.dgw1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw1_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
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
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "KATEGORİ";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // durum
            // 
            this.durum.DataPropertyName = "durum";
            this.durum.HeaderText = "DURUM";
            this.durum.MinimumWidth = 6;
            this.durum.Name = "durum";
            this.durum.ReadOnly = true;
            this.durum.Visible = false;
            // 
            // tbxara
            // 
            this.tbxara.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbxara.Location = new System.Drawing.Point(62, 23);
            this.tbxara.Multiline = true;
            this.tbxara.Name = "tbxara";
            this.tbxara.Size = new System.Drawing.Size(100, 27);
            this.tbxara.TabIndex = 72;
            // 
            // btnara
            // 
            this.btnara.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnara.Location = new System.Drawing.Point(168, 23);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(89, 28);
            this.btnara.TabIndex = 71;
            this.btnara.Text = "ARA";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // KitapGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 603);
            this.Controls.Add(this.tbxara);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.dgw1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitapGuncelle";
            this.Text = "KitapGuncelle";
            this.Load += new System.EventHandler(this.KitapGuncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labelkategori;
        private System.Windows.Forms.Label labelyayinevi;
        private System.Windows.Forms.Label labelyazar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelkitap;
        private System.Windows.Forms.TextBox tbxad;
        private System.Windows.Forms.Label labelraf;
        private System.Windows.Forms.TextBox tbxyazar;
        private System.Windows.Forms.TextBox tbxyayinevi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxraf;
        private System.Windows.Forms.ComboBox cbxkategori;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgw1;
        private System.Windows.Forms.TextBox tbxara;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Label labelwarning;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rafid;
        private System.Windows.Forms.DataGridViewTextBoxColumn book;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn durum;
    }
}