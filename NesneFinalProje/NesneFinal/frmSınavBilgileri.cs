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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneFinal
{
    public partial class frmSınavBilgileri : Form
    {
        public frmSınavBilgileri()
        {
            InitializeComponent();
        }

        private void btnSınavSoruGir_Click(object sender, EventArgs e)
        {

            frmSoruEkle frmSoruEkle = new frmSoruEkle();
            frmSoruEkle.ShowDialog();
        }

        private void btnSınavKaydet_Click(object sender, EventArgs e)
        {
            string dersAdi = cmbDersAd.SelectedItem.ToString();
            string sinavSuresi = txtSınavSure.Text;
            string sinavBaslangic = dtimeBaslama.Value.ToShortDateString();
            string sinavBitis = dtimeBitis.Value.ToShortDateString();
            string sinavSaati = txtSınavSaat.Text;
            string puanlama = txtSınavPuanlama.Text;
            

            // Bilgileri CSV dosyasına ekle
            string dosyaYolu = "sinavlar.csv";
            using (StreamWriter writer = new StreamWriter(dosyaYolu, true, Encoding.UTF8))
            {
                writer.WriteLine($"{dersAdi},{sinavSuresi},{sinavBaslangic},{sinavBitis},{sinavSaati},{puanlama}");
            }

            MessageBox.Show("Bilgiler CSV dosyasına kaydedildi.");
        }
    }
}
