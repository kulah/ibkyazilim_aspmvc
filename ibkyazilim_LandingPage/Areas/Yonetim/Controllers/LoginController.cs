using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ibkyazilim_LandingPage.Areas.Yonetim.Models;
using ibkyazilim_LandingPage.DAL;

namespace ibkyazilim_LandingPage.Areas.Yonetim.Controllers
{
    public class LoginController : Controller
    {
        private ibkyazilimContext db = new ibkyazilimContext();

        // GET: Yonetim/Login
        public ActionResult Index()
        {
            return View(db.AccountControls.ToList());
        }

        // GET: Yonetim/Login/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountControl accountControl = db.AccountControls.Find(id);
            if (accountControl == null)
            {
                return HttpNotFound();
            }
            return View(accountControl);
        }

        // GET: Yonetim/Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Yonetim/Login/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DURUM,AD,SOYAD,KULLANICIADI,PAROLA,EMAIL,ADMIN,ETAR,DTAR,CEVRIMICIMI")] AccountControl accountControl)
        {
            if (ModelState.IsValid)
            {
                db.AccountControls.Add(accountControl);
                db.SaveChanges();
                //return RedirectToAction("Index");
                return Json(new { success = true });
            }

            return View(accountControl);
        }

        // GET: Yonetim/Login/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountControl accountControl = db.AccountControls.Find(id);
            if (accountControl == null)
            {
                return HttpNotFound();
            }
            return View(accountControl);
        }

        // POST: Yonetim/Login/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DURUM,AD,SOYAD,KULLANICIADI,PAROLA,EMAIL,ADMIN,ETAR,DTAR,CEVRIMICIMI")] AccountControl accountControl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accountControl).State = EntityState.Modified;
                db.SaveChanges();
                //return RedirectToAction("Index");
                return Json(new { success = true });
            }
            return View(accountControl);
        }

        // GET: Yonetim/Login/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountControl accountControl = db.AccountControls.Find(id);
            if (accountControl == null)
            {
                return HttpNotFound();
            }
            return View(accountControl);
        }

        // POST: Yonetim/Login/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AccountControl accountControl = db.AccountControls.Find(id);
            db.AccountControls.Remove(accountControl);
            db.SaveChanges();
            //return RedirectToAction("Index");
            return Json(new { success = true });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
