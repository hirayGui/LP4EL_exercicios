using Exercicio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Exercicio1.Controllers
{
    [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
    public class EstabelecimentoController : Controller
    {
        private HotelariaBDEntities db = new HotelariaBDEntities();
        // GET: Estabelecimento
        public ActionResult Index()
        {
            var estabelecimentos = db.Estabelecimento.Include("Categoria").Include("Cidade").ToList();
            return View(estabelecimentos);
        }

        public ActionResult Inserir()
        {
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao");
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome");
            return View();
        }

        public ActionResult Alterar(int id)
        {
            Estabelecimento estabelecimento = db.Estabelecimento.Find(id);
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao", estabelecimento.IdCategoria);
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome", estabelecimento.IdCidade);
            return View(estabelecimento);
        }

        public ActionResult Excluir(int id)
        {
            Estabelecimento estabelecimento = db.Estabelecimento.Find(id);
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao", estabelecimento.IdCategoria);
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome", estabelecimento.IdCidade);
            return View(estabelecimento);
        }

        public ActionResult ErroExcluir()
        {
            return View();
        }
    }
}