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
    public class ColaboladorsController : Controller
    {
        private Proyecto1AlessandroFavaretoContext db = new Proyecto1AlessandroFavaretoContext();

        // GET: Colaboladors
        public ActionResult Index()
        {
            return View(db.Colaboladors.ToList());
        }

        // GET: Colaboladors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colabolador colabolador = db.Colaboladors.Find(id);
            if (colabolador == null)
            {
                return HttpNotFound();
            }
            return View(colabolador);
        }

        // GET: Colaboladors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Colaboladors/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,apellidos,fechaRegistro,estado,cantidadHerramientas")] Colabolador colabolador)
        {
            if (ModelState.IsValid)
            {
                db.Colaboladors.Add(colabolador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(colabolador);
        }

        // GET: Colaboladors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colabolador colabolador = db.Colaboladors.Find(id);
            if (colabolador == null)
            {
                return HttpNotFound();
            }
            return View(colabolador);
        }

        // POST: Colaboladors/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,apellidos,fechaRegistro,estado,cantidadHerramientas")] Colabolador colabolador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(colabolador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(colabolador);
        }

        // GET: Colaboladors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colabolador colabolador = db.Colaboladors.Find(id);
            if (colabolador == null)
            {
                return HttpNotFound();
            }
            return View(colabolador);
        }

        // POST: Colaboladors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Colabolador colabolador = db.Colaboladors.Find(id);
            db.Colaboladors.Remove(colabolador);
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
