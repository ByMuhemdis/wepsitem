using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wepsitem.Models.siniflar;

namespace wepsitem.Controllers
{
    public class anasayfaController : Controller
    {
        // GET: ansasayfa
        context c = new context();
        public ActionResult Index()
        {
            //kutuphaneyi ekledikten sonra bunları context uzerinden c ye atıyoruz oradanda deger degişkenine listeleyip returmla döndürme işlemi yaptırıyoruz
           
            var deger = c.anasayfas.ToList();

            return View(deger);


        }

        //MVC de PartialViewResult 

        public PartialViewResult ikonlar()
        {
            var deger = c.iconlars.ToList();
            return PartialView(deger);

        }

    }
}