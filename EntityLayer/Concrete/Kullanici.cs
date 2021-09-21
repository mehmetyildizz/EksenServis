using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }
        public string KullaniciIsim { get; set; }
        public string KullaniciSoyisim { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }
        public string KullaniciYetki { get; set; }
        public bool KullaniciDurum { get; set; }
        public List<Servis> ServisVTT { get; set; }
        public List<Islem> IslemVT { get; set; }
    }
}
