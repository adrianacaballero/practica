using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mvcPractica.Models;

namespace mvcPractica.Controllers
{
    public class PracticasController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Practicas
        public ActionResult Index()
        {
            return View(db.Practicas.ToList());
        }

        // GET: Practicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Practica practica = db.Practicas.Find(id);
            if (practica == null)
            {
                return HttpNotFound();
            }
            return View(practica);
        }

        // GET: Practicas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Practicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PhoneID,Name,Type,Contact")] Practica practica)
        {
            if (ModelState.IsValid)
            {
                db.Practicas.Add(practica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(practica);
        }

        // GET: Practicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Practica practica = db.Practicas.Find(id);
            if (practica == null)
            {
                return HttpNotFound();
            }
            return View(practica);
        }

        // POST: Practicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PhoneID,Name,Type,Contact")] Practica practica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(practica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(practica);
        }

        // GET: Practicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Practica practica = db.Practicas.Find(id);
            if (practica == null)
            {
                return HttpNotFound();
            }
            return View(practica);
        }

        // POST: Practicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Practica practica = db.Practicas.Find(id);
            db.Practicas.Remove(practica);
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
