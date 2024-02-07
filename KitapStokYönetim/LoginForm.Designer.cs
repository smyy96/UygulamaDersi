namespace KitapStokYönetim
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txtKullaniciAdı = new TextBox();
            txtSifre = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(166, 167);
            button1.Name = "button1";
            button1.Size = new Size(196, 29);
            button1.TabIndex = 3;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtKullaniciAdı
            // 
            txtKullaniciAdı.Location = new Point(200, 44);
            txtKullaniciAdı.Name = "txtKullaniciAdı";
            txtKullaniciAdı.PlaceholderText = "User Name";
            txtKullaniciAdı.Size = new Size(125, 27);
            txtKullaniciAdı.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(200, 104);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.PlaceholderText = "Password";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(2, 327);
            button2.Name = "button2";
            button2.Size = new Size(195, 29);
            button2.TabIndex = 4;
            button2.Text = "Hesap Oluştur";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 368);
            Controls.Add(button2);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdı);
            Controls.Add(button1);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtKullaniciAdı;
        private TextBox txtSifre;
        private Button button2;
    }
}
