
namespace HastaneProjesi
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MsdTextTc = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.BtnGırısYap = new System.Windows.Forms.Button();
            this.LinkLblUyeOl = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // MsdTextTc
            // 
            this.MsdTextTc.Location = new System.Drawing.Point(177, 119);
            this.MsdTextTc.Mask = "00000000000";
            this.MsdTextTc.Name = "MsdTextTc";
            this.MsdTextTc.Size = new System.Drawing.Size(133, 31);
            this.MsdTextTc.TabIndex = 1;
            this.MsdTextTc.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(177, 173);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(133, 31);
            this.TxtSifre.TabIndex = 2;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // BtnGırısYap
            // 
            this.BtnGırısYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGırısYap.Location = new System.Drawing.Point(261, 225);
            this.BtnGırısYap.Name = "BtnGırısYap";
            this.BtnGırısYap.Size = new System.Drawing.Size(106, 39);
            this.BtnGırısYap.TabIndex = 5;
            this.BtnGırısYap.Text = "Giriş Yap";
            this.BtnGırısYap.UseVisualStyleBackColor = false;
            this.BtnGırısYap.Click += new System.EventHandler(this.BtnGırısYap_Click);
            // 
            // LinkLblUyeOl
            // 
            this.LinkLblUyeOl.AutoSize = true;
            this.LinkLblUyeOl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LinkLblUyeOl.Location = new System.Drawing.Point(330, 176);
            this.LinkLblUyeOl.Name = "LinkLblUyeOl";
            this.LinkLblUyeOl.Size = new System.Drawing.Size(62, 23);
            this.LinkLblUyeOl.TabIndex = 6;
            this.LinkLblUyeOl.TabStop = true;
            this.LinkLblUyeOl.Text = "Üye Ol";
            this.LinkLblUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblUyeOl_LinkClicked);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.BtnGırısYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(664, 300);
            this.Controls.Add(this.LinkLblUyeOl);
            this.Controls.Add(this.BtnGırısYap);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MsdTextTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MsdTextTc;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button BtnGırısYap;
        private System.Windows.Forms.LinkLabel LinkLblUyeOl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}