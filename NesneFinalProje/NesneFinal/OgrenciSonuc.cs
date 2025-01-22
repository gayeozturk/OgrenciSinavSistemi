using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneFinal
{
    public class OgrenciSonuc
    {
        public string OgrenciAdi { get; set; }
        public int DogruCevaplar { get; set; }
        public int YanlisCevaplar { get; set; }
        public int Puan { get; set; }
        public List<SınavSonucları> Cevaplar { get; set; } // Öğrenci cevapları için yeni liste
    }
}
