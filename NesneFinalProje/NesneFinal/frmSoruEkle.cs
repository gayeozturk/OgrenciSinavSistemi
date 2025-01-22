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
    public partial class frmSoruEkle : Form
    {
        public frmSoruEkle()
        {
            InitializeComponent();
        }

        private void btnSonrakiSoru_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcı tarafından girilen bilgileri al
                string dersAdi = cmbSoruDers.SelectedItem.ToString();
                string sınavBaslamaTarihi = dtimeSınavGunu.Value.ToShortDateString();
                string soruMetni = txtSoru.Text;
                string[] secenekler = { txtA.Text, txtB.Text, txtC.Text, txtD.Text, txtE.Text };
                string dogruCevap = cmbDogruSık.SelectedItem.ToString();

                // Bilgileri CSV dosyasına ekle
                string dosyaYolu = "sorular.csv";
                using (StreamWriter writer = new StreamWriter(dosyaYolu, true, Encoding.UTF8))
                {
                    writer.WriteLine($"{dersAdi},{sınavBaslamaTarihi},{soruMetni},{string.Join(",", secenekler)},{dogruCevap}");
                }

                MessageBox.Show("Soru bilgileri CSV dosyasına kaydedildi.");
                txtSoru.Clear();
                txtA.Clear();
                txtB.Clear();
                txtC.Clear();
                txtD.Clear();
                txtE.Clear();
                cmbDogruSık.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}
