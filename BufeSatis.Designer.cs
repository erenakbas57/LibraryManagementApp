
namespace Kutuphanecsharp
{
    partial class BufeSatis
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lbxAd = new System.Windows.Forms.ListBox();
            this.lbxAdet = new System.Windows.Forms.ListBox();
            this.cbxAd = new System.Windows.Forms.ComboBox();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbxFiyat = new System.Windows.Forms.ListBox();
            this.btnSatis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
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
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbxAd
            // 
            this.lbxAd.BackColor = System.Drawing.Color.White;
            this.lbxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxAd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbxAd.FormattingEnabled = true;
            this.lbxAd.ItemHeight = 20;
            this.lbxAd.Location = new System.Drawing.Point(79, 77);
            this.lbxAd.Name = "lbxAd";
            this.lbxAd.Size = new System.Drawing.Size(177, 264);
            this.lbxAd.TabIndex = 51;
            // 
            // lbxAdet
            // 
            this.lbxAdet.BackColor = System.Drawing.Color.White;
            this.lbxAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxAdet.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbxAdet.FormattingEnabled = true;
            this.lbxAdet.ItemHeight = 20;
            this.lbxAdet.Location = new System.Drawing.Point(288, 77);
            this.lbxAdet.Name = "lbxAdet";
            this.lbxAdet.Size = new System.Drawing.Size(97, 264);
            this.lbxAdet.TabIndex = 52;
            // 
            // cbxAd
            // 
            this.cbxAd.BackColor = System.Drawing.Color.White;
            this.cbxAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbxAd.FormattingEnabled = true;
            this.cbxAd.Location = new System.Drawing.Point(79, 373);
            this.cbxAd.Name = "cbxAd";
            this.cbxAd.Size = new System.Drawing.Size(177, 24);
            this.cbxAd.TabIndex = 53;
            this.cbxAd.SelectedIndexChanged += new System.EventHandler(this.cbxAd_SelectedIndexChanged);
            // 
            // nudAdet
            // 
            this.nudAdet.BackColor = System.Drawing.Color.White;
            this.nudAdet.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.nudAdet.Location = new System.Drawing.Point(288, 373);
            this.nudAdet.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(97, 22);
            this.nudAdet.TabIndex = 54;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEkle.Location = new System.Drawing.Point(288, 412);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(97, 59);
            this.btnEkle.TabIndex = 55;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.White;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTemizle.Location = new System.Drawing.Point(79, 412);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(177, 59);
            this.btnTemizle.TabIndex = 56;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblToplam.Location = new System.Drawing.Point(505, 368);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(23, 25);
            this.lblToplam.TabIndex = 57;
            this.lblToplam.Text = "0";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl1.Location = new System.Drawing.Point(410, 368);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(89, 25);
            this.lbl1.TabIndex = 58;
            this.lbl1.Text = "Toplam :";
            // 
            // lbxFiyat
            // 
            this.lbxFiyat.BackColor = System.Drawing.Color.White;
            this.lbxFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxFiyat.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbxFiyat.FormattingEnabled = true;
            this.lbxFiyat.ItemHeight = 20;
            this.lbxFiyat.Location = new System.Drawing.Point(415, 77);
            this.lbxFiyat.Name = "lbxFiyat";
            this.lbxFiyat.Size = new System.Drawing.Size(126, 264);
            this.lbxFiyat.TabIndex = 59;
            // 
            // btnSatis
            // 
            this.btnSatis.BackColor = System.Drawing.Color.White;
            this.btnSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSatis.Location = new System.Drawing.Point(415, 412);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(126, 59);
            this.btnSatis.TabIndex = 60;
            this.btnSatis.Text = "Satış";
            this.btnSatis.UseVisualStyleBackColor = false;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // BufeSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1030, 603);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.lbxFiyat);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.cbxAd);
            this.Controls.Add(this.lbxAdet);
            this.Controls.Add(this.lbxAd);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BufeSatis";
            this.Text = "BufeSatis";
            this.Load += new System.EventHandler(this.BufeSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbxAd;
        private System.Windows.Forms.ListBox lbxAdet;
        private System.Windows.Forms.ComboBox cbxAd;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ListBox lbxFiyat;
        private System.Windows.Forms.Button btnSatis;
    }
}