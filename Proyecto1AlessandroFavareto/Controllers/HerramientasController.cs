using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyecto1AlessandroFavareto.Data;
using Proyecto1AlessandroFavareto.Models;

namespace Proyecto1AlessandroFavareto.Controllers
{
    public class HerramientasController : Controller
    {
        private Proyecto1AlessandroFavaretoContext db = new Proyecto1AlessandroFavaretoContext();

        // GET: Herramientas
        public ActionResult Index()
        {
            return View(db.Herramientas.ToList());
        }

        // GET: Herramientas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Herramientas herramientas = db.Herramientas.Find(id);
            if (herramientas == null)
            {
                return HttpNotFound();
            }
            return View(herramientas);
        }

        // GET: Herramientas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Herramientas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,descripcion,fechaPrestamo,fechaDevolver")] Herramientas herramientas)
        {
            if (ModelState.IsValid)
            {
                db.Herramientas.Add(herramientas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(herramientas);
        }

        // GET: Herramientas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Herramientas herramientas = db.Herramientas.Find(id);
            if (herramientas == null)
            {
                return HttpNotFound();
            }
            return View(herramientas);
        }

        // POST: Herramientas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,descripcion,fechaPrestamo,fechaDevolver")] Herramientas herramientas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(herramientas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(herramientas);
        }

        // GET: Herramientas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Herramientas herramientas = db.Herramientas.Find(id);
            if (herramientas == null)
            {
                return HttpNotFound();
            }
            return View(herramientas);
        }

        // POST: Herramientas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Herramientas herramientas = db.Herramientas.Find(id);
            db.Herramientas.Remove(herramientas);
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
