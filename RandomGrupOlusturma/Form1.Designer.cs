namespace RandomGrupOlusturma
{
    partial class Form1
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
            lstBxKisiler = new ListBox();
            txtGrupSayisi = new TextBox();
            btnGrupOlustur = new Button();
            lstbxGrup = new ListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            btnListeyiSil = new Button();
            txtYeniKisi = new TextBox();
            btnYeniKisi = new Button();
            label3 = new Label();
            btnEkleTxt = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lstBxKisiler
            // 
            lstBxKisiler.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstBxKisiler.FormattingEnabled = true;
            lstBxKisiler.ItemHeight = 20;
            lstBxKisiler.Location = new Point(19, 26);
            lstBxKisiler.Name = "lstBxKisiler";
            lstBxKisiler.Size = new Size(177, 324);
            lstBxKisiler.TabIndex = 0;
            // 
            // txtGrupSayisi
            // 
            txtGrupSayisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtGrupSayisi.Location = new Point(261, 110);
            txtGrupSayisi.Multiline = true;
            txtGrupSayisi.Name = "txtGrupSayisi";
            txtGrupSayisi.Size = new Size(72, 38);
            txtGrupSayisi.TabIndex = 1;
            txtGrupSayisi.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGrupOlustur
            // 
            btnGrupOlustur.BackColor = Color.LightSkyBlue;
            btnGrupOlustur.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGrupOlustur.ForeColor = Color.Navy;
            btnGrupOlustur.Location = new Point(261, 154);
            btnGrupOlustur.Name = "btnGrupOlustur";
            btnGrupOlustur.Size = new Size(72, 32);
            btnGrupOlustur.TabIndex = 2;
            btnGrupOlustur.Text = "GRUPLA";
            btnGrupOlustur.UseVisualStyleBackColor = false;
            btnGrupOlustur.Click += btnGrupOlustur_Click;
            // 
            // lstbxGrup
            // 
            lstbxGrup.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstbxGrup.FormattingEnabled = true;
            lstbxGrup.ItemHeight = 20;
            lstbxGrup.Location = new Point(24, 28);
            lstbxGrup.Name = "lstbxGrup";
            lstbxGrup.Size = new Size(187, 424);
            lstbxGrup.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LavenderBlush;
            groupBox1.Controls.Add(lstBxKisiler);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.DeepPink;
            groupBox1.Location = new Point(12, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 365);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "    Sınıf   ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 255, 192);
            groupBox2.Controls.Add(lstbxGrup);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.LimeGreen;
            groupBox2.Location = new Point(363, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(230, 476);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "  Gruplar  ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 37);
            label1.TabIndex = 6;
            label1.Text = "ANK-16 GRUPLAMA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(218, 56);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 7;
            label2.Text = "Her Grupta Kaç Kişi Olacak?";
            // 
            // btnListeyiSil
            // 
            btnListeyiSil.BackColor = Color.LightCoral;
            btnListeyiSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnListeyiSil.ForeColor = Color.Maroon;
            btnListeyiSil.Location = new Point(34, 464);
            btnListeyiSil.Name = "btnListeyiSil";
            btnListeyiSil.Size = new Size(177, 26);
            btnListeyiSil.TabIndex = 8;
            btnListeyiSil.Text = "Listeyi Sil";
            btnListeyiSil.UseVisualStyleBackColor = false;
            btnListeyiSil.Click += btnListeyiSil_Click;
            // 
            // txtYeniKisi
            // 
            txtYeniKisi.Location = new Point(34, 511);
            txtYeniKisi.Name = "txtYeniKisi";
            txtYeniKisi.PlaceholderText = "Yeni Kişi Ekle";
            txtYeniKisi.Size = new Size(174, 23);
            txtYeniKisi.TabIndex = 9;
            // 
            // btnYeniKisi
            // 
            btnYeniKisi.BackColor = Color.FromArgb(255, 192, 128);
            btnYeniKisi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeniKisi.ForeColor = Color.OrangeRed;
            btnYeniKisi.Location = new Point(31, 540);
            btnYeniKisi.Name = "btnYeniKisi";
            btnYeniKisi.Size = new Size(177, 26);
            btnYeniKisi.TabIndex = 10;
            btnYeniKisi.Text = "Kişi Ekle";
            btnYeniKisi.UseVisualStyleBackColor = false;
            btnYeniKisi.Click += btnYeniKisi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Script MT Bold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(583, 565);
            label3.Name = "label3";
            label3.Size = new Size(25, 14);
            label3.TabIndex = 11;
            label3.Text = "S.C.";
            // 
            // btnEkleTxt
            // 
            btnEkleTxt.AutoSize = true;
            btnEkleTxt.BackColor = Color.FromArgb(255, 255, 128);
            btnEkleTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkleTxt.ForeColor = Color.Olive;
            btnEkleTxt.Location = new Point(261, 354);
            btnEkleTxt.Name = "btnEkleTxt";
            btnEkleTxt.Size = new Size(72, 32);
            btnEkleTxt.TabIndex = 13;
            btnEkleTxt.Text = ".TXT";
            btnEkleTxt.UseVisualStyleBackColor = false;
            btnEkleTxt.Click += btnEkleTxt_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(249, 327);
            label4.Name = "label4";
            label4.Size = new Size(96, 24);
            label4.TabIndex = 14;
            label4.Text = "Grupları kaydet.\r\n\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(613, 584);
            Controls.Add(label4);
            Controls.Add(btnEkleTxt);
            Controls.Add(label3);
            Controls.Add(btnYeniKisi);
            Controls.Add(txtYeniKisi);
            Controls.Add(btnListeyiSil);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnGrupOlustur);
            Controls.Add(txtGrupSayisi);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ank-16";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstBxKisiler;
        private TextBox txtGrupSayisi;
        private Button btnGrupOlustur;
        private ListBox lstbxGrup;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Button btnListeyiSil;
        private TextBox txtYeniKisi;
        private Button btnYeniKisi;
        private Label label3;
        private Button btnEkleTxt;
        private Label label4;
    }
}