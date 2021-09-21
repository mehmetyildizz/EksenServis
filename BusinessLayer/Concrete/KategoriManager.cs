using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    class KategoriManager : IKategoriService
    {
        EfKategoriRepository efKategoriRepository;

        public KategoriManager()
        {
            efKategoriRepository = new EfKategoriRepository();
        }

        public void EkleKategori(Kategori kategori)
        {
            efKategoriRepository.Ekle(kategori);
        }

        public void GuncelleKategori(Kategori kategori)
        {
            efKategoriRepository.Guncelle(kategori);
        }

        public Kategori IdDenGetirKategori(int id)
        {
            return efKategoriRepository.IdDenGetir(id);
        }

        public List<Kategori> ListeTumKategori()
        {
            return efKategoriRepository.TumListeGetir();
        }

        public void SilKategori(Kategori kategori)
        {
            efKategoriRepository.Sil(kategori);
        }
    }
}
