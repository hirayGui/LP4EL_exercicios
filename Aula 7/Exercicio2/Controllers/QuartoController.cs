using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Exercicio1.Models;

namespace Exercicio1.Controllers
{
    public class QuartoController : Controller
    {
        private HotelariaBDEntities db = new HotelariaBDEntities();

        // GET: Quarto
        public ActionResult Index()
        {
            var quarto = db.Quarto.Include(q => q.Estabelecimento).Include(q => q.TipoQuarto);
            return View(quarto.ToList());
        }

        // GET: Quarto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quarto quarto = db.Quarto.Find(id);
            if (quarto == null)
            {
                return HttpNotFound();
            }
            return View(quarto);
        }

        // GET: Quarto/Create
        public ActionResult Create()
        {
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "NomeComercial");
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao");
            return View();
        }

        // POST: Quarto/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdQuarto,NumeroQuarto,Disponivel,IdEstabelecimento,IdTipoQuarto")] Quarto quarto)
        {
            if (ModelState.IsValid)
            {
                db.Quarto.Add(quarto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "NomeComercial", quarto.IdEstabelecimento);
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao", quarto.IdTipoQuarto);
            return View(quarto);
        }

        // GET: Quarto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quarto quarto = db.Quarto.Find(id);
            if (quarto == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "NomeComercial", quarto.IdEstabelecimento);
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao", quarto.IdTipoQuarto);
            return View(quarto);
        }

        // POST: Quarto/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdQuarto,NumeroQuarto,Disponivel,IdEstabelecimento,IdTipoQuarto")] Quarto quarto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quarto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "NomeComercial", quarto.IdEstabelecimento);
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao", quarto.IdTipoQuarto);
            return View(quarto);
        }

        // GET: Quarto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quarto quarto = db.Quarto.Find(id);
            if (quarto == null)
            {
                return HttpNotFound();
            }
            return View(quarto);
        }

        // POST: Quarto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Quarto quarto = db.Quarto.Find(id);
            db.Quarto.Remove(quarto);
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
