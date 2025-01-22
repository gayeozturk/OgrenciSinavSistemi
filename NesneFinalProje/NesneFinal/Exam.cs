using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneFinal
{
    public class Exam
    {
        public int Id { get; set; }
        public string DersAdi { get; set; }
        public int Sure { get; set; } // Sınav süresi dakika cinsinden
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int SoruSayisi { get; set; }
        public int Puan { get; set; }
    }
}
