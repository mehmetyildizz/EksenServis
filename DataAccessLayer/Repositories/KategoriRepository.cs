using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class KategoriRepository : IKategoriDal
    {
        Context c = new Context();
        public void EkleKategori(Kategori kategori)
        {
            c.Add(kategori);
            c.SaveChanges();
        }

        public void GuncelleKategori(Kategori kategori)
        {
            c.Update(kategori);
            c.SaveChanges();
        }

        public Kategori IdDenGetirKategori(int id)
        {
            return c.KategoriVT.Find(id);
        }

        public List<Kategori> ListeTumKategori()
        {
            return c.KategoriVT.ToList();
        }

        public void SilKategori(Kategori kategori)
        {
            c.Remove(kategori);
            c.SaveChanges();
        }
    }
}
