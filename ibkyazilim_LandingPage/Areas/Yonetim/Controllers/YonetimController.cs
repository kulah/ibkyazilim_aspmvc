using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ibkyazilim_LandingPage.DAL;
namespace ibkyazilim_LandingPage.Areas.Yonetim.Controllers
{
    public class YonetimController : Controller
    {
        public ibkyazilimContext db = new ibkyazilimContext ();
        // GET: Yonetim/Yonetim
        public ActionResult Index()
        {
            ViewBag.GeriBildirimSayisi = (db.GeriBildirims.Count());
            return View();
        }
    }
}