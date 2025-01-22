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
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            frmYoneticiGiris frmYoneticiGiris = new frmYoneticiGiris();
            frmYoneticiGiris.ShowDialog();

        }

        private void btnOgrenciGiris_Click(object sender, EventArgs e)
        {
            frmOgrenciGiris frmOgrenciGiris = new frmOgrenciGiris();
            frmOgrenciGiris.ShowDialog();

        }
    }
}
