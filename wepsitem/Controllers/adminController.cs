using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wepsitem.Models.siniflar;

namespace wepsitem.Controllers
{
    public class adminController : Controller
    {


        // GET: admin
        context c = new context();

        [Authorize]
        public ActionResult Index()
        {
            var deger = c.anasayfas.ToList();
            return View(deger);
        }

        public ActionResult anasayfagetir(int id)
        {
            var getir = c.anasayfas.Find(id);
            return View("anasayfagetir", getir);
        }

        public ActionResult anasayfaguncelle(anasayfa p)
        {
            var gnc = c.anasayfas.Find(p.id);
            gnc.isim = p.isim;
            gnc.iletisim = p.iletisim;
            gnc.acıklama = p.acıklama;
            gnc.unvan = p.unvan;

            if (Request.Files.Count > 0)
            {
                string dosyaadı = Path.GetFileName(Request.Files[0].FileName);
                string uzantı = Path.GetExtension(Request.Files[0].FileName);
                string yol = "/resimler/" + dosyaadı + uzantı;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                p.profil = "/resimler/" + dosyaadı + uzantı;

            }
            gnc.profil = p.profil;
            c.SaveChanges();
            return RedirectToAction("Index");


        }
        public ActionResult sil(int id)
        {
            var admin = c.anasayfas.Find(id);
            c.anasayfas.Remove(admin);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult iconlarim()
        {

            var deger = c.iconlars.ToList();

            return View(deger);
        }


        //public PartialViewResult iconlarim()
        //{

        //    var deger = c.iconlars.ToList();

        //    return PartialView(deger);
        //}

        //yeni ikonlar eklemek icin bazı kodlar asagıda bulunmaktadır


        [HttpGet] //sayfa yüklendiginde bunun aşagısındaki çalışşın demek

        public ActionResult YeniIkon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniIkon(iconlar p)
        {
            c.iconlars.Add(p);
            c.SaveChanges();
            return RedirectToAction("iconlarim");
        }

        //güncelleme işlemi ikonlar

        public ActionResult ikonGetir(int id)
        {

            var ig=c.iconlars.Find(id);
            return View("ikonGetir", ig);


        }

        public ActionResult ikonGuncelle(iconlar x)
        {
            var ig = c.iconlars.Find(x.id);
            ig.icon=x.icon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("iconlarim");

        }

        public ActionResult ikonsil(int id)
        {
            var sil =c.iconlars.Find(id);
            c.iconlars.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("iconlarim");
        }
    }
}