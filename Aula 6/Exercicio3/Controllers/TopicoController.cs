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
    public class TopicoController : Controller
    {
        private ForumContexto db = new ForumContexto();

        // GET: Topico
        public ActionResult Index()
        {
            var topico = db.Topico.Include(t => t.Assunto);
            return View(topico.ToList());
        }

        // GET: Topico/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Topico topico = db.Topico.Find(id);
            if (topico == null)
            {
                return HttpNotFound();
            }
            return View(topico);
        }

        // GET: Topico/Create
        public ActionResult Create()
        {
            ViewBag.IdAssunto = new SelectList(db.Assunto, "IdAssunto", "Titulo");
            return View();
        }

        // POST: Topico/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTopico,Titulo,Resumo,Conteudo,DataPostagem,IdAssunto")] Topico topico)
        {
            if (ModelState.IsValid)
            {
                db.Topico.Add(topico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdAssunto = new SelectList(db.Assunto, "IdAssunto", "Titulo", topico.IdAssunto);
            return View(topico);
        }

        // GET: Topico/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Topico topico = db.Topico.Find(id);
            if (topico == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdAssunto = new SelectList(db.Assunto, "IdAssunto", "Titulo", topico.IdAssunto);
            return View(topico);
        }

        // POST: Topico/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTopico,Titulo,Resumo,Conteudo,DataPostagem,IdAssunto")] Topico topico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(topico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdAssunto = new SelectList(db.Assunto, "IdAssunto", "Titulo", topico.IdAssunto);
            return View(topico);
        }

        // GET: Topico/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Topico topico = db.Topico.Find(id);
            if (topico == null)
            {
                return HttpNotFound();
            }
            return View(topico);
        }

        // POST: Topico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Topico topico = db.Topico.Find(id);
            db.Topico.Remove(topico);
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
