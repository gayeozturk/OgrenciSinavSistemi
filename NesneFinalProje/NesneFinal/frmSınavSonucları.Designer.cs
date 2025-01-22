namespace NesneFinal
{
    partial class frmSınavSonucları
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
            this.dtimesınavgun = new System.Windows.Forms.DateTimePicker();
            this.txtGoruntule = new System.Windows.Forms.Button();
            this.dtimeSınavTarih1 = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtimesınavgun
            // 
            this.dtimesınavgun.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimesınavgun.Location = new System.Drawing.Point(148, 75);
            this.dtimesınavgun.Name = "dtimesınavgun";
            this.dtimesınavgun.Size = new System.Drawing.Size(121, 22);
            this.dtimesınavgun.TabIndex = 2;
            // 
            // txtGoruntule
            // 
            this.txtGoruntule.Location = new System.Drawing.Point(169, 103);
            this.txtGoruntule.Name = "txtGoruntule";
            this.txtGoruntule.Size = new System.Drawing.Size(100, 40);
            this.txtGoruntule.TabIndex = 3;
            this.txtGoruntule.Text = "Görüntüle";
            this.txtGoruntule.UseVisualStyleBackColor = true;
            this.txtGoruntule.Click += new System.EventHandler(this.txtGoruntule_Click);
            // 
            // dtimeSınavTarih1
            // 
            this.dtimeSınavTarih1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeSınavTarih1.Location = new System.Drawing.Point(168, 80);
            this.dtimeSınavTarih1.Name = "dtimeSınavTarih1";
            this.dtimeSınavTarih1.Size = new System.Drawing.Size(121, 22);
            this.dtimeSınavTarih1.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(118, 124);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(125, 72);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Excel Formatında Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ders Adını Girin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sınav Tarihini Girin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ders Adını Girin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sınav Tarihini Girin:";
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Items.AddRange(new object[] {
            "Fizik",
            "Matematik",
            "Biyoloji",
            "Tarih",
            "Coğrafya",
            "Edebiyat",
            "İngilizce"});
            this.cmbDers.Location = new System.Drawing.Point(148, 37);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(121, 24);
            this.cmbDers.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fizik",
            "Matematik",
            "Biyoloji",
            "Tarih",
            "Coğrafya",
            "Edebiyat",
            "İngilizce"});
            this.comboBox1.Location = new System.Drawing.Point(168, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtimeSınavTarih1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 225);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel Bilgi Tablosu";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listView1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(301, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(505, 191);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // frmSınavSonucları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 464);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbDers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGoruntule);
            this.Controls.Add(this.dtimesınavgun);
            this.Name = "frmSınavSonucları";
            this.Text = "frmSınavSonucları";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtimesınavgun;
        private System.Windows.Forms.Button txtGoruntule;
        private System.Windows.Forms.DateTimePicker dtimeSınavTarih1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
    }
}