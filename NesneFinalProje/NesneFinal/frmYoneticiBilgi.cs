using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NesneFinal
{
    public partial class frmYoneticiBilgi : Form
    {
        private const string usersFilePath = "users.csv";
        public frmYoneticiBilgi()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string tcNo = txtTCNo.Text;

            if (AuthenticateUser(username, password, tcNo))
            {
                MessageBox.Show("Giriş Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Giriş başarılıysa diğer işlemleri buraya ekleyebilirsiniz
            }
            else
            {
                MessageBox.Show("Kullanıcı adı, şifre veya TC kimlik numarası yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool AuthenticateUser(string username, string password, string tcNo)
        {
            bool authenticated = false;

            try
            {
                string[] lines = File.ReadAllLines(usersFilePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 3)
                    {
                        string storedUsername = parts[0];
                        string storedPassword = parts[1];
                        string storedTCNo = parts[2];

                        if (storedUsername == username && storedPassword == password && storedTCNo == tcNo)
                        {
                            authenticated = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return authenticated;
        }

        
    }
}
