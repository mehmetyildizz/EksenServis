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
    public class KullaniciRepository : IKullaniciDal
    {
        Context c = new Context();
        public void EkleKullanici(Kullanici kullanici)
        {
            c.Add(kullanici);
            c.SaveChanges();
        }

        public void GuncelleKullanici(Kullanici kullanici)
        {
            c.Update(kullanici);
            c.SaveChanges();
        }

        public Kullanici IdDenGetirKullanici(int id)
        {
            return c.KullaniciVT.Find(id);
        }

        public List<Kullanici> ListeTumKullanici()
        {
            return c.KullaniciVT.ToList();
        }

        public void SilKullanici(Kullanici kullanici)
        {
            c.Remove(kullanici);
            c.SaveChanges();
        }
    }
}
