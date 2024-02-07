namespace KitapStokYönetim
{
    partial class HesapAcForm
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
            txtAd = new TextBox();
            txtKullaniciAd = new TextBox();
            txtSifre = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(106, 34);
            txtAd.Name = "txtAd";
            txtAd.PlaceholderText = "Ad";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 0;
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.Location = new Point(106, 87);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.PlaceholderText = "Kullanıcı Adı";
            txtKullaniciAd.Size = new Size(125, 27);
            txtKullaniciAd.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(106, 138);
            txtSifre.Name = "txtSifre";
            txtSifre.PlaceholderText = "Şifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(106, 208);
            button1.Name = "button1";
            button1.Size = new Size(141, 29);
            button1.TabIndex = 1;
            button1.Text = "Hesap Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HesapAcForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 281);
            Controls.Add(button1);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAd);
            Controls.Add(txtAd);
            Name = "HesapAcForm";
            Text = "HesapAcFrm";
            FormClosing += HesapAcForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtKullaniciAd;
        private TextBox txtSifre;
        private Button button1;
    }
}