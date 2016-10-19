namespace AracKiralamaTakipOtomasyonu
{
    partial class Form2
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
            this.nudHaftalik = new System.Windows.Forms.NumericUpDown();
            this.nudAylik = new System.Windows.Forms.NumericUpDown();
            this.nudGunluk = new System.Windows.Forms.NumericUpDown();
            this.dgwAraclar = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAracPlaka = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHaftalik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAylik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGunluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // nudHaftalik
            // 
            this.nudHaftalik.Location = new System.Drawing.Point(74, 156);
            this.nudHaftalik.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudHaftalik.Name = "nudHaftalik";
            this.nudHaftalik.Size = new System.Drawing.Size(131, 20);
            this.nudHaftalik.TabIndex = 4;
            // 
            // nudAylik
            // 
            this.nudAylik.Location = new System.Drawing.Point(74, 193);
            this.nudAylik.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAylik.Name = "nudAylik";
            this.nudAylik.Size = new System.Drawing.Size(131, 20);
            this.nudAylik.TabIndex = 5;
            // 
            // nudGunluk
            // 
            this.nudGunluk.Location = new System.Drawing.Point(74, 121);
            this.nudGunluk.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudGunluk.Name = "nudGunluk";
            this.nudGunluk.Size = new System.Drawing.Size(131, 20);
            this.nudGunluk.TabIndex = 3;
            // 
            // dgwAraclar
            // 
            this.dgwAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAraclar.Location = new System.Drawing.Point(226, 47);
            this.dgwAraclar.Name = "dgwAraclar";
            this.dgwAraclar.Size = new System.Drawing.Size(409, 201);
            this.dgwAraclar.TabIndex = 23;
            this.dgwAraclar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAraclar_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Aylık";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(14, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Haftalık";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(14, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Günlük";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Marka";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(74, 84);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(131, 20);
            this.txtPlaka.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(74, 47);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(131, 20);
            this.txtModel.TabIndex = 1;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(74, 12);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(131, 20);
            this.txtMarka.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSil.Location = new System.Drawing.Point(553, 256);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(82, 41);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.ForeColor = System.Drawing.Color.Red;
            this.btnDuzenle.Location = new System.Drawing.Point(465, 256);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(82, 41);
            this.btnDuzenle.TabIndex = 27;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Blue;
            this.btnEkle.Location = new System.Drawing.Point(377, 256);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(82, 41);
            this.btnEkle.TabIndex = 27;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(222, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Araç Plaka";
            // 
            // txtAracPlaka
            // 
            this.txtAracPlaka.Location = new System.Drawing.Point(307, 12);
            this.txtAracPlaka.Name = "txtAracPlaka";
            this.txtAracPlaka.Size = new System.Drawing.Size(131, 20);
            this.txtAracPlaka.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(444, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 20);
            this.button1.TabIndex = 30;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAracPlaka);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.nudHaftalik);
            this.Controls.Add(this.nudAylik);
            this.Controls.Add(this.nudGunluk);
            this.Controls.Add(this.dgwAraclar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Name = "Form2";
            this.Text = "Araclar";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHaftalik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAylik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGunluk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudHaftalik;
        private System.Windows.Forms.NumericUpDown nudAylik;
        private System.Windows.Forms.NumericUpDown nudGunluk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAracPlaka;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dgwAraclar;
    }
}