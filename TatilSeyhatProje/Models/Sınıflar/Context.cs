using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TatilSeyhatProje.Models.Sınıflar;
using System.Data.Entity;
    

namespace TatilSeyhatProje.Models.Sınıflar
{
    public class Context: DbContext 
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        //public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkımızda> Hakkımızdas { get; set; }
        public DbSet<İletisim> İletisims { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
    }
}