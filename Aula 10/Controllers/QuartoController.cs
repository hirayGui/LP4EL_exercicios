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
    public class QuartoController : Controller
    {
        private HotelariaBDEntities db = new HotelariaBDEntities();
        // GET: Quarto
        public ActionResult Index()
        {
            var quartos = db.Quarto.Include("TipoQuarto").Include("Estabelecimento").ToList();
            return View(quartos);
        }

        public ActionResult Inserir()
        {
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "NomeComercial");
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao");
            return View();
        }

        public ActionResult Alterar(int id)
        {
            Quarto quartos = db.Quarto.Find(id);
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "NomeComercial", quartos.IdEstabelecimento);
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao", quartos.IdTipoQuarto);
            return View(quartos);
        }

        public ActionResult Excluir(int id)
        {
            Quarto quartos = db.Quarto.Find(id);
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "NomeComercial", quartos.IdEstabelecimento);
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao", quartos.IdTipoQuarto);
            return View(quartos);
        }

        public ActionResult ErroExcluir()
        {
            return View();
        }

        public ActionResult VerificaSeNumeroQuartoNaoExiste(int IdEstabelecimento, int NumeroQuarto)
        {
            var quarto = db.Quarto.Where(q => q.NumeroQuarto == NumeroQuarto && q.IdEstabelecimento == IdEstabelecimento).FirstOrDefault();

            if(quarto != null)
                return Json(false, JsonRequestBehavior.AllowGet);
            else
                return Json(true, JsonRequestBehavior.AllowGet);

        }
    }
}