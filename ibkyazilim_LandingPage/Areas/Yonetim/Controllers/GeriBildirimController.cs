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
    public class GeriBildirimController : Controller
    {
        public ibkyazilimContext db = new ibkyazilimContext();
        // GET: Yonetim/GeriBildirim
        public ActionResult Index()
        {
            ViewBag.GeriBildirimSayisi = (db.GeriBildirims.Count());
            return View(db.GeriBildirims.ToList());
        }

        // GET: Yonetim/GeriBildirim/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GeriBildirim geriBildirim = db.GeriBildirims.Find(id);
            if (geriBildirim == null)
            {
                return HttpNotFound();
            }
            ViewBag.GeriBildirimSayisi = (db.GeriBildirims.Count());
            //return PartialView("Details", "Details");
            return View(geriBildirim);
        }

        // GET: Yonetim/GeriBildirim/Create
        public ActionResult Create()
        {
            ViewBag.GeriBildirimSayisi = (db.GeriBildirims.Count());
            return View();
        }

        // POST: Yonetim/GeriBildirim/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,adisoyadi,email,konu,iletilenmesaj")] GeriBildirim geriBildirim)
        {
            if (ModelState.IsValid)
            {
                db.GeriBildirims.Add(geriBildirim);
                db.SaveChanges();
                //return RedirectToAction("Index");
                return Json(new { success = true });
            }

            return View(geriBildirim);
        }

        // GET: Yonetim/GeriBildirim/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GeriBildirim geriBildirim = db.GeriBildirims.Find(id);
            if (geriBildirim == null)
            {

                return HttpNotFound();
            }
            ViewBag.GeriBildirimSayisi = (db.GeriBildirims.Count());
            return View(geriBildirim);
        }

        // POST: Yonetim/GeriBildirim/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,adisoyadi,email,konu,iletilenmesaj")] GeriBildirim geriBildirim)
        {
            if (ModelState.IsValid)
            {
                db.Entry(geriBildirim).State = EntityState.Modified;
                db.SaveChanges();
                //return RedirectToAction("Index");
                return Json(new { success = true });

            }
            ViewBag.GeriBildirimSayisi = (db.GeriBildirims.Count());
            return View(geriBildirim);
        }

        // GET: Yonetim/GeriBildirim/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GeriBildirim geriBildirim = db.GeriBildirims.Find(id);
            if (geriBildirim == null)
            {
                return HttpNotFound();
            }
            ViewBag.GeriBildirimSayisi = (db.GeriBildirims.Count());
            return View(geriBildirim);
        }

        // POST: Yonetim/GeriBildirim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GeriBildirim geriBildirim = db.GeriBildirims.Find(id);
            db.GeriBildirims.Remove(geriBildirim);
            db.SaveChanges();
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
