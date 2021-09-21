using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=EksenServisDB;integrated security=true;");
        }
        public DbSet<Islem> IslemVT { get; set; }
        public DbSet<Kategori> KategoriVT { get; set; }
        public DbSet<Kullanici> KullaniciVT { get; set; }
        public DbSet<Marka> MarkaVT { get; set; }
        public DbSet<Musteri> MusteriVT { get; set; }
        public DbSet<Servis> ServisVT { get; set; }
    }
}