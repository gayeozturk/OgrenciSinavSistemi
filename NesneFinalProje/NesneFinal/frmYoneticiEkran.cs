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

namespace NesneFinal
{
    public partial class frmYoneticiEkran : Form
    {
        public frmYoneticiEkran()
        {
            InitializeComponent();
        }

        private void btnSınavBilgileriGiris_Click(object sender, EventArgs e)
        {
            frmSınavBilgileri frmSınavBilgileri = new frmSınavBilgileri();
            frmSınavBilgileri.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSınavSonucları frmSınavSonucları = new frmSınavSonucları();
            frmSınavSonucları.ShowDialog();
        }
    }
}
