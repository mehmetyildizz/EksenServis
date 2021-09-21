using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Islem
    {
        [Key]
        public int IslemID { get; set; }
        public string IslemAciklama { get; set; }
        public bool IslemDurum { get; set; }
        public int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
        public int? ServisID { get; set; }
        public Servis Servis { get; set; }
    }
}
