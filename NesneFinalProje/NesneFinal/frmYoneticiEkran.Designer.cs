namespace NesneFinal
{
    partial class frmYoneticiEkran
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnSınavBilgileriGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sınav Sonuçları İçin Tıklayınız";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSınavBilgileriGiris
            // 
            this.btnSınavBilgileriGiris.Location = new System.Drawing.Point(278, 77);
            this.btnSınavBilgileriGiris.Name = "btnSınavBilgileriGiris";
            this.btnSınavBilgileriGiris.Size = new System.Drawing.Size(184, 82);
            this.btnSınavBilgileriGiris.TabIndex = 0;
            this.btnSınavBilgileriGiris.Text = "Sınav Bilgileri İçin Tıklayınız";
            this.btnSınavBilgileriGiris.UseVisualStyleBackColor = true;
            this.btnSınavBilgileriGiris.Click += new System.EventHandler(this.btnSınavBilgileriGiris_Click);
            // 
            // frmYoneticiEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSınavBilgileriGiris);
            this.Name = "frmYoneticiEkran";
            this.Text = "frmYoneticiEkran";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSınavBilgileriGiris;
    }
}