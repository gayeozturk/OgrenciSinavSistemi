namespace NesneFinal
{
    partial class frmSoruEkle
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
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.btnSonrakiSoru = new System.Windows.Forms.Button();
            this.cmbDogruSık = new System.Windows.Forms.ComboBox();
            this.cmbSoruDers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtimeSınavGunu = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(251, 61);
            this.txtSoru.Multiline = true;
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(387, 116);
            this.txtSoru.TabIndex = 0;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(251, 183);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(387, 30);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(251, 219);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(387, 30);
            this.txtB.TabIndex = 3;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(251, 255);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(387, 30);
            this.txtC.TabIndex = 4;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(251, 291);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(387, 30);
            this.txtD.TabIndex = 5;
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(251, 327);
            this.txtE.Multiline = true;
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(387, 30);
            this.txtE.TabIndex = 6;
            // 
            // btnSonrakiSoru
            // 
            this.btnSonrakiSoru.Location = new System.Drawing.Point(572, 380);
            this.btnSonrakiSoru.Name = "btnSonrakiSoru";
            this.btnSonrakiSoru.Size = new System.Drawing.Size(178, 38);
            this.btnSonrakiSoru.TabIndex = 7;
            this.btnSonrakiSoru.Text = "Kaydet ve Sonraki Soru";
            this.btnSonrakiSoru.UseVisualStyleBackColor = true;
            this.btnSonrakiSoru.Click += new System.EventHandler(this.btnSonrakiSoru_Click);
            // 
            // cmbDogruSık
            // 
            this.cmbDogruSık.FormattingEnabled = true;
            this.cmbDogruSık.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cmbDogruSık.Location = new System.Drawing.Point(251, 380);
            this.cmbDogruSık.Name = "cmbDogruSık";
            this.cmbDogruSık.Size = new System.Drawing.Size(121, 24);
            this.cmbDogruSık.TabIndex = 8;
            // 
            // cmbSoruDers
            // 
            this.cmbSoruDers.FormattingEnabled = true;
            this.cmbSoruDers.Items.AddRange(new object[] {
            "Fizik",
            "Matematik",
            "Biyoloji",
            "Tarih",
            "Coğrafya",
            "Edebiyat",
            "İngilizce"});
            this.cmbSoruDers.Location = new System.Drawing.Point(251, 31);
            this.cmbSoruDers.Name = "cmbSoruDers";
            this.cmbSoruDers.Size = new System.Drawing.Size(121, 24);
            this.cmbSoruDers.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ders Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soru Metnini Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Seçenek A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Seçenek B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Seçenek C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Seçenek D";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Seçenek E";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Doğru Şık";
            // 
            // dtimeSınavGunu
            // 
            this.dtimeSınavGunu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeSınavGunu.Location = new System.Drawing.Point(531, 33);
            this.dtimeSınavGunu.Name = "dtimeSınavGunu";
            this.dtimeSınavGunu.Size = new System.Drawing.Size(107, 22);
            this.dtimeSınavGunu.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Sınav Başlama Günü";
            // 
            // frmSoruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtimeSınavGunu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSoruDers);
            this.Controls.Add(this.cmbDogruSık);
            this.Controls.Add(this.btnSonrakiSoru);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtSoru);
            this.Name = "frmSoruEkle";
            this.Text = "frmSoruEkle";
            //((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtE;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Button btnSonrakiSoru;
        private System.Windows.Forms.ComboBox cmbDogruSık;
        private System.Windows.Forms.ComboBox cmbSoruDers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtimeSınavGunu;
        private System.Windows.Forms.Label label9;
    }
}