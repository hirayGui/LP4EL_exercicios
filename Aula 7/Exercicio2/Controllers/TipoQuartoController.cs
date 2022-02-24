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
    public class TipoQuartoController : Controller
    {
        private HotelariaBDEntities db = new HotelariaBDEntities();

        // GET: TipoQuarto
        public ActionResult Index()
        {
            return View(db.TipoQuarto.ToList());
        }

        // GET: TipoQuarto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoQuarto tipoQuarto = db.TipoQuarto.Find(id);
            if (tipoQuarto == null)
            {
                return HttpNotFound();
            }
            return View(tipoQuarto);
        }

        // GET: TipoQuarto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoQuarto/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTipoQuarto,Descricao,ValorDiaria,CafeManha")] TipoQuarto tipoQuarto)
        {
            if (ModelState.IsValid)
            {
                db.TipoQuarto.Add(tipoQuarto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoQuarto);
        }

        // GET: TipoQuarto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoQuarto tipoQuarto = db.TipoQuarto.Find(id);
            if (tipoQuarto == null)
            {
                return HttpNotFound();
            }
            return View(tipoQuarto);
        }

        // POST: TipoQuarto/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTipoQuarto,Descricao,ValorDiaria,CafeManha")] TipoQuarto tipoQuarto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoQuarto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoQuarto);
        }

        // GET: TipoQuarto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoQuarto tipoQuarto = db.TipoQuarto.Find(id);
            if (tipoQuarto == null)
            {
                return HttpNotFound();
            }
            return View(tipoQuarto);
        }

        // POST: TipoQuarto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoQuarto tipoQuarto = db.TipoQuarto.Find(id);
            db.TipoQuarto.Remove(tipoQuarto);
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
