using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Musteri
    {
        [Key]
        public int MusteriID { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string MusteriTel1 { get; set; }
        public string MusteriTel2 { get; set; }
        public string MusteriAdres { get; set; }
        public bool MusteriDurum { get; set; }
        public List<Servis> ServisVTT { get; set; }
    }
}
