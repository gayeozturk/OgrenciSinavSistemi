/****************************************************************************
**					DÜZCE ÜNİVERSİTESİ
**				Lisansüstü Eğitim Enstitüsü 
**				    Bilgisayar Mühendisliği Anabilim Dalı Yüksek Lisans
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				
**				ÖĞRENCİ ADI............: Gaye ÖZTÜRK
**				ÖĞRENCİ NUMARASI.......: 2345007014
**                        
****************************************************************************/
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
    public partial class frmYoneticiGiris : Form
    {
        public frmYoneticiGiris()
        {
            InitializeComponent();
        }
       
        private bool DogrulaKullanici(string kullaniciAdi, string sifre)
        {
            string[] satirlar = File.ReadAllLines("kullanicilar.csv");

            foreach (string satir in satirlar)
            {
                string[] bilgiler = satir.Split(',');
                if (bilgiler.Length == 2)
                {
                    string csvKullaniciAdi = bilgiler[0];
                    string csvSifre = bilgiler[1];

                    if (csvKullaniciAdi == kullaniciAdi && csvSifre == sifre)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnKullaniciGiris_Click_1(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAd.Text;
            string sifre = txtKullaniciSifre.Text;

            if (DogrulaKullanici(kullaniciAdi, sifre))
            {
                MessageBox.Show("Giriş başarılı!");
                // Yeni formu aç
                frmYoneticiEkran frmYoneticiEkran = new frmYoneticiEkran();
                frmYoneticiEkran.Show();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }

        }
    }
}

