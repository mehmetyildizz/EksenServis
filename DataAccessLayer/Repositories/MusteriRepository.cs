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
    public class MusteriRepository : IMusteriDal
    {
        Context c = new Context();
        public void EkleMusteri(Musteri musteri)
        {
            c.Add(musteri);
            c.SaveChanges();
        }

        public void GuncelleMusteri(Musteri musteri)
        {
            c.Update(musteri);
            c.SaveChanges();
        }

        public Musteri IdDenGetirMusteri(int id)
        {
            return c.MusteriVT.Find(id);
        }

        public List<Musteri> ListeTumMusteri()
        {
            return c.MusteriVT.ToList();
        }

        public void SilMusteri(Musteri musteri)
        {
            c.Remove(musteri);
            c.SaveChanges();
        }
    }
}
