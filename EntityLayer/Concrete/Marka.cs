using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Marka
    {
        [Key]
        public int MarkaID { get; set; }
        public string MarkaAdi { get; set; }
        public string MarkaAciklama { get; set; }
        public bool MarkaDurum { get; set; }
        public List<Servis> ServisVTT { get; set; }
    }
}
