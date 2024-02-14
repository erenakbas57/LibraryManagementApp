namespace Kutuphanecsharp
{
    partial class MemberUpdate
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dgw1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tbxara = new System.Windows.Forms.TextBox();
            this.btnara = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.labeladresg = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.adtbxg = new System.Windows.Forms.TextBox();
            this.labeltelg = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelsoyadg = new System.Windows.Forms.Label();
            this.soyadtbxg = new System.Windows.Forms.TextBox();
            this.labeladg = new System.Windows.Forms.Label();
            this.telefontbxg = new System.Windows.Forms.TextBox();
            this.adrestbxg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // dgw1
            // 
            this.dgw1.AllowUserToAddRows = false;
            this.dgw1.AllowUserToDeleteRows = false;
            this.dgw1.AllowUserToResizeColumns = false;
            this.dgw1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgw1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgw1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgw1.ColumnHeadersHeight = 29;
            this.dgw1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.surname,
            this.phone,
            this.address});
            this.dgw1.DoubleBuffered = true;
            this.dgw1.EnableHeadersVisualStyles = false;
            this.dgw1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgw1.HeaderForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgw1.Location = new System.Drawing.Point(550, 91);
            this.dgw1.Name = "dgw1";
            this.dgw1.ReadOnly = true;
            this.dgw1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgw1.RowHeadersWidth = 51;
            this.dgw1.RowTemplate.Height = 24;
            this.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw1.Size = new System.Drawing.Size(463, 453);
            this.dgw1.TabIndex = 75;
            this.dgw1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw1_CellClick);
            // 
            // tbxara
            // 
            this.tbxara.BackColor = System.Drawing.Color.White;
            this.tbxara.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbxara.Location = new System.Drawing.Point(550, 57);
            this.tbxara.Multiline = true;
            this.tbxara.Name = "tbxara";
            this.tbxara.Size = new System.Drawing.Size(100, 27);
            this.tbxara.TabIndex = 74;
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.White;
            this.btnara.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnara.Location = new System.Drawing.Point(656, 57);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(89, 28);
            this.btnara.TabIndex = 73;
            this.btnara.Text = "ARA";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.lblWarning);
            this.groupBox1.Controls.Add(this.labeladresg);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.adtbxg);
            this.groupBox1.Controls.Add(this.labeltelg);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labelsoyadg);
            this.groupBox1.Controls.Add(this.soyadtbxg);
            this.groupBox1.Controls.Add(this.labeladg);
            this.groupBox1.Controls.Add(this.telefontbxg);
            this.groupBox1.Controls.Add(this.adrestbxg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(17, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(510, 511);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KAYIT GÜNCELLE";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(247, 364);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 18);
            this.lblWarning.TabIndex = 52;
            // 
            // labeladresg
            // 
            this.labeladresg.AutoSize = true;
            this.labeladresg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeladresg.ForeColor = System.Drawing.Color.Red;
            this.labeladresg.Location = new System.Drawing.Point(220, 148);
            this.labeladresg.Name = "labeladresg";
            this.labeladresg.Size = new System.Drawing.Size(21, 25);
            this.labeladresg.TabIndex = 51;
            this.labeladresg.Text = "*";
            this.labeladresg.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(307, 455);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 39);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // adtbxg
            // 
            this.adtbxg.BackColor = System.Drawing.Color.White;
            this.adtbxg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adtbxg.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.adtbxg.Location = new System.Drawing.Point(250, 57);
            this.adtbxg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adtbxg.Name = "adtbxg";
            this.adtbxg.Size = new System.Drawing.Size(245, 27);
            this.adtbxg.TabIndex = 22;
            // 
            // labeltelg
            // 
            this.labeltelg.AutoSize = true;
            this.labeltelg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltelg.ForeColor = System.Drawing.Color.Red;
            this.labeltelg.Location = new System.Drawing.Point(223, 117);
            this.labeltelg.Name = "labeltelg";
            this.labeltelg.Size = new System.Drawing.Size(21, 25);
            this.labeltelg.TabIndex = 46;
            this.labeltelg.Text = "*";
            this.labeltelg.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(173, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 27);
            this.label9.TabIndex = 21;
            this.label9.Text = "AD :";
            // 
            // labelsoyadg
            // 
            this.labelsoyadg.AutoSize = true;
            this.labelsoyadg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsoyadg.ForeColor = System.Drawing.Color.Red;
            this.labelsoyadg.Location = new System.Drawing.Point(223, 87);
            this.labelsoyadg.Name = "labelsoyadg";
            this.labelsoyadg.Size = new System.Drawing.Size(21, 25);
            this.labelsoyadg.TabIndex = 45;
            this.labelsoyadg.Text = "*";
            this.labelsoyadg.Visible = false;
            // 
            // soyadtbxg
            // 
            this.soyadtbxg.BackColor = System.Drawing.Color.White;
            this.soyadtbxg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadtbxg.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.soyadtbxg.Location = new System.Drawing.Point(250, 87);
            this.soyadtbxg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soyadtbxg.Name = "soyadtbxg";
            this.soyadtbxg.Size = new System.Drawing.Size(245, 27);
            this.soyadtbxg.TabIndex = 23;
            // 
            // labeladg
            // 
            this.labeladg.AutoSize = true;
            this.labeladg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeladg.ForeColor = System.Drawing.Color.Red;
            this.labeladg.Location = new System.Drawing.Point(223, 57);
            this.labeladg.Name = "labeladg";
            this.labeladg.Size = new System.Drawing.Size(21, 25);
            this.labeladg.TabIndex = 44;
            this.labeladg.Text = "*";
            this.labeladg.Visible = false;
            // 
            // telefontbxg
            // 
            this.telefontbxg.BackColor = System.Drawing.Color.White;
            this.telefontbxg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefontbxg.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.telefontbxg.Location = new System.Drawing.Point(250, 117);
            this.telefontbxg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefontbxg.MaxLength = 11;
            this.telefontbxg.Name = "telefontbxg";
            this.telefontbxg.Size = new System.Drawing.Size(245, 27);
            this.telefontbxg.TabIndex = 24;
            this.telefontbxg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefontbxg_KeyPress);
            // 
            // adrestbxg
            // 
            this.adrestbxg.BackColor = System.Drawing.Color.White;
            this.adrestbxg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adrestbxg.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.adrestbxg.Location = new System.Drawing.Point(250, 150);
            this.adrestbxg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adrestbxg.Multiline = true;
            this.adrestbxg.Name = "adrestbxg";
            this.adrestbxg.Size = new System.Drawing.Size(245, 184);
            this.adrestbxg.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(133, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 27;
            this.label2.Text = "SOYAD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(115, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "TELEFON :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(132, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 27);
            this.label5.TabIndex = 30;
            this.label5.Text = "ADRES :";
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
            // MemberUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1030, 603);
            this.Controls.Add(this.dgw1);
            this.Controls.Add(this.tbxara);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberUpdate";
            this.Text = "MemberUpdate";
            this.Load += new System.EventHandler(this.MemberUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgw1;
        private System.Windows.Forms.TextBox tbxara;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label labeladresg;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox adtbxg;
        private System.Windows.Forms.Label labeltelg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelsoyadg;
        private System.Windows.Forms.TextBox soyadtbxg;
        private System.Windows.Forms.Label labeladg;
        private System.Windows.Forms.TextBox telefontbxg;
        private System.Windows.Forms.TextBox adrestbxg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}