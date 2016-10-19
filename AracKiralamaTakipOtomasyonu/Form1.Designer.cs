namespace AracKiralamaTakipOtomasyonu
{
    partial class Form1
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
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.musMusteri = new System.Windows.Forms.ToolStripMenuItem();
            this.musArac = new System.Windows.Forms.ToolStripMenuItem();
            this.musCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbArabalar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.btnKirala = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGunSayisi = new System.Windows.Forms.Label();
            this.btnMusteriAraclariSil = new System.Windows.Forms.Button();
            this.rdbGunluk = new System.Windows.Forms.RadioButton();
            this.rdbHaftalik = new System.Windows.Forms.RadioButton();
            this.rdbAylik = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dgwMusteriAraclari = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriAraclari)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(12, 37);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(243, 21);
            this.cmbMusteriler.TabIndex = 1;
            this.cmbMusteriler.SelectedIndexChanged += new System.EventHandler(this.cmbMusteriler_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musMusteri,
            this.musArac,
            this.musCikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // musMusteri
            // 
            this.musMusteri.Name = "musMusteri";
            this.musMusteri.Size = new System.Drawing.Size(59, 20);
            this.musMusteri.Text = "Musteri";
            this.musMusteri.Click += new System.EventHandler(this.musMusteri_Click);
            // 
            // musArac
            // 
            this.musArac.Name = "musArac";
            this.musArac.Size = new System.Drawing.Size(46, 20);
            this.musArac.Text = "Araç ";
            this.musArac.Click += new System.EventHandler(this.musArac_Click);
            // 
            // musCikis
            // 
            this.musCikis.Name = "musCikis";
            this.musCikis.Size = new System.Drawing.Size(44, 20);
            this.musCikis.Text = "Çıkış";
            this.musCikis.Click += new System.EventHandler(this.musCikis_Click);
            // 
            // cmbArabalar
            // 
            this.cmbArabalar.FormattingEnabled = true;
            this.cmbArabalar.Location = new System.Drawing.Point(388, 38);
            this.cmbArabalar.Name = "cmbArabalar";
            this.cmbArabalar.Size = new System.Drawing.Size(168, 21);
            this.cmbArabalar.TabIndex = 3;
            this.cmbArabalar.SelectedIndexChanged += new System.EventHandler(this.cmbArabalar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(280, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Arabalar";
            // 
            // dtpBaslamaTarihi
            // 
            this.dtpBaslamaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslamaTarihi.Location = new System.Drawing.Point(388, 76);
            this.dtpBaslamaTarihi.Name = "dtpBaslamaTarihi";
            this.dtpBaslamaTarihi.Size = new System.Drawing.Size(168, 20);
            this.dtpBaslamaTarihi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(280, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Başlama Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(280, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitisTarihi.Location = new System.Drawing.Point(388, 114);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(168, 20);
            this.dtpBitisTarihi.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(280, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Toplam Fiyat";
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblToplamFiyat.Location = new System.Drawing.Point(399, 212);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(16, 16);
            this.lblToplamFiyat.TabIndex = 11;
            this.lblToplamFiyat.Text = "0";
            // 
            // btnKirala
            // 
            this.btnKirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKirala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKirala.Location = new System.Drawing.Point(475, 241);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(81, 38);
            this.btnKirala.TabIndex = 13;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(280, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gün Sayisı";
            // 
            // lblGunSayisi
            // 
            this.lblGunSayisi.AutoSize = true;
            this.lblGunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblGunSayisi.Location = new System.Drawing.Point(399, 186);
            this.lblGunSayisi.Name = "lblGunSayisi";
            this.lblGunSayisi.Size = new System.Drawing.Size(16, 16);
            this.lblGunSayisi.TabIndex = 14;
            this.lblGunSayisi.Text = "0";
            // 
            // btnMusteriAraclariSil
            // 
            this.btnMusteriAraclariSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriAraclariSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMusteriAraclariSil.Location = new System.Drawing.Point(185, 285);
            this.btnMusteriAraclariSil.Name = "btnMusteriAraclariSil";
            this.btnMusteriAraclariSil.Size = new System.Drawing.Size(70, 37);
            this.btnMusteriAraclariSil.TabIndex = 16;
            this.btnMusteriAraclariSil.Text = "Sil";
            this.btnMusteriAraclariSil.UseVisualStyleBackColor = true;
            this.btnMusteriAraclariSil.Click += new System.EventHandler(this.btnMusteriAraclariSil_Click);
            // 
            // rdbGunluk
            // 
            this.rdbGunluk.AutoSize = true;
            this.rdbGunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbGunluk.Location = new System.Drawing.Point(358, 152);
            this.rdbGunluk.Name = "rdbGunluk";
            this.rdbGunluk.Size = new System.Drawing.Size(65, 17);
            this.rdbGunluk.TabIndex = 17;
            this.rdbGunluk.TabStop = true;
            this.rdbGunluk.Text = "Günlük";
            this.rdbGunluk.UseVisualStyleBackColor = true;
            // 
            // rdbHaftalik
            // 
            this.rdbHaftalik.AutoSize = true;
            this.rdbHaftalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbHaftalik.Location = new System.Drawing.Point(429, 152);
            this.rdbHaftalik.Name = "rdbHaftalik";
            this.rdbHaftalik.Size = new System.Drawing.Size(69, 17);
            this.rdbHaftalik.TabIndex = 18;
            this.rdbHaftalik.TabStop = true;
            this.rdbHaftalik.Text = "Haftalık";
            this.rdbHaftalik.UseVisualStyleBackColor = true;
            // 
            // rdbAylik
            // 
            this.rdbAylik.AutoSize = true;
            this.rdbAylik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbAylik.Location = new System.Drawing.Point(504, 152);
            this.rdbAylik.Name = "rdbAylik";
            this.rdbAylik.Size = new System.Drawing.Size(52, 17);
            this.rdbAylik.TabIndex = 19;
            this.rdbAylik.TabStop = true;
            this.rdbAylik.Text = "Aylık";
            this.rdbAylik.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(280, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kiralama";
            // 
            // dgwMusteriAraclari
            // 
            this.dgwMusteriAraclari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteriAraclari.Location = new System.Drawing.Point(12, 67);
            this.dgwMusteriAraclari.Name = "dgwMusteriAraclari";
            this.dgwMusteriAraclari.Size = new System.Drawing.Size(243, 212);
            this.dgwMusteriAraclari.TabIndex = 21;
            this.dgwMusteriAraclari.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteriAraclari_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 333);
            this.Controls.Add(this.dgwMusteriAraclari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdbAylik);
            this.Controls.Add(this.rdbHaftalik);
            this.Controls.Add(this.rdbGunluk);
            this.Controls.Add(this.btnMusteriAraclariSil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGunSayisi);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpBitisTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBaslamaTarihi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbArabalar);
            this.Controls.Add(this.cmbMusteriler);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(10, 0);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Araç Kiralama Sitemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriAraclari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbMusteriler;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem musMusteri;
        private System.Windows.Forms.ToolStripMenuItem musArac;
        private System.Windows.Forms.ToolStripMenuItem musCikis;
        private System.Windows.Forms.ComboBox cmbArabalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBaslamaTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGunSayisi;
        private System.Windows.Forms.Button btnMusteriAraclariSil;
        private System.Windows.Forms.RadioButton rdbGunluk;
        private System.Windows.Forms.RadioButton rdbHaftalik;
        private System.Windows.Forms.RadioButton rdbAylik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgwMusteriAraclari;
    }
}

