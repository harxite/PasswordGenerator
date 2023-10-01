namespace Assignment_PasswordGenerator
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
            gbParametreler = new GroupBox();
            btnUret = new Button();
            numSifreUzunlugu = new NumericUpDown();
            numSifreSayisi = new NumericUpDown();
            lblSifreUzunlugu = new Label();
            lblSifreSayisi = new Label();
            chkRakam = new CheckBox();
            chkOzelKarakter = new CheckBox();
            chkBuyukKarakter = new CheckBox();
            chkKucukKarakter = new CheckBox();
            lbSifreler = new ListBox();
            gbParametreler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSifreUzunlugu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSifreSayisi).BeginInit();
            SuspendLayout();
            // 
            // gbParametreler
            // 
            gbParametreler.Controls.Add(btnUret);
            gbParametreler.Controls.Add(numSifreUzunlugu);
            gbParametreler.Controls.Add(numSifreSayisi);
            gbParametreler.Controls.Add(lblSifreUzunlugu);
            gbParametreler.Controls.Add(lblSifreSayisi);
            gbParametreler.Controls.Add(chkRakam);
            gbParametreler.Controls.Add(chkOzelKarakter);
            gbParametreler.Controls.Add(chkBuyukKarakter);
            gbParametreler.Controls.Add(chkKucukKarakter);
            gbParametreler.Location = new Point(12, 11);
            gbParametreler.Name = "gbParametreler";
            gbParametreler.Size = new Size(414, 493);
            gbParametreler.TabIndex = 0;
            gbParametreler.TabStop = false;
            gbParametreler.Text = "PARAMETRELER";
            // 
            // btnUret
            // 
            btnUret.Location = new Point(24, 366);
            btnUret.Name = "btnUret";
            btnUret.Size = new Size(361, 83);
            btnUret.TabIndex = 8;
            btnUret.Text = "URET";
            btnUret.UseVisualStyleBackColor = true;
            btnUret.Click += btnUret_Click;
            // 
            // numSifreUzunlugu
            // 
            numSifreUzunlugu.Location = new Point(169, 275);
            numSifreUzunlugu.Name = "numSifreUzunlugu";
            numSifreUzunlugu.Size = new Size(216, 27);
            numSifreUzunlugu.TabIndex = 7;
            // 
            // numSifreSayisi
            // 
            numSifreSayisi.Location = new Point(169, 234);
            numSifreSayisi.Name = "numSifreSayisi";
            numSifreSayisi.Size = new Size(216, 27);
            numSifreSayisi.TabIndex = 6;
            // 
            // lblSifreUzunlugu
            // 
            lblSifreUzunlugu.AutoSize = true;
            lblSifreUzunlugu.Location = new Point(24, 282);
            lblSifreUzunlugu.Name = "lblSifreUzunlugu";
            lblSifreUzunlugu.Size = new Size(105, 20);
            lblSifreUzunlugu.TabIndex = 5;
            lblSifreUzunlugu.Text = "Sifre Uzunlugu";
            // 
            // lblSifreSayisi
            // 
            lblSifreSayisi.AutoSize = true;
            lblSifreSayisi.Location = new Point(24, 241);
            lblSifreSayisi.Name = "lblSifreSayisi";
            lblSifreSayisi.Size = new Size(80, 20);
            lblSifreSayisi.TabIndex = 4;
            lblSifreSayisi.Text = "Sifre Sayisi";
            // 
            // chkRakam
            // 
            chkRakam.AutoSize = true;
            chkRakam.Location = new Point(284, 127);
            chkRakam.Name = "chkRakam";
            chkRakam.Size = new Size(76, 24);
            chkRakam.TabIndex = 3;
            chkRakam.Text = "Rakam";
            chkRakam.UseVisualStyleBackColor = true;
            // 
            // chkOzelKarakter
            // 
            chkOzelKarakter.AutoSize = true;
            chkOzelKarakter.Location = new Point(284, 78);
            chkOzelKarakter.Name = "chkOzelKarakter";
            chkOzelKarakter.Size = new Size(120, 24);
            chkOzelKarakter.TabIndex = 2;
            chkOzelKarakter.Text = "Ozel Karakter";
            chkOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // chkBuyukKarakter
            // 
            chkBuyukKarakter.AutoSize = true;
            chkBuyukKarakter.Location = new Point(24, 127);
            chkBuyukKarakter.Name = "chkBuyukKarakter";
            chkBuyukKarakter.Size = new Size(129, 24);
            chkBuyukKarakter.TabIndex = 1;
            chkBuyukKarakter.Text = "Buyuk Karakter";
            chkBuyukKarakter.UseVisualStyleBackColor = true;
            // 
            // chkKucukKarakter
            // 
            chkKucukKarakter.AutoSize = true;
            chkKucukKarakter.Location = new Point(24, 78);
            chkKucukKarakter.Name = "chkKucukKarakter";
            chkKucukKarakter.Size = new Size(129, 24);
            chkKucukKarakter.TabIndex = 0;
            chkKucukKarakter.Text = "Kucuk Karakter";
            chkKucukKarakter.UseVisualStyleBackColor = true;
            // 
            // lbSifreler
            // 
            lbSifreler.BackColor = SystemColors.Control;
            lbSifreler.FormattingEnabled = true;
            lbSifreler.ItemHeight = 20;
            lbSifreler.Location = new Point(446, 23);
            lbSifreler.Name = "lbSifreler";
            lbSifreler.Size = new Size(367, 464);
            lbSifreler.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 516);
            Controls.Add(lbSifreler);
            Controls.Add(gbParametreler);
            Name = "Form1";
            Text = "Form1";
            gbParametreler.ResumeLayout(false);
            gbParametreler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSifreUzunlugu).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSifreSayisi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbParametreler;
        private Label lblSifreUzunlugu;
        private Label lblSifreSayisi;
        private CheckBox chkRakam;
        private CheckBox chkOzelKarakter;
        private CheckBox chkBuyukKarakter;
        private CheckBox chkKucukKarakter;
        private ListBox lbSifreler;
        private Button btnUret;
        private NumericUpDown numSifreUzunlugu;
        private NumericUpDown numSifreSayisi;
    }
}