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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NesneFinal
{
    public partial class frmSınav : Form
    {
        
        private string dersAdi;
        private string sinavTarihi;
        private string ogrNo; // Öğrenci numarasını saklamak için kullanılan değişken
        private string[] sorular;
        private string[] cevaplar;
        private int currentSoruIndex = 0;

        private Timer timer;
        private int remainingMinutes;
        private int remainingSeconds;


        public frmSınav(string dersAdi, string sinavTarihi, int remainingMinutes)
        {
            InitializeComponent();
            string ogrNo = txtOgrNo.Text;
            this.dersAdi = dersAdi;
            this.sinavTarihi = sinavTarihi;
            this.remainingMinutes = remainingMinutes;
            
            this.Load += new EventHandler(frmSınav_Load); // Load olayını manuel olarak bağlayın

            // Timer'ı oluştur ve ayarla
            timer = new Timer();
            timer.Interval = 1000; // 1 saniye
            timer.Tick += Timer_Tick;
            
        }

        private void frmSınav_Load(object sender, EventArgs e)
        {
            // Ders adı ve sınav tarihini kullanarak ilgili soruları ve seçenekleri al
            sorular = GetSorular(dersAdi, sinavTarihi);

            // Sorular bulunamadıysa mesaj göster ve işlemi durdur
            if (sorular == null || sorular.Length == 0)
            {
                MessageBox.Show("Belirtilen ders ve tarihe ait soru bulunamadı.");
                return;
            }

            cevaplar = new string[sorular.Length]; // Cevaplar dizisini oluştur

            // İlk soruyu ekrana yükle
            GosterSoru(currentSoruIndex);
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Dakika ve saniye değerlerini güncelle
            if (remainingSeconds == 0)
            {
                remainingMinutes--;
                remainingSeconds = 59;
            }
            else
            {
                remainingSeconds--;
            }

            // Geri sayımı label'a yazdırın (formda labelTime isimli bir Label olduğunu varsayıyoruz)
            labeltime.Text = $"{remainingMinutes.ToString("D2")}:{remainingSeconds.ToString("D2")}";

            // 5 dakika kaldığında uyarı verin
            if (remainingMinutes == 5 && remainingSeconds == 0)
            {
                MessageBox.Show("Sınavın bitmesine 5 dakika kaldı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Süre dolduğunda işlemleri durdurun
            if (remainingMinutes == 0 && remainingSeconds == 0)
            {
                timer.Stop();
                MessageBox.Show("Sınav süresi doldu. Cevaplarınız kaydedilecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Burada cevapları kaydedebilir veya sınavı sonlandırabilirsiniz
                this.Close();
            }
        }

        private string[] GetSorular(string dersAdi, string sinavTarihi)
        {
            try
            {
                // CSV dosyasından ilgili soruları ve seçenekleri oku
                string[] satirlar = File.ReadAllLines("sorular.csv");
                List<string> eslesenSorular = new List<string>();

                foreach (string satir in satirlar)
                {
                    string[] bilgiler = satir.Split(',');

                    if (bilgiler.Length >= 9)
                    {
                        // Ders adi ve sınav tarihinin eşleştiğini kontrol et
                        if (bilgiler[0] == dersAdi && bilgiler[1] == sinavTarihi)
                        {
                            // Soru ve seçenekleri birleştirerek ekleyin
                            eslesenSorular.Add($"{bilgiler[2]},{bilgiler[3]},{bilgiler[4]},{bilgiler[5]},{bilgiler[6]},{bilgiler[7]}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Satırdaki sütun sayısı yetersiz: " + satir);
                    }
                }

                return eslesenSorular.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"CSV dosyasını okurken hata oluştu: {ex.Message}");
                return null;
            }
        }

        private void GosterSoru(int index)
        {
            if (index < 0 || index >= sorular.Length)
            {
                MessageBox.Show("Geçersiz soru indeksi: " + index);
                return;
            }

            if (index == sorular.Length)
            {
                // Sorular bitti, öğrenci numarası girişi ve sınavı bitir butonunu göster
                txtOgrNo.Visible = true;
                btnSınavBitir.Visible = true;
                MessageBox.Show("Sorular bitti. Lütfen öğrenci numaranızı girin ve sınavı bitirin.");
                return;
            }

            string[] soruVeSecenekler = sorular[index].Split(',');

            if (soruVeSecenekler.Length >= 6)
            {
                label1.Text = soruVeSecenekler[0];
                radioButton1.Text = soruVeSecenekler[1];
                radioButton2.Text = soruVeSecenekler[2];
                radioButton3.Text = soruVeSecenekler[3];
                radioButton4.Text = soruVeSecenekler[4];
                radioButton5.Text = soruVeSecenekler[5];

                // Daha önce bu soruya verilmiş bir cevap varsa, onu seç
                if (!string.IsNullOrEmpty(cevaplar[index]))
                {
                    switch (cevaplar[index])
                    {
                        case "A":
                            radioButton1.Checked = true;
                            break;
                        case "B":
                            radioButton2.Checked = true;
                            break;
                        case "C":
                            radioButton3.Checked = true;
                            break;
                        case "D":
                            radioButton4.Checked = true;
                            break;
                        case "E":
                            radioButton5.Checked = true;
                            break;
                    }
                }
                else
                {
                    // Daha önce cevap verilmemişse, hiçbir seçeneği işaretlemeyin
                    radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = radioButton5.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Hatalı soru formatı: " + sorular[index]);
            }
        }

        private void KaydetCevap()
        {
            // Seçilen cevabı cevaplar dizisine kaydet
            if (radioButton1.Checked)
                cevaplar[currentSoruIndex] = "A";
            else if (radioButton2.Checked)
                cevaplar[currentSoruIndex] = "B";
            else if (radioButton3.Checked)
                cevaplar[currentSoruIndex] = "C";
            else if (radioButton4.Checked)
                cevaplar[currentSoruIndex] = "D";
            else if (radioButton5.Checked)
                cevaplar[currentSoruIndex] = "E";
            else
                cevaplar[currentSoruIndex] = ""; // Herhangi bir seçenek seçilmediyse, cevabı temizle
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Geri git butonu tıklandığında bir önceki soruyu göster
            KaydetCevap();
            currentSoruIndex--;
            if (currentSoruIndex >= 0)
            {
                GosterSoru(currentSoruIndex);
            }
            else
            {
                MessageBox.Show("Bu ilk soru.");
                currentSoruIndex = 0; // Sıfırlayın ki indis negatif olmasın
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KaydetCevap();
            currentSoruIndex++;
            if (currentSoruIndex < sorular.Length)
            {
                GosterSoru(currentSoruIndex);
            }
            else
            {
                // Sorular bittiğinde öğrenci numarasını girişi ve sınavı bitir butonunu göster
                txtOgrNo.Visible = true;
                btnSınavBitir.Visible = true;
                MessageBox.Show("Sorular bitti. Lütfen öğrenci numaranızı girin ve sınavı bitirin.");
            }
        }
        private void KaydetCevaplar()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("cevaplar.csv", true)) // true parametresiyle dosyaya ekleme yapılıyor
                {
                    // Her bir sorunun indeksiyle ilişkilendirilmiş cevapları dosyaya yaz
                    for (int i = 0; i < sorular.Length; i++)
                    {
                        string cevap = cevaplar[i];
                        writer.WriteLine($"{dersAdi},{sinavTarihi},{ogrNo},{i + 1},{cevap}"); // Öğrenci numarasını da dosyaya yaz
                    }
                }
                MessageBox.Show("Cevaplar başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cevapları kaydederken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSınavBitir_Click_1(object sender, EventArgs e)
        {
            this.ogrNo = txtOgrNo.Text.Trim();

            if (!string.IsNullOrEmpty(this.ogrNo))
            {
                // Cevapları kaydet
                KaydetCevaplar();
                // Timer'ı durdur ve sınav formunu kapat
                timer.Stop();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir öğrenci numarası girin.");
            }

        }
    }
}

