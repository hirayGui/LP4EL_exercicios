using Exercicio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio1.Controllers
{
    public class TipoQuartoController : Controller
    {
        private HotelariaBDEntities db = new HotelariaBDEntities();
        // GET: TipoQuarto
        public ActionResult Index()
        {
            var tipos = db.TipoQuarto.ToList();
            return View(tipos);
        }

        public ActionResult Inserir()
        {
            return View();
        }

        public ActionResult Alterar(int id)
        {
            TipoQuarto tipo = db.TipoQuarto.Find(id);
            return View(tipo);
        }

        public ActionResult Excluir(int id)
        {
            TipoQuarto tipo = db.TipoQuarto.Find(id);
            return View(tipo);
        }

        public ActionResult ErroExcluir()
        {
            return View();
        }
    }
}