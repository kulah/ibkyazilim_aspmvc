using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ibkyazilim_LandingPage.DAL;
namespace ibkyazilim_LandingPage.Controllers
{        
    
    

    public class DashboardsController : Controller
    {
        public ibkyazilimContext db = new ibkyazilimContext ();
        public ActionResult Dashboard_1()
        {
            ViewBag.GeriBildirimSayisi = (db.GeriBildirims.Count());
            return View();
        }

        public ActionResult Dashboard_2()
        {
            return View();
        }

        public ActionResult Dashboard_3()
        {
            return View();
        }
        
        public ActionResult Dashboard_4()
        {
            return View();
        }
        
        public ActionResult Dashboard_4_1()
        {
            return View();
        }

        public ActionResult Dashboard_5()
        {
            return View();
        }

    }
}