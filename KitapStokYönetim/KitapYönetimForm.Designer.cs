namespace KitapStokYönetim
{
    partial class KitapYönetimForm
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtAdet = new TextBox();
            txtAd = new TextBox();
            txtFiyat = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtAdet);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(txtFiyat);
            groupBox1.Location = new Point(35, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Ekle";
            // 
            // button1
            // 
            button1.Location = new Point(51, 186);
            button1.Name = "button1";
            button1.Size = new Size(100, 52);
            button1.TabIndex = 1;
            button1.Text = "ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(51, 134);
            txtAdet.Name = "txtAdet";
            txtAdet.PlaceholderText = "adet";
            txtAdet.Size = new Size(125, 27);
            txtAdet.TabIndex = 0;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(51, 89);
            txtAd.Name = "txtAd";
            txtAd.PlaceholderText = "ad";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 0;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(51, 42);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.PlaceholderText = "fiyat";
            txtFiyat.Size = new Size(125, 27);
            txtFiyat.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(399, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(355, 304);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 364);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // KitapYönetimForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name = "KitapYönetimForm";
            Text = "KitapYönetimForm";
            FormClosing += KitapYönetimForm_FormClosing;
            Load += KitapYönetimForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtAdet;
        private TextBox txtAd;
        private TextBox txtFiyat;
        private ListBox listBox1;
        private Label label1;
    }
}