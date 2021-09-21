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
    public class IslemRepository : IIslemDal
    {
        Context c = new Context();
        public void EkleIslem(Islem islem)
        {
            c.Add(islem);
            c.SaveChanges();
        }

        public void GuncelleIslem(Islem islem)
        {
            c.Update(islem);
            c.SaveChanges();
        }

        public Islem IdDenGetirIslem(int id)
        {
            return c.IslemVT.Find(id);
        }

        public List<Islem> ListeTumIslem()
        {
            return c.IslemVT.ToList();
        }

        public void SilIslem(Islem islem)
        {
            c.Remove(islem);
            c.SaveChanges();
        }
    }
}
