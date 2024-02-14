
namespace Kutuphanecsharp
{
    partial class AyarKitap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgw2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgw1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rafname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.tbxCategoryDelete = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.tbxCategoryAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnrafDelete = new System.Windows.Forms.Button();
            this.tbxrafDelete = new System.Windows.Forms.TextBox();
            this.raflbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrafadd = new System.Windows.Forms.Button();
            this.tbxraf = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw2);
            this.groupBox1.Controls.Add(this.dgw1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCategoryDelete);
            this.groupBox1.Controls.Add(this.tbxCategoryDelete);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCategoryAdd);
            this.groupBox1.Controls.Add(this.tbxCategoryAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnrafDelete);
            this.groupBox1.Controls.Add(this.tbxrafDelete);
            this.groupBox1.Controls.Add(this.raflbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnrafadd);
            this.groupBox1.Controls.Add(this.tbxraf);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(16, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 234);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitaplık Ayarları";
            // 
            // dgw2
            // 
            this.dgw2.AllowUserToAddRows = false;
            this.dgw2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgw2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw2.BackgroundColor = System.Drawing.Color.White;
            this.dgw2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgw2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgw2.ColumnHeadersHeight = 40;
            this.dgw2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgw2.DoubleBuffered = true;
            this.dgw2.EnableHeadersVisualStyles = false;
            this.dgw2.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgw2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(234)))));
            this.dgw2.HeaderForeColor = System.Drawing.Color.White;
            this.dgw2.Location = new System.Drawing.Point(641, 26);
            this.dgw2.Name = "dgw2";
            this.dgw2.ReadOnly = true;
            this.dgw2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgw2.RowHeadersWidth = 51;
            this.dgw2.RowTemplate.DividerHeight = 3;
            this.dgw2.RowTemplate.Height = 24;
            this.dgw2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw2.Size = new System.Drawing.Size(206, 185);
            this.dgw2.TabIndex = 52;
            // 
            // dgw1
            // 
            this.dgw1.AllowUserToAddRows = false;
            this.dgw1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgw1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgw1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw1.BackgroundColor = System.Drawing.Color.White;
            this.dgw1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgw1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgw1.ColumnHeadersHeight = 40;
            this.dgw1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.rafname});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgw1.DoubleBuffered = true;
            this.dgw1.EnableHeadersVisualStyles = false;
            this.dgw1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgw1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(234)))));
            this.dgw1.HeaderForeColor = System.Drawing.Color.White;
            this.dgw1.Location = new System.Drawing.Point(152, 26);
            this.dgw1.Name = "dgw1";
            this.dgw1.ReadOnly = true;
            this.dgw1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgw1.RowHeadersWidth = 51;
            this.dgw1.RowTemplate.DividerHeight = 3;
            this.dgw1.RowTemplate.Height = 24;
            this.dgw1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw1.Size = new System.Drawing.Size(206, 185);
            this.dgw1.TabIndex = 51;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // rafname
            // 
            this.rafname.DataPropertyName = "rafname";
            this.rafname.HeaderText = "RAF";
            this.rafname.MinimumWidth = 6;
            this.rafname.Name = "rafname";
            this.rafname.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(876, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kategori Sil";
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.BackColor = System.Drawing.Color.White;
            this.btnCategoryDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCategoryDelete.Location = new System.Drawing.Point(874, 123);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(94, 33);
            this.btnCategoryDelete.TabIndex = 17;
            this.btnCategoryDelete.Text = "Sil";
            this.btnCategoryDelete.UseVisualStyleBackColor = false;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // tbxCategoryDelete
            // 
            this.tbxCategoryDelete.BackColor = System.Drawing.Color.White;
            this.tbxCategoryDelete.Location = new System.Drawing.Point(871, 72);
            this.tbxCategoryDelete.Name = "tbxCategoryDelete";
            this.tbxCategoryDelete.Size = new System.Drawing.Size(100, 27);
            this.tbxCategoryDelete.TabIndex = 16;
            this.tbxCategoryDelete.TextChanged += new System.EventHandler(this.tbxCategoryDelete_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.ForeColor = System.Drawing.Color.Red;
            this.lblCategory.Location = new System.Drawing.Point(494, 75);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(17, 22);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "*";
            this.lblCategory.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(504, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kategori Ekle";
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.BackColor = System.Drawing.Color.White;
            this.btnCategoryAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCategoryAdd.Location = new System.Drawing.Point(508, 123);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(94, 33);
            this.btnCategoryAdd.TabIndex = 12;
            this.btnCategoryAdd.Text = "Ekle";
            this.btnCategoryAdd.UseVisualStyleBackColor = false;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // tbxCategoryAdd
            // 
            this.tbxCategoryAdd.BackColor = System.Drawing.Color.White;
            this.tbxCategoryAdd.Location = new System.Drawing.Point(508, 72);
            this.tbxCategoryAdd.Name = "tbxCategoryAdd";
            this.tbxCategoryAdd.Size = new System.Drawing.Size(100, 27);
            this.tbxCategoryAdd.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(397, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Raf Sil";
            // 
            // btnrafDelete
            // 
            this.btnrafDelete.BackColor = System.Drawing.Color.White;
            this.btnrafDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnrafDelete.Location = new System.Drawing.Point(379, 123);
            this.btnrafDelete.Name = "btnrafDelete";
            this.btnrafDelete.Size = new System.Drawing.Size(94, 33);
            this.btnrafDelete.TabIndex = 9;
            this.btnrafDelete.Text = "Sil";
            this.btnrafDelete.UseVisualStyleBackColor = false;
            this.btnrafDelete.Click += new System.EventHandler(this.btnrafDelete_Click);
            // 
            // tbxrafDelete
            // 
            this.tbxrafDelete.BackColor = System.Drawing.Color.White;
            this.tbxrafDelete.Location = new System.Drawing.Point(376, 72);
            this.tbxrafDelete.Name = "tbxrafDelete";
            this.tbxrafDelete.Size = new System.Drawing.Size(100, 27);
            this.tbxrafDelete.TabIndex = 8;
            this.tbxrafDelete.TextChanged += new System.EventHandler(this.tbxrafDelete_TextChanged);
            // 
            // raflbl
            // 
            this.raflbl.AutoSize = true;
            this.raflbl.BackColor = System.Drawing.Color.Transparent;
            this.raflbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raflbl.ForeColor = System.Drawing.Color.Red;
            this.raflbl.Location = new System.Drawing.Point(-1, 75);
            this.raflbl.Name = "raflbl";
            this.raflbl.Size = new System.Drawing.Size(17, 22);
            this.raflbl.TabIndex = 6;
            this.raflbl.Text = "*";
            this.raflbl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Raf Ekle";
            // 
            // btnrafadd
            // 
            this.btnrafadd.BackColor = System.Drawing.Color.White;
            this.btnrafadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnrafadd.Location = new System.Drawing.Point(23, 123);
            this.btnrafadd.Name = "btnrafadd";
            this.btnrafadd.Size = new System.Drawing.Size(94, 33);
            this.btnrafadd.TabIndex = 1;
            this.btnrafadd.Text = "Ekle";
            this.btnrafadd.UseVisualStyleBackColor = false;
            this.btnrafadd.Click += new System.EventHandler(this.btnrafadd_Click);
            // 
            // tbxraf
            // 
            this.tbxraf.BackColor = System.Drawing.Color.White;
            this.tbxraf.Location = new System.Drawing.Point(20, 72);
            this.tbxraf.Name = "tbxraf";
            this.tbxraf.Size = new System.Drawing.Size(100, 27);
            this.tbxraf.TabIndex = 0;
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
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this.dgw1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.FillWeight = 42.78075F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "categoryname";
            this.dataGridViewTextBoxColumn2.FillWeight = 157.2193F;
            this.dataGridViewTextBoxColumn2.HeaderText = "KATEGORİ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // AyarKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1030, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AyarKitap";
            this.Text = "AyarKitap";
            this.Load += new System.EventHandler(this.AyarKitap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnrafDelete;
        private System.Windows.Forms.TextBox tbxrafDelete;
        private System.Windows.Forms.Label raflbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnrafadd;
        private System.Windows.Forms.TextBox tbxraf;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.TextBox tbxCategoryDelete;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.TextBox tbxCategoryAdd;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgw2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgw1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rafname;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}