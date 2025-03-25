using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje3.Models
{
    public class Ders
    {
        public int Id { get; set; }
        public string?  DersAdi { get; set; }
        public string?  DersKisaAciklama { get; set; }
        public string?  DersAciklama { get; set; }
        public string?  DersResim { get; set; }
    }
}