namespace NesneFinal
{
    partial class frmSınavBilgileri
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
            this.txtSınavSure = new System.Windows.Forms.TextBox();
            this.txtSınavSaat = new System.Windows.Forms.TextBox();
            this.txtSınavPuanlama = new System.Windows.Forms.TextBox();
            this.btnSınavKaydet = new System.Windows.Forms.Button();
            this.btnSınavSoruGir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtimeBaslama = new System.Windows.Forms.DateTimePicker();
            this.dtimeBitis = new System.Windows.Forms.DateTimePicker();
            this.cmbDersAd = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtSınavSure
            // 
            this.txtSınavSure.Location = new System.Drawing.Point(300, 52);
            this.txtSınavSure.Name = "txtSınavSure";
            this.txtSınavSure.Size = new System.Drawing.Size(121, 22);
            this.txtSınavSure.TabIndex = 1;
            // 
            // txtSınavSaat
            // 
            this.txtSınavSaat.Location = new System.Drawing.Point(300, 175);
            this.txtSınavSaat.Name = "txtSınavSaat";
            this.txtSınavSaat.Size = new System.Drawing.Size(121, 22);
            this.txtSınavSaat.TabIndex = 3;
            // 
            // txtSınavPuanlama
            // 
            this.txtSınavPuanlama.Location = new System.Drawing.Point(300, 216);
            this.txtSınavPuanlama.Name = "txtSınavPuanlama";
            this.txtSınavPuanlama.Size = new System.Drawing.Size(118, 22);
            this.txtSınavPuanlama.TabIndex = 4;
            // 
            // btnSınavKaydet
            // 
            this.btnSınavKaydet.Location = new System.Drawing.Point(246, 274);
            this.btnSınavKaydet.Name = "btnSınavKaydet";
            this.btnSınavKaydet.Size = new System.Drawing.Size(175, 50);
            this.btnSınavKaydet.TabIndex = 5;
            this.btnSınavKaydet.Text = "Sınav Bilgilerini Kaydet";
            this.btnSınavKaydet.UseVisualStyleBackColor = true;
            this.btnSınavKaydet.Click += new System.EventHandler(this.btnSınavKaydet_Click);
            // 
            // btnSınavSoruGir
            // 
            this.btnSınavSoruGir.Location = new System.Drawing.Point(485, 274);
            this.btnSınavSoruGir.Name = "btnSınavSoruGir";
            this.btnSınavSoruGir.Size = new System.Drawing.Size(198, 50);
            this.btnSınavSoruGir.TabIndex = 6;
            this.btnSınavSoruGir.Text = "Sınav Sorularını Giriniz";
            this.btnSınavSoruGir.UseVisualStyleBackColor = true;
            this.btnSınavSoruGir.Click += new System.EventHandler(this.btnSınavSoruGir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dersin adını Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sınav Süresini Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sınav Başlama Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sınav Bitiş Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sınav Saati Giriniz:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Puanlama Sistemi:";
            // 
            // dtimeBaslama
            // 
            this.dtimeBaslama.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeBaslama.Location = new System.Drawing.Point(300, 93);
            this.dtimeBaslama.Name = "dtimeBaslama";
            this.dtimeBaslama.Size = new System.Drawing.Size(118, 22);
            this.dtimeBaslama.TabIndex = 13;
            // 
            // dtimeBitis
            // 
            this.dtimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeBitis.Location = new System.Drawing.Point(300, 137);
            this.dtimeBitis.Name = "dtimeBitis";
            this.dtimeBitis.Size = new System.Drawing.Size(118, 22);
            this.dtimeBitis.TabIndex = 14;
            // 
            // cmbDersAd
            // 
            this.cmbDersAd.FormattingEnabled = true;
            this.cmbDersAd.Items.AddRange(new object[] {
            "Fizik",
            "Matematik",
            "Biyoloji",
            "Tarih",
            "Coğrafya",
            "Edebiyat",
            "İngilizce"});
            this.cmbDersAd.Location = new System.Drawing.Point(300, 15);
            this.cmbDersAd.Name = "cmbDersAd";
            this.cmbDersAd.Size = new System.Drawing.Size(121, 24);
            this.cmbDersAd.TabIndex = 15;
            // 
            // frmSınavBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbDersAd);
            this.Controls.Add(this.dtimeBitis);
            this.Controls.Add(this.dtimeBaslama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSınavSoruGir);
            this.Controls.Add(this.btnSınavKaydet);
            this.Controls.Add(this.txtSınavPuanlama);
            this.Controls.Add(this.txtSınavSaat);
            this.Controls.Add(this.txtSınavSure);
            this.Name = "frmSınavBilgileri";
            this.Text = "frmSınavBilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSınavSure;
        private System.Windows.Forms.TextBox txtSınavSaat;
        private System.Windows.Forms.TextBox txtSınavPuanlama;
        private System.Windows.Forms.Button btnSınavKaydet;
        private System.Windows.Forms.Button btnSınavSoruGir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtimeBaslama;
        private System.Windows.Forms.DateTimePicker dtimeBitis;
        private System.Windows.Forms.ComboBox cmbDersAd;
    }
}