using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace NesneFinal
{
    public class Sorular
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public string Metin { get; set; }
        public List<Secenekler> Secenekler { get; set; }
        public int DogruSecenekId { get; set; }
    }
}
