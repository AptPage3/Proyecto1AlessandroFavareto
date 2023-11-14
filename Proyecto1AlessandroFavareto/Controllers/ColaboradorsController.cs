using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyecto1AlessandroFavareto.Data;
using Proyecto1AlessandroFavareto.Models;
using System.Windows;

namespace Proyecto1AlessandroFavareto.Controllers
{
    public class ColaboradorsController : Controller
    {
        private Proyecto1AlessandroFavaretoContext db = new Proyecto1AlessandroFavaretoContext();

        // GET: Colaboradors
        public ActionResult Index()
        {
            return View(db.Colaboladors.ToList());
        }

        // GET: Colaboradors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colaborador colaborador = db.Colaboladors.Find(id);
            if (colaborador == null)
            {
                return HttpNotFound();
            }
            return View(colaborador);
        }

        // GET: Colaboradors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Colaboradors/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Colaborador colabolador)
        {
            var x = db.Colaboladors.FirstOrDefault(t => t.Cedula == colabolador.Cedula);

            if (x != null)
            {
                MessageBox.Show("Esa cédula ya esta registrada");
                return RedirectToAction("Create");
            }
            else
            {
                
                SqlConnection conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Proyecto1AlessandroFavaretoContext-20231107233909;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Colaboradors(Cedula, Nombre, Apellidos, CantidadHerramientas) VALUES (@param1, @param2, @param3,@param4);", conexion))
                {
                    cmd.Parameters.AddWithValue("@param1", colabolador.Cedula);
                    cmd.Parameters.AddWithValue("@param2", colabolador.Nombre);
                    cmd.Parameters.AddWithValue("@param3", colabolador.Apellidos);
                    cmd.Parameters.AddWithValue("@param4", 0);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Los datos se guardaron correctamente");

                return RedirectToAction("Index","Home");
            }


        }

        // GET: Colaboradors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colaborador colaborador = db.Colaboladors.Find(id);
            if (colaborador == null)
            {
                return HttpNotFound();
            }
            return View(colaborador);
        }

        // POST: Colaboradors/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Cedula,Nombre,Apellidos,CantidadHerramientas")] Colaborador colaborador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(colaborador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(colaborador);
        }

        // GET: Colaboradors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colaborador colaborador = db.Colaboladors.Find(id);
            if (colaborador == null)
            {
                return HttpNotFound();
            }
            return View(colaborador);
        }

        // POST: Colaboradors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Colaborador colaborador = db.Colaboladors.Find(id);
            db.Colaboladors.Remove(colaborador);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Ingresar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ingresar(int? id)
        {
            var conexion = db.Colaboladors.FirstOrDefault(t => t.Cedula == id);

            if (conexion != null)
            {
                return RedirectToAction("Index","Herramientas");
            }
            else
            {
                MessageBox.Show("Los datos ingresados no son correctos");
                return RedirectToAction("Ingresar"); 
            }
            
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
