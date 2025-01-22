namespace NesneFinal
{
    partial class frmOgrenciEkran
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
            this.btnSınavBilgi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSınavBilgi
            // 
            this.btnSınavBilgi.Location = new System.Drawing.Point(255, 160);
            this.btnSınavBilgi.Name = "btnSınavBilgi";
            this.btnSınavBilgi.Size = new System.Drawing.Size(285, 54);
            this.btnSınavBilgi.TabIndex = 0;
            this.btnSınavBilgi.Text = "Sınav Bilgileri ve Sınava Giriş";
            this.btnSınavBilgi.UseVisualStyleBackColor = true;
            this.btnSınavBilgi.Click += new System.EventHandler(this.btnSınavBilgi_Click);
            // 
            // frmOgrenciEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSınavBilgi);
            this.Name = "frmOgrenciEkran";
            this.Text = "frmOgrenciEkran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSınavBilgi;
    }
}