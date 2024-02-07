namespace KitapStokYönetim
{
    partial class KitapForm
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtSatisAdet = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(203, 308);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtSatisAdet);
            groupBox1.Location = new Point(256, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 170);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Satış alanı";
            // 
            // button1
            // 
            button1.Location = new Point(130, 92);
            button1.Name = "button1";
            button1.Size = new Size(81, 58);
            button1.TabIndex = 1;
            button1.Text = "Satış";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSatisAdet
            // 
            txtSatisAdet.Location = new Point(83, 59);
            txtSatisAdet.Name = "txtSatisAdet";
            txtSatisAdet.Size = new Size(175, 27);
            txtSatisAdet.TabIndex = 0;
            // 
            // KitapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "KitapForm";
            Text = "KitapForm";
            Load += KitapForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtSatisAdet;
        private Button button1;
    }
}