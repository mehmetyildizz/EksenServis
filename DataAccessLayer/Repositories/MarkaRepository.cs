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
    public class MarkaRepository : IMarkaDal
    {
        Context c = new Context();
        public void EkleMarka(Marka marka)
        {
            c.Add(marka);
            c.SaveChanges();
        }

        public void GuncelleMarka(Marka marka)
        {
            c.Update(marka);
            c.SaveChanges();
        }

        public Marka IdDenGetirMarka(int id)
        {
            return c.MarkaVT.Find(id);
        }

        public List<Marka> ListeTumMarka()
        {
            return c.MarkaVT.ToList();
        }

        public void SilMarka(Marka marka)
        {
            c.Remove(marka);
            c.SaveChanges();
        }
    }
}
