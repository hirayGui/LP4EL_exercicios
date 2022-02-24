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
    public class EstabelecimentoController : Controller
    {
        private HotelariaBDEntities db = new HotelariaBDEntities();

        // GET: Estabelecimento
        public ActionResult Index()
        {
            var estabelecimento = db.Estabelecimento.Include(e => e.Categoria).Include(e => e.Cidade);
            return View(estabelecimento.ToList());
        }

        // GET: Estabelecimento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimento = db.Estabelecimento.Find(id);
            if (estabelecimento == null)
            {
                return HttpNotFound();
            }
            return View(estabelecimento);
        }

        // GET: Estabelecimento/Create
        public ActionResult Create()
        {
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao");
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome");
            return View();
        }

        // POST: Estabelecimento/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEstabelecimento,NomeComercial,CNPJ,Endereco,Telefone,PaginaWeb,IdCidade,IdCategoria")] Estabelecimento estabelecimento)
        {
            if (ModelState.IsValid)
            {
                db.Estabelecimento.Add(estabelecimento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao", estabelecimento.IdCategoria);
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome", estabelecimento.IdCidade);
            return View(estabelecimento);
        }

        // GET: Estabelecimento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimento = db.Estabelecimento.Find(id);
            if (estabelecimento == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao", estabelecimento.IdCategoria);
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome", estabelecimento.IdCidade);
            return View(estabelecimento);
        }

        // POST: Estabelecimento/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEstabelecimento,NomeComercial,CNPJ,Endereco,Telefone,PaginaWeb,IdCidade,IdCategoria")] Estabelecimento estabelecimento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estabelecimento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao", estabelecimento.IdCategoria);
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome", estabelecimento.IdCidade);
            return View(estabelecimento);
        }

        // GET: Estabelecimento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimento = db.Estabelecimento.Find(id);
            if (estabelecimento == null)
            {
                return HttpNotFound();
            }
            return View(estabelecimento);
        }

        // POST: Estabelecimento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estabelecimento estabelecimento = db.Estabelecimento.Find(id);
            db.Estabelecimento.Remove(estabelecimento);
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
