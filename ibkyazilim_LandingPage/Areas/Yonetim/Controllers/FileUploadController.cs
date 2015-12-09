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
    public class FileUploadController : Controller
    {
        private ibkyazilimContext db = new ibkyazilimContext();

        // GET: Yonetim/FileUpload
        public ActionResult Index()
        {
            return View(db.FileUploads.ToList());
        }

        // GET: Yonetim/FileUpload/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FileUpload fileUpload = db.FileUploads.Find(id);
            if (fileUpload == null)
            {
                return HttpNotFound();
            }
            return View(fileUpload);
        }

        // GET: Yonetim/FileUpload/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Yonetim/FileUpload/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DURUM,FILETYPE,FILEFORMAT,FILENAME,FILE")] FileUpload fileUpload)
        {
            if (ModelState.IsValid)
            {
                db.FileUploads.Add(fileUpload);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fileUpload);
        }

        // GET: Yonetim/FileUpload/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FileUpload fileUpload = db.FileUploads.Find(id);
            if (fileUpload == null)
            {
                return HttpNotFound();
            }
            return View(fileUpload);
        }

        // POST: Yonetim/FileUpload/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DURUM,FILETYPE,FILEFORMAT,FILENAME,FILE")] FileUpload fileUpload)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fileUpload).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fileUpload);
        }

        // GET: Yonetim/FileUpload/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FileUpload fileUpload = db.FileUploads.Find(id);
            if (fileUpload == null)
            {
                return HttpNotFound();
            }
            return View(fileUpload);
        }

        // POST: Yonetim/FileUpload/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FileUpload fileUpload = db.FileUploads.Find(id);
            db.FileUploads.Remove(fileUpload);
            db.SaveChanges();
            return RedirectToAction("Index");
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
