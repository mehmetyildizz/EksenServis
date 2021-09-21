using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IKategoriService
    {
        List<Kategori> ListeTumKategori();
        void EkleKategori(Kategori kategori);
        void SilKategori(Kategori kategori);
        void GuncelleKategori(Kategori kategori);
        Kategori IdDenGetirKategori(int id);
    }
}
