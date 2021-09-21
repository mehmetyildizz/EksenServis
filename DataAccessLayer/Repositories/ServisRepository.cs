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
    public class ServisRepository : IServisDal
    {
        Context c = new Context();
        public void EkleServis(Servis servis)
        {
            c.Add(servis);
            c.SaveChanges();
        }

        public void GuncelleServis(Servis servis)
        {
            c.Update(servis);
            c.SaveChanges();
        }

        public Servis IdDenGetirServis(int id)
        {
            return c.ServisVT.Find(id);
        }

        public List<Servis> ListeTumServis()
        {
            return c.ServisVT.ToList();
        }

        public void SilServis(Servis servis)
        {
            c.Remove(servis);
            c.SaveChanges();
        }
    }
}
