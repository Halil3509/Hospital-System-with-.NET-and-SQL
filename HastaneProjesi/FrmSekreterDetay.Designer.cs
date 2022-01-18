
namespace HastaneProjesi
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblSekreterAdSoyad = new System.Windows.Forms.Label();
            this.LblSekreterTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.RchDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnRandevuListe = new System.Windows.Forms.Button();
            this.BtnBransPaneli = new System.Windows.Forms.Button();
            this.BtnDoktorPaneli = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnRandevuKaydet = new System.Windows.Forms.Button();
            this.CmdRandevuDoktor = new System.Windows.Forms.ComboBox();
            this.CmdRandevuBrans = new System.Windows.Forms.ComboBox();
            this.MsdRandevuTc = new System.Windows.Forms.MaskedTextBox();
            this.MsdRandevuSaat = new System.Windows.Forms.MaskedTextBox();
            this.MsdRandevuTarih = new System.Windows.Forms.MaskedTextBox();
            this.TxtRandevuId = new System.Windows.Forms.TextBox();
            this.CheckDurum = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DgwBranslar = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DtwDoktorlar = new System.Windows.Forms.DataGridView();
            this.BtnDuyuru = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwBranslar)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtwDoktorlar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblSekreterAdSoyad);
            this.groupBox1.Controls.Add(this.LblSekreterTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // LblSekreterAdSoyad
            // 
            this.LblSekreterAdSoyad.AutoSize = true;
            this.LblSekreterAdSoyad.Location = new System.Drawing.Point(101, 98);
            this.LblSekreterAdSoyad.Name = "LblSekreterAdSoyad";
            this.LblSekreterAdSoyad.Size = new System.Drawing.Size(41, 23);
            this.LblSekreterAdSoyad.TabIndex = 3;
            this.LblSekreterAdSoyad.Text = "Null";
            // 
            // LblSekreterTC
            // 
            this.LblSekreterTC.AutoSize = true;
            this.LblSekreterTC.Location = new System.Drawing.Point(101, 48);
            this.LblSekreterTC.Name = "LblSekreterTC";
            this.LblSekreterTC.Size = new System.Drawing.Size(120, 23);
            this.LblSekreterTC.TabIndex = 2;
            this.LblSekreterTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnOlustur);
            this.groupBox2.Controls.Add(this.RchDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 305);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.Location = new System.Drawing.Point(6, 243);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(253, 38);
            this.BtnOlustur.TabIndex = 1;
            this.BtnOlustur.Text = "Oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = true;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // RchDuyuru
            // 
            this.RchDuyuru.Location = new System.Drawing.Point(6, 30);
            this.RchDuyuru.Name = "RchDuyuru";
            this.RchDuyuru.Size = new System.Drawing.Size(253, 207);
            this.RchDuyuru.TabIndex = 0;
            this.RchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnDuyuru);
            this.groupBox3.Controls.Add(this.BtnRandevuListe);
            this.groupBox3.Controls.Add(this.BtnBransPaneli);
            this.groupBox3.Controls.Add(this.BtnDoktorPaneli);
            this.groupBox3.Location = new System.Drawing.Point(12, 493);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı Erişim";
            // 
            // BtnRandevuListe
            // 
            this.BtnRandevuListe.Location = new System.Drawing.Point(309, 39);
            this.BtnRandevuListe.Name = "BtnRandevuListe";
            this.BtnRandevuListe.Size = new System.Drawing.Size(119, 38);
            this.BtnRandevuListe.TabIndex = 2;
            this.BtnRandevuListe.Text = "Randevu Liste";
            this.BtnRandevuListe.UseVisualStyleBackColor = true;
            this.BtnRandevuListe.Click += new System.EventHandler(this.BtnRandevuListe_Click);
            // 
            // BtnBransPaneli
            // 
            this.BtnBransPaneli.Location = new System.Drawing.Point(166, 39);
            this.BtnBransPaneli.Name = "BtnBransPaneli";
            this.BtnBransPaneli.Size = new System.Drawing.Size(119, 38);
            this.BtnBransPaneli.TabIndex = 1;
            this.BtnBransPaneli.Text = "Branş Paneli";
            this.BtnBransPaneli.UseVisualStyleBackColor = true;
            this.BtnBransPaneli.Click += new System.EventHandler(this.BtnBransPaneli_Click);
            // 
            // BtnDoktorPaneli
            // 
            this.BtnDoktorPaneli.Location = new System.Drawing.Point(21, 39);
            this.BtnDoktorPaneli.Name = "BtnDoktorPaneli";
            this.BtnDoktorPaneli.Size = new System.Drawing.Size(119, 38);
            this.BtnDoktorPaneli.TabIndex = 0;
            this.BtnDoktorPaneli.Text = "Doktor Paneli";
            this.BtnDoktorPaneli.UseVisualStyleBackColor = true;
            this.BtnDoktorPaneli.Click += new System.EventHandler(this.BtnDoktorPaneli_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnRandevuKaydet);
            this.groupBox4.Controls.Add(this.CmdRandevuDoktor);
            this.groupBox4.Controls.Add(this.CmdRandevuBrans);
            this.groupBox4.Controls.Add(this.MsdRandevuTc);
            this.groupBox4.Controls.Add(this.MsdRandevuSaat);
            this.groupBox4.Controls.Add(this.MsdRandevuTarih);
            this.groupBox4.Controls.Add(this.TxtRandevuId);
            this.groupBox4.Controls.Add(this.CheckDurum);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(299, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(291, 475);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Randevu Paneli";
            // 
            // BtnRandevuKaydet
            // 
            this.BtnRandevuKaydet.Location = new System.Drawing.Point(89, 388);
            this.BtnRandevuKaydet.Name = "BtnRandevuKaydet";
            this.BtnRandevuKaydet.Size = new System.Drawing.Size(138, 34);
            this.BtnRandevuKaydet.TabIndex = 7;
            this.BtnRandevuKaydet.Text = "Kaydet";
            this.BtnRandevuKaydet.UseVisualStyleBackColor = true;
            this.BtnRandevuKaydet.Click += new System.EventHandler(this.BtnRandevuKaydet_Click);
            // 
            // CmdRandevuDoktor
            // 
            this.CmdRandevuDoktor.FormattingEnabled = true;
            this.CmdRandevuDoktor.Location = new System.Drawing.Point(89, 231);
            this.CmdRandevuDoktor.Name = "CmdRandevuDoktor";
            this.CmdRandevuDoktor.Size = new System.Drawing.Size(163, 31);
            this.CmdRandevuDoktor.TabIndex = 5;
            // 
            // CmdRandevuBrans
            // 
            this.CmdRandevuBrans.FormattingEnabled = true;
            this.CmdRandevuBrans.Location = new System.Drawing.Point(89, 183);
            this.CmdRandevuBrans.Name = "CmdRandevuBrans";
            this.CmdRandevuBrans.Size = new System.Drawing.Size(163, 31);
            this.CmdRandevuBrans.TabIndex = 4;
            this.CmdRandevuBrans.SelectedIndexChanged += new System.EventHandler(this.CmdRandevuBrans_SelectedIndexChanged);
            // 
            // MsdRandevuTc
            // 
            this.MsdRandevuTc.Location = new System.Drawing.Point(89, 279);
            this.MsdRandevuTc.Mask = "00000000000";
            this.MsdRandevuTc.Name = "MsdRandevuTc";
            this.MsdRandevuTc.Size = new System.Drawing.Size(163, 31);
            this.MsdRandevuTc.TabIndex = 6;
            // 
            // MsdRandevuSaat
            // 
            this.MsdRandevuSaat.Location = new System.Drawing.Point(89, 139);
            this.MsdRandevuSaat.Mask = "00:00";
            this.MsdRandevuSaat.Name = "MsdRandevuSaat";
            this.MsdRandevuSaat.Size = new System.Drawing.Size(163, 31);
            this.MsdRandevuSaat.TabIndex = 3;
            this.MsdRandevuSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MsdRandevuTarih
            // 
            this.MsdRandevuTarih.Location = new System.Drawing.Point(89, 93);
            this.MsdRandevuTarih.Mask = "00/00/0000";
            this.MsdRandevuTarih.Name = "MsdRandevuTarih";
            this.MsdRandevuTarih.Size = new System.Drawing.Size(163, 31);
            this.MsdRandevuTarih.TabIndex = 2;
            this.MsdRandevuTarih.ValidatingType = typeof(System.DateTime);
            // 
            // TxtRandevuId
            // 
            this.TxtRandevuId.Enabled = false;
            this.TxtRandevuId.Location = new System.Drawing.Point(89, 48);
            this.TxtRandevuId.Name = "TxtRandevuId";
            this.TxtRandevuId.Size = new System.Drawing.Size(163, 31);
            this.TxtRandevuId.TabIndex = 1;
            // 
            // CheckDurum
            // 
            this.CheckDurum.AutoSize = true;
            this.CheckDurum.Location = new System.Drawing.Point(89, 332);
            this.CheckDurum.Name = "CheckDurum";
            this.CheckDurum.Size = new System.Drawing.Size(84, 27);
            this.CheckDurum.TabIndex = 7;
            this.CheckDurum.Text = "Durum";
            this.CheckDurum.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 23);
            this.label12.TabIndex = 6;
            this.label12.Text = "Tarih:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "Saat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Branş:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Doktor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "TC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DgwBranslar);
            this.groupBox5.Location = new System.Drawing.Point(607, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(567, 270);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Branşlar";
            // 
            // DgwBranslar
            // 
            this.DgwBranslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwBranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwBranslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgwBranslar.Location = new System.Drawing.Point(3, 27);
            this.DgwBranslar.Name = "DgwBranslar";
            this.DgwBranslar.Size = new System.Drawing.Size(561, 240);
            this.DgwBranslar.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DtwDoktorlar);
            this.groupBox6.Location = new System.Drawing.Point(610, 291);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(567, 298);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Doktorlar";
            // 
            // DtwDoktorlar
            // 
            this.DtwDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtwDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtwDoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtwDoktorlar.Location = new System.Drawing.Point(3, 27);
            this.DtwDoktorlar.Name = "DtwDoktorlar";
            this.DtwDoktorlar.Size = new System.Drawing.Size(561, 268);
            this.DtwDoktorlar.TabIndex = 0;
            // 
            // BtnDuyuru
            // 
            this.BtnDuyuru.Location = new System.Drawing.Point(443, 39);
            this.BtnDuyuru.Name = "BtnDuyuru";
            this.BtnDuyuru.Size = new System.Drawing.Size(119, 38);
            this.BtnDuyuru.TabIndex = 3;
            this.BtnDuyuru.Text = "Duyurular";
            this.BtnDuyuru.UseVisualStyleBackColor = true;
            this.BtnDuyuru.Click += new System.EventHandler(this.BtnDuyuru_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1186, 614);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSekreterDetay";
            this.Text = "Ana Panel";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgwBranslar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtwDoktorlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblSekreterAdSoyad;
        private System.Windows.Forms.Label LblSekreterTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.RichTextBox RchDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnRandevuListe;
        private System.Windows.Forms.Button BtnBransPaneli;
        private System.Windows.Forms.Button BtnDoktorPaneli;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnRandevuKaydet;
        private System.Windows.Forms.ComboBox CmdRandevuDoktor;
        private System.Windows.Forms.ComboBox CmdRandevuBrans;
        private System.Windows.Forms.MaskedTextBox MsdRandevuTc;
        private System.Windows.Forms.MaskedTextBox MsdRandevuSaat;
        private System.Windows.Forms.MaskedTextBox MsdRandevuTarih;
        private System.Windows.Forms.TextBox TxtRandevuId;
        private System.Windows.Forms.CheckBox CheckDurum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DgwBranslar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView DtwDoktorlar;
        private System.Windows.Forms.Button BtnDuyuru;
    }
}