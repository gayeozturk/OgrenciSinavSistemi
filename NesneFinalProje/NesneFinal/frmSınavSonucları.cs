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
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;

namespace NesneFinal
{
    public partial class frmSınavSonucları : Form
    {
        public frmSınavSonucları()
        {
            InitializeComponent();
            InitializeListView();
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Tam nitelikli adı kullanarak lisans bağlamını ayarla
        }
        private void InitializeListView()
        {
            listView1.View = View.Details; // Detay görünümüne ayarla
            listView1.Columns.Add("Ders Adı", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Sınav Tarihi", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Öğrenci Adı", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Not", -2, HorizontalAlignment.Left);
            // Gerekli diğer sütunları burada ekleyin
        }
        private void txtGoruntule_Click(object sender, EventArgs e)
        {
            // Seçilen ders adını ve tarihi al
            string selectedCourse = cmbDers.SelectedItem?.ToString();
            DateTime selectedDate = dtimesınavgun.Value.Date;

            if (selectedCourse == null)
            {
                MessageBox.Show("Lütfen bir ders adı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // CSV dosyasını oku ve eşleşen satırları bul
            string csvFilePath = "cevaplar.csv"; // CSV dosyasının yolu
            List<string[]> matchedRows = FindMatchingRows(csvFilePath, selectedCourse, selectedDate);

            // ListView'a eşleşen satırları ekle
            listView1.Items.Clear(); // Önceki verileri temizle
            foreach (string[] row in matchedRows)
            {
                ListViewItem item = new ListViewItem(row[0]); // İlk sütunu ekle
                for (int i = 1; i < row.Length; i++)
                {
                    item.SubItems.Add(row[i]); // Diğer sütunları ekle
                }
                listView1.Items.Add(item);
            }
        }


        private List<string[]> FindMatchingRows(string filePath, string courseName, DateTime date)
        {
            List<string[]> matchedRows = new List<string[]>();

            // CSV dosyasını satır satır oku ve eşleşen satırları bul
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(','); // CSV dosyasındaki her bir sütunu ayır
                    string csvCourseName = parts[0]; // Ders adı
                    DateTime csvDate = DateTime.Parse(parts[1]); // Sınav tarihi

                    // Ders adı ve tarih eşleşiyorsa, satırı eşleşenler listesine ekle
                    if (csvCourseName == courseName && csvDate.Date == date.Date)
                    {
                        matchedRows.Add(parts);
                    }
                }
            }

            return matchedRows;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Seçilen ders adını ve tarihi al
            string selectedCourse = comboBox1.SelectedItem?.ToString();
            DateTime selectedDate = dtimeSınavTarih1.Value.Date;

            if (selectedCourse == null)
            {
                MessageBox.Show("Lütfen bir ders adı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // CSV dosyasını oku ve eşleşen satırları bul
            string csvFilePath = "cevaplar.csv"; // CSV dosyasının yolu
            List<string[]> matchedRows = FindMatchingRows1(csvFilePath, selectedCourse, selectedDate);

            // Masaüstüne Excel dosyasını kaydet
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string excelFilePath = Path.Combine(desktopPath, "sonuclar.xlsx"); // Masaüstüne kaydetmek için yol

            UpdateExcelFile(excelFilePath, matchedRows);

            // Bilgi mesajı göster
            MessageBox.Show("Excel dosyası başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private List<string[]> FindMatchingRows1(string filePath, string courseName, DateTime date)
        {
            List<string[]> matchedRows = new List<string[]>();

            // CSV dosyasını satır satır oku ve eşleşen satırları bul
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(','); // CSV dosyasındaki her bir sütunu ayır
                    string csvCourseName = parts[0]; // Ders adı
                    DateTime csvDate = DateTime.Parse(parts[1]); // Sınav tarihi

                    // Ders adı ve tarih eşleşiyorsa, satırı eşleşenler listesine ekle
                    if (csvCourseName == courseName && csvDate.Date == date.Date)
                    {
                        matchedRows.Add(parts);
                    }
                }
            }

            return matchedRows;
        }
        private void UpdateExcelFile(string filePath, List<string[]> matchedRows)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault() ?? package.Workbook.Worksheets.Add("Sonuclar");

                // Başlıkları ayarla
                if (worksheet.Dimension == null)
                {
                    worksheet.Cells[1, 1].Value = "Soru Sayısı";
                    worksheet.Cells[1, 2].Value = "A Seçeneği";
                    worksheet.Cells[1, 3].Value = "B Seçeneği";
                    worksheet.Cells[1, 4].Value = "C Seçeneği";
                    worksheet.Cells[1, 5].Value = "D Seçeneği";
                    worksheet.Cells[1, 6].Value = "E Seçeneği";
                }

                // Soru sayısına göre gruplama yaparak öğrenci yanıtlarını saymak için bir sözlük kullan
                Dictionary<int, int[]> questionAnswerCounts = new Dictionary<int, int[]>();

                foreach (var row in matchedRows)
                {
                    int questionCount = int.Parse(row[3]);
                    string answer = row[4];

                    if (!questionAnswerCounts.ContainsKey(questionCount))
                    {
                        questionAnswerCounts[questionCount] = new int[5]; // A, B, C, D, E için sayımlar
                    }

                    switch (answer)
                    {
                        case "A":
                            questionAnswerCounts[questionCount][0]++;
                            break;
                        case "B":
                            questionAnswerCounts[questionCount][1]++;
                            break;
                        case "C":
                            questionAnswerCounts[questionCount][2]++;
                            break;
                        case "D":
                            questionAnswerCounts[questionCount][3]++;
                            break;
                        case "E":
                            questionAnswerCounts[questionCount][4]++;
                            break;
                    }
                }
                // Sonuçları Excel dosyasına yaz
                int rowNumber = worksheet.Dimension?.Rows + 1 ?? 2;
                foreach (var entry in questionAnswerCounts)
                {
                    worksheet.Cells[rowNumber, 1].Value = entry.Key; // Soru Sayısı
                    worksheet.Cells[rowNumber, 2].Value = entry.Value[0]; // A Seçeneği
                    worksheet.Cells[rowNumber, 3].Value = entry.Value[1]; // B Seçeneği
                    worksheet.Cells[rowNumber, 4].Value = entry.Value[2]; // C Seçeneği
                    worksheet.Cells[rowNumber, 5].Value = entry.Value[3]; // D Seçeneği
                    worksheet.Cells[rowNumber, 6].Value = entry.Value[4]; // E Seçeneği
                    rowNumber++;
                }
                package.Save();


            }
        }
    }
}

