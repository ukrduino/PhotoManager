using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhotoManager.Models;

namespace PhotoManager.Controllers
{
    public class PhotoesController : Controller
    {
        private PhotoManagerDbContext db = new PhotoManagerDbContext();

        public ActionResult Index()
        {
            return View(db.Photoes.ToList());
        }

        // GET: /Photoes/Details/5
        public ActionResult Details(int id = 0)
        {
            PhotoModel photo = db.Photoes.Find(id);
            if (photo == null)
            {
                return HttpNotFound();
            }
            return View(photo);
        }

        // GET: /Photoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Products/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PhotoModel photo)
        {
            if (ModelState.IsValid)
            {
                db.Photoes.Add(photo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(photo);
        }

        // GET: /Products/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PhotoModel photo = db.Photoes.Find(id);
            if (photo == null)
            {
                return HttpNotFound();
            }
            return View(photo);
        }

        //
        // POST: /Products/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PhotoModel photo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(photo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(photo);
        }


        // GET: /Products/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PhotoModel photo = db.Photoes.Find(id);
            if (photo == null)
            {
                return HttpNotFound();
            }
            return View(photo);
        }

        // POST: /Products/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PhotoModel photo = db.Photoes.Find(id);
            db.Photoes.Remove(photo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}