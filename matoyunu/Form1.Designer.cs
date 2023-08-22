namespace matoyunu
{
    partial class Form1
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
            this.lblOp = new System.Windows.Forms.Label();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.lblSayi1Giris = new System.Windows.Forms.Label();
            this.lblOpGiris = new System.Windows.Forms.Label();
            this.lblSayi2Giris = new System.Windows.Forms.Label();
            this.lblEşittir = new System.Windows.Forms.Label();
            this.tbSonuc = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblSoruSayisi = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblDogruGiris = new System.Windows.Forms.Label();
            this.lblSoruSayisiGiris = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOp
            // 
            this.lblOp.Location = new System.Drawing.Point(141, 26);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(85, 27);
            this.lblOp.TabIndex = 1;
            this.lblOp.Text = "Operatör";
            // 
            // lblSayi1
            // 
            this.lblSayi1.Location = new System.Drawing.Point(28, 26);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(85, 27);
            this.lblSayi1.TabIndex = 2;
            this.lblSayi1.Text = "Sayı1";
            // 
            // lblSayi2
            // 
            this.lblSayi2.Location = new System.Drawing.Point(277, 26);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(85, 27);
            this.lblSayi2.TabIndex = 3;
            this.lblSayi2.Text = "Sayı2";
            // 
            // lblSayi1Giris
            // 
            this.lblSayi1Giris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSayi1Giris.Location = new System.Drawing.Point(28, 82);
            this.lblSayi1Giris.Name = "lblSayi1Giris";
            this.lblSayi1Giris.Size = new System.Drawing.Size(85, 57);
            this.lblSayi1Giris.TabIndex = 4;
            // 
            // lblOpGiris
            // 
            this.lblOpGiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOpGiris.Location = new System.Drawing.Point(141, 82);
            this.lblOpGiris.Name = "lblOpGiris";
            this.lblOpGiris.Size = new System.Drawing.Size(85, 57);
            this.lblOpGiris.TabIndex = 5;
            // 
            // lblSayi2Giris
            // 
            this.lblSayi2Giris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSayi2Giris.Location = new System.Drawing.Point(277, 82);
            this.lblSayi2Giris.Name = "lblSayi2Giris";
            this.lblSayi2Giris.Size = new System.Drawing.Size(85, 57);
            this.lblSayi2Giris.TabIndex = 6;
            // 
            // lblEşittir
            // 
            this.lblEşittir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEşittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEşittir.Location = new System.Drawing.Point(422, 82);
            this.lblEşittir.Name = "lblEşittir";
            this.lblEşittir.Size = new System.Drawing.Size(85, 57);
            this.lblEşittir.TabIndex = 7;
            this.lblEşittir.Text = "=";
            this.lblEşittir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSonuc
            // 
            this.tbSonuc.BackColor = System.Drawing.SystemColors.Window;
            this.tbSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSonuc.Location = new System.Drawing.Point(527, 84);
            this.tbSonuc.Multiline = true;
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.Size = new System.Drawing.Size(100, 55);
            this.tbSonuc.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(655, 86);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(76, 53);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblSoruSayisi
            // 
            this.lblSoruSayisi.Location = new System.Drawing.Point(28, 205);
            this.lblSoruSayisi.Name = "lblSoruSayisi";
            this.lblSoruSayisi.Size = new System.Drawing.Size(118, 27);
            this.lblSoruSayisi.TabIndex = 10;
            this.lblSoruSayisi.Text = "Soru Sayısı:";
            // 
            // lblDogru
            // 
            this.lblDogru.Location = new System.Drawing.Point(298, 205);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(165, 27);
            this.lblDogru.TabIndex = 11;
            this.lblDogru.Text = "Doğru Cevap Sayısı:";
            // 
            // lblDogruGiris
            // 
            this.lblDogruGiris.Location = new System.Drawing.Point(458, 205);
            this.lblDogruGiris.Name = "lblDogruGiris";
            this.lblDogruGiris.Size = new System.Drawing.Size(85, 27);
            this.lblDogruGiris.TabIndex = 12;
            this.lblDogruGiris.Text = "0";
            // 
            // lblSoruSayisiGiris
            // 
            this.lblSoruSayisiGiris.Location = new System.Drawing.Point(141, 205);
            this.lblSoruSayisiGiris.Name = "lblSoruSayisiGiris";
            this.lblSoruSayisiGiris.Size = new System.Drawing.Size(85, 27);
            this.lblSoruSayisiGiris.TabIndex = 13;
            this.lblSoruSayisiGiris.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 356);
            this.Controls.Add(this.lblSoruSayisiGiris);
            this.Controls.Add(this.lblDogruGiris);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.lblSoruSayisi);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbSonuc);
            this.Controls.Add(this.lblEşittir);
            this.Controls.Add(this.lblSayi2Giris);
            this.Controls.Add(this.lblOpGiris);
            this.Controls.Add(this.lblSayi1Giris);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.Controls.Add(this.lblOp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Label lblSayi1Giris;
        private System.Windows.Forms.Label lblOpGiris;
        private System.Windows.Forms.Label lblSayi2Giris;
        private System.Windows.Forms.Label lblEşittir;
        private System.Windows.Forms.TextBox tbSonuc;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblSoruSayisi;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblDogruGiris;
        private System.Windows.Forms.Label lblSoruSayisiGiris;
    }
}

