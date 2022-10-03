using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace wepsitem.Models.siniflar
{
    public class context:DbContext
    {
        public DbSet<admingiris> admingiriss {  get; set; }
        public DbSet<anasayfa> anasayfas {  get; set; }
        public DbSet<iconlar> iconlars {  get; set; }
     
      
    }
}