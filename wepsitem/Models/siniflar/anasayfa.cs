using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wepsitem.Models.siniflar
{
    public class anasayfa
    {

        [Key]
        
        
        public int  id { get; set; }
        public string profil { get; set; }
        public string isim { get; set; }
        public string  unvan { get; set; }
        public string acıklama { get; set; }
        public string iletisim { get; set; }
    }
}