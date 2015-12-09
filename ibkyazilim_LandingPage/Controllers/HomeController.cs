using ibkyazilim_LandingPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using ibkyazilim_LandingPage.Areas.Yonetim.Models;
using ibkyazilim_LandingPage.DAL;

namespace ibkyazilim_LandingPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        //public ActionResult Index(IletisimModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var body = new StringBuilder();
        //        body.AppendLine("İsim: " + model.adisoyadi);
        //        body.AppendLine("Eposta: " + model.email);
        //        body.AppendLine("Konu: " + model.iletilenmesaj);
        //        Gmail.SendMail(body.ToString());
        //        ViewBag.Success = true;
        //    }
        //    return View();
        //}

        public ActionResult Index([Bind(Include = "id,adisoyadi,email,konu,iletilenmesaj")] GeriBildirim geriBildirim)
        {
            if (ModelState.IsValid)
            {
                var body = new StringBuilder();
                body.AppendLine("İsim: " + geriBildirim.adisoyadi);
                body.AppendLine("Eposta: " + geriBildirim.email);
                body.AppendLine("Konu: " + geriBildirim.konu);
                body.AppendLine("İletilen Mesaj: " + geriBildirim.iletilenmesaj);
                Gmail.SendMail(body.ToString());
                ViewBag.Success = true;
            }
            
            ibkyazilimContext db=new ibkyazilimContext();
            if (ModelState.IsValid)
            {
                db.GeriBildirims.Add(geriBildirim);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}