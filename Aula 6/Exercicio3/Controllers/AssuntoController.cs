using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Forum.Models;

namespace Forum.Controllers
{
    public class AssuntoController : Controller
    {
        private ForumContexto db = new ForumContexto();

        // GET: Assunto
        public ActionResult Index()
        {
            return View(db.Assunto.ToList());
        }

        // GET: Assunto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assunto assunto = db.Assunto.Find(id);
            if (assunto == null)
            {
                return HttpNotFound();
            }
            return View(assunto);
        }

        // GET: Assunto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assunto/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAssunto,Titulo,Descricao")] Assunto assunto)
        {
            if (ModelState.IsValid)
            {
                db.Assunto.Add(assunto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(assunto);
        }

        // GET: Assunto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assunto assunto = db.Assunto.Find(id);
            if (assunto == null)
            {
                return HttpNotFound();
            }
            return View(assunto);
        }

        // POST: Assunto/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdAssunto,Titulo,Descricao")] Assunto assunto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assunto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assunto);
        }

        // GET: Assunto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assunto assunto = db.Assunto.Find(id);
            if (assunto == null)
            {
                return HttpNotFound();
            }
            return View(assunto);
        }

        // POST: Assunto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Assunto assunto = db.Assunto.Find(id);
            db.Assunto.Remove(assunto);
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
