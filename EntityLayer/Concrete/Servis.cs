using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Servis
    {
        [Key]
        public int ServisID { get; set; }
        public string ServisAciklama { get; set; }
        public DateTime ServisTarihi { get; set; }
        public bool ServisSonuc { get; set; }
        public bool ServisDurum { get; set; }
        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }
        public int MusteriID { get; set; }
        public Musteri Musteri { get; set; }
        public int MarkaID { get; set; }
        public Marka Marka { get; set; }
        public int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
        public List<Islem> IslemVTT { get; set; }
    }
}
