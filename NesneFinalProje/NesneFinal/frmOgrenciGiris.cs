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
    public partial class frmOgrenciGiris : Form
    {
        public frmOgrenciGiris()
        {
            InitializeComponent();
        }
        private void btnOgrenciGiris_Click(object sender, EventArgs e)
            {
                string ogrenciNo = txtOgrNo.Text;
                string tcKimlikNo = txtOgrTC.Text;

                if (DogrulaOgrenci(ogrenciNo, tcKimlikNo))
                {
                    MessageBox.Show("Giriş başarılı!");
                    // Yeni formu aç
                    frmOgrenciEkran frmOgrenciEkran = new frmOgrenciEkran();
                frmOgrenciEkran.Show();
                }
                else
                {
                    MessageBox.Show("Öğrenci numarası veya TC kimlik numarası hatalı!");
                }
        }
        private bool DogrulaOgrenci(string ogrenciNo, string tcKimlikNo)
        {
            string[] satirlar = File.ReadAllLines("ogrenciler.csv");

            foreach (string satir in satirlar)
            {
                string[] bilgiler = satir.Split(',');
                if (bilgiler.Length == 2)
                {
                    string csvOgrenciNo = bilgiler[0];
                    string csvTCKimlikNo = bilgiler[1];

                    if (csvOgrenciNo == ogrenciNo && csvTCKimlikNo == tcKimlikNo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
    }

