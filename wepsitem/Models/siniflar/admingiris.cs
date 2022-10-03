using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wepsitem.Models.siniflar
{
    public class admingiris
    {
        [Key]
        public int id { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
    }
}