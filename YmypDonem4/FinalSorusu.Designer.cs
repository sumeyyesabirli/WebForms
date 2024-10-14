namespace YmypDonem4
{
    partial class FinalSorusu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalSorusu));
            this.label1 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnDiziyeAktar = new System.Windows.Forms.Button();
            this.btnElemanSayisi = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN ADI";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(17, 54);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(434, 42);
            this.txtProdName.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(17, 124);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(434, 42);
            this.txtQuantity.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "ÜRÜN ADEDİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "BİRİM FİYATI (double)";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(17, 194);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(434, 42);
            this.txtPrice.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(122, 235);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(161, 59);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(289, 235);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(161, 59);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 36;
            this.lstListe.Location = new System.Drawing.Point(17, 300);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(433, 364);
            this.lstListe.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(466, 54);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(511, 276);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // btnDiziyeAktar
            // 
            this.btnDiziyeAktar.Location = new System.Drawing.Point(466, 336);
            this.btnDiziyeAktar.Name = "btnDiziyeAktar";
            this.btnDiziyeAktar.Size = new System.Drawing.Size(511, 59);
            this.btnDiziyeAktar.TabIndex = 4;
            this.btnDiziyeAktar.Text = "DİZİYE AKTAR";
            this.btnDiziyeAktar.UseVisualStyleBackColor = true;
            this.btnDiziyeAktar.Click += new System.EventHandler(this.btnDiziyeAktar_Click);
            // 
            // btnElemanSayisi
            // 
            this.btnElemanSayisi.Location = new System.Drawing.Point(466, 632);
            this.btnElemanSayisi.Name = "btnElemanSayisi";
            this.btnElemanSayisi.Size = new System.Drawing.Size(511, 59);
            this.btnElemanSayisi.TabIndex = 4;
            this.btnElemanSayisi.Text = "DİZİNİN ELEMAN SAYISINI GÖSTER";
            this.btnElemanSayisi.UseVisualStyleBackColor = true;
            this.btnElemanSayisi.Click += new System.EventHandler(this.btnElemanSayisi_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(466, 401);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(511, 225);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // FinalSorusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 706);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.btnElemanSayisi);
            this.Controls.Add(this.btnDiziyeAktar);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FinalSorusu";
            this.Text = "FinalSorusu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnDiziyeAktar;
        private System.Windows.Forms.Button btnElemanSayisi;
        private System.Windows.Forms.TextBox textBox5;
    }
}