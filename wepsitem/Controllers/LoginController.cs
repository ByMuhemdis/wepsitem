using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using wepsitem.Models.siniflar;

namespace wepsitem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        context c = new context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(admingiris ad)
        {
            var bilgiler = c.admingiriss.FirstOrDefault(x => x.kullaniciadi == ad.kullaniciadi && x.sifre == ad.sifre);

            if (bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.kullaniciadi, false);
                Session["kullaniciadi"]=bilgiler.kullaniciadi.ToString();
                return RedirectToAction("Index","admin");
                    
                

            }
            else
            {
                return View();
            }

        
        }

        public ActionResult cıkısyap()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Login");

        }
    }
} 