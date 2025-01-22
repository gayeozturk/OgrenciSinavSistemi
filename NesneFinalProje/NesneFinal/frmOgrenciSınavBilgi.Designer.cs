namespace NesneFinal
{
    partial class frmOgrenciSınavBilgi
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
            this.txtSure = new System.Windows.Forms.TextBox();
            this.txtBasTarih = new System.Windows.Forms.TextBox();
            this.txtBitTarih = new System.Windows.Forms.TextBox();
            this.txtBasSaat = new System.Windows.Forms.TextBox();
            this.txtPuanlama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSınavGiris = new System.Windows.Forms.Button();
            this.cmbDersAdı = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(179, 92);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(178, 22);
            this.txtSure.TabIndex = 1;
            // 
            // txtBasTarih
            // 
            this.txtBasTarih.Location = new System.Drawing.Point(179, 131);
            this.txtBasTarih.Name = "txtBasTarih";
            this.txtBasTarih.Size = new System.Drawing.Size(178, 22);
            this.txtBasTarih.TabIndex = 2;
            // 
            // txtBitTarih
            // 
            this.txtBitTarih.Location = new System.Drawing.Point(179, 173);
            this.txtBitTarih.Name = "txtBitTarih";
            this.txtBitTarih.Size = new System.Drawing.Size(178, 22);
            this.txtBitTarih.TabIndex = 3;
            // 
            // txtBasSaat
            // 
            this.txtBasSaat.Location = new System.Drawing.Point(179, 214);
            this.txtBasSaat.Name = "txtBasSaat";
            this.txtBasSaat.Size = new System.Drawing.Size(178, 22);
            this.txtBasSaat.TabIndex = 4;
            // 
            // txtPuanlama
            // 
            this.txtPuanlama.Location = new System.Drawing.Point(179, 258);
            this.txtPuanlama.Name = "txtPuanlama";
            this.txtPuanlama.Size = new System.Drawing.Size(178, 22);
            this.txtPuanlama.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dersin Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sınav Süresi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sınav Başlama Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sınav Bitiş Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sınav Saati:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Puanlama Sistemi:";
            // 
            // btnSınavGiris
            // 
            this.btnSınavGiris.Location = new System.Drawing.Point(446, 317);
            this.btnSınavGiris.Name = "btnSınavGiris";
            this.btnSınavGiris.Size = new System.Drawing.Size(224, 47);
            this.btnSınavGiris.TabIndex = 14;
            this.btnSınavGiris.Text = "Sınava Başla";
            this.btnSınavGiris.UseVisualStyleBackColor = true;
            this.btnSınavGiris.Click += new System.EventHandler(this.btnSınavGiris_Click);
            // 
            // cmbDersAdı
            // 
            this.cmbDersAdı.FormattingEnabled = true;
            this.cmbDersAdı.Items.AddRange(new object[] {
            "Fizik",
            "Matematik",
            "Biyoloji",
            "Tarih",
            "Coğrafya",
            "Edebiyat",
            "İngilizce"});
            this.cmbDersAdı.Location = new System.Drawing.Point(179, 53);
            this.cmbDersAdı.Name = "cmbDersAdı";
            this.cmbDersAdı.Size = new System.Drawing.Size(178, 24);
            this.cmbDersAdı.TabIndex = 15;
            this.cmbDersAdı.SelectedIndexChanged += new System.EventHandler(this.cmbDersAdı_SelectedIndexChanged);
            // 
            // frmOgrenciSınavBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbDersAdı);
            this.Controls.Add(this.btnSınavGiris);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPuanlama);
            this.Controls.Add(this.txtBasSaat);
            this.Controls.Add(this.txtBitTarih);
            this.Controls.Add(this.txtBasTarih);
            this.Controls.Add(this.txtSure);
            this.Name = "frmOgrenciSınavBilgi";
            this.Text = "frmOgrenciSınavBilgi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.TextBox txtBasTarih;
        private System.Windows.Forms.TextBox txtBitTarih;
        private System.Windows.Forms.TextBox txtBasSaat;
        private System.Windows.Forms.TextBox txtPuanlama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSınavGiris;
        private System.Windows.Forms.ComboBox cmbDersAdı;
    }
}