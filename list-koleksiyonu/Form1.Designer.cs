namespace list_koleksiyonu
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
            label1 = new Label();
            txtNumara = new TextBox();
            btnEkleSayi = new Button();
            lbSayi = new ListBox();
            lbMetin = new ListBox();
            btnEkleMetin = new Button();
            txtAdSoyad = new TextBox();
            label2 = new Label();
            lbNesne = new ListBox();
            btnEkleNesne = new Button();
            txtNumaraN = new TextBox();
            label3 = new Label();
            txtAdSoyadN = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "NUMARA";
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(85, 38);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(125, 27);
            txtNumara.TabIndex = 1;
            // 
            // btnEkleSayi
            // 
            btnEkleSayi.BackColor = Color.DarkTurquoise;
            btnEkleSayi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkleSayi.Location = new Point(117, 83);
            btnEkleSayi.Name = "btnEkleSayi";
            btnEkleSayi.Size = new Size(93, 29);
            btnEkleSayi.TabIndex = 2;
            btnEkleSayi.Text = "Sayı Ekle";
            btnEkleSayi.UseVisualStyleBackColor = false;
            btnEkleSayi.Click += btnEkleSayi_Click;
            // 
            // lbSayi
            // 
            lbSayi.FormattingEnabled = true;
            lbSayi.ItemHeight = 20;
            lbSayi.Location = new Point(45, 150);
            lbSayi.Name = "lbSayi";
            lbSayi.Size = new Size(167, 484);
            lbSayi.TabIndex = 3;
            // 
            // lbMetin
            // 
            lbMetin.FormattingEnabled = true;
            lbMetin.ItemHeight = 20;
            lbMetin.Location = new Point(309, 152);
            lbMetin.Name = "lbMetin";
            lbMetin.Size = new Size(167, 484);
            lbMetin.TabIndex = 7;
            // 
            // btnEkleMetin
            // 
            btnEkleMetin.BackColor = Color.DarkTurquoise;
            btnEkleMetin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkleMetin.Location = new Point(361, 84);
            btnEkleMetin.Name = "btnEkleMetin";
            btnEkleMetin.Size = new Size(115, 29);
            btnEkleMetin.TabIndex = 6;
            btnEkleMetin.Text = "Metin Ekle";
            btnEkleMetin.UseVisualStyleBackColor = false;
            btnEkleMetin.Click += btnEkleMetin_Click;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(349, 40);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 43);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 4;
            label2.Text = "AD SOYAD";
            // 
            // lbNesne
            // 
            lbNesne.FormattingEnabled = true;
            lbNesne.ItemHeight = 20;
            lbNesne.Location = new Point(573, 153);
            lbNesne.Name = "lbNesne";
            lbNesne.Size = new Size(167, 484);
            lbNesne.TabIndex = 11;
            // 
            // btnEkleNesne
            // 
            btnEkleNesne.BackColor = Color.DarkTurquoise;
            btnEkleNesne.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkleNesne.Location = new Point(629, 118);
            btnEkleNesne.Name = "btnEkleNesne";
            btnEkleNesne.Size = new Size(111, 29);
            btnEkleNesne.TabIndex = 10;
            btnEkleNesne.Text = "Nesne Ekle";
            btnEkleNesne.UseVisualStyleBackColor = false;
            btnEkleNesne.Click += btnEkleNesne_Click;
            // 
            // txtNumaraN
            // 
            txtNumaraN.Location = new Point(615, 41);
            txtNumaraN.Name = "txtNumaraN";
            txtNumaraN.Size = new Size(125, 27);
            txtNumaraN.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 44);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 8;
            label3.Text = "NUMARA";
            // 
            // txtAdSoyadN
            // 
            txtAdSoyadN.Location = new Point(615, 82);
            txtAdSoyadN.Name = "txtAdSoyadN";
            txtAdSoyadN.Size = new Size(125, 27);
            txtAdSoyadN.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(535, 84);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 12;
            label4.Text = "AD SOYAD";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(809, 684);
            Controls.Add(txtAdSoyadN);
            Controls.Add(label4);
            Controls.Add(lbNesne);
            Controls.Add(btnEkleNesne);
            Controls.Add(txtNumaraN);
            Controls.Add(label3);
            Controls.Add(lbMetin);
            Controls.Add(btnEkleMetin);
            Controls.Add(txtAdSoyad);
            Controls.Add(label2);
            Controls.Add(lbSayi);
            Controls.Add(btnEkleSayi);
            Controls.Add(txtNumara);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumara;
        private Button btnEkleSayi;
        private ListBox lbSayi;
        private ListBox lbMetin;
        private Button btnEkleMetin;
        private TextBox txtAdSoyad;
        private Label label2;
        private ListBox lbNesne;
        private Button btnEkleNesne;
        private TextBox txtNumaraN;
        private Label label3;
        private TextBox txtAdSoyadN;
        private Label label4;
    }
}