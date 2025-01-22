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
    public partial class frmOgrenciSınavBilgi : Form
    {
        public frmOgrenciSınavBilgi()
        {
            InitializeComponent();
        }
        private void cmbDersAdı_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenDers = cmbDersAdı.SelectedItem.ToString();

            // CSV dosyasından sınav bilgilerini oku
            string[] satirlar = File.ReadAllLines("sinavlar.csv");

            foreach (string satir in satirlar)
            {
                string[] bilgiler = satir.Split(',');

                if (bilgiler.Length >= 6 && bilgiler[0] == secilenDers)
                {
                    // Sınav bilgilerini ilgili textbox'lara yerleştir
                    txtSure.Text = bilgiler[1];
                    txtBasTarih.Text = bilgiler[2];
                    txtBitTarih.Text = bilgiler[3];
                    txtBasSaat.Text = bilgiler[4];
                    txtPuanlama.Text = bilgiler[5];

                    // Diğer bilgileri almak istiyorsanız buraya ekleyebilirsiniz
                }
            }
        }

        private void btnSınavGiris_Click(object sender, EventArgs e)
        {
            string secilenDers = cmbDersAdı.SelectedItem?.ToString();
            string sinavTarihi = txtBasTarih.Text;

            // Seçilen ders ve sınav tarihi boş olmamalıdır
            if (string.IsNullOrEmpty(secilenDers) || string.IsNullOrEmpty(sinavTarihi))
            {
                MessageBox.Show("Lütfen geçerli bir ders seçin ve sınav tarihini girin.",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Geri sayım süresini dakika cinsine çevirin
            int remainingMinutes;

            if (!int.TryParse(txtSure.Text, out remainingMinutes))
            {
                MessageBox.Show("Geçerli bir geri sayım süresi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sınav formunu oluşturun ve gösterin
            frmSınav form = new frmSınav(secilenDers, sinavTarihi, remainingMinutes);
            form.Show();
        }
    }
    }

