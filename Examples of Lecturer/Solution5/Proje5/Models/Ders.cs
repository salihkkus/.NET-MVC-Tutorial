using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje5.Models
{
    public class Ders
    {
        public int Id { get; set; }
        public string? Adi { get; set; }
        public string? DersResmi { get; set; }
        public string? DersKisaAciklama { get; set; }
        public string? DersAciklamasi { get; set; }
    }
}