using Exercicio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio1.Controllers
{
    public class CidadeController : Controller
    {
        private HotelariaBDEntities db = new HotelariaBDEntities();
        // GET: Cidade
        public ActionResult Index()
        {
            var cidades = db.Cidade.ToList();
            return View(cidades);
        }

        public ActionResult Inserir()
        {
            return View();
        }

        public ActionResult Alterar(int id)
        {
            Cidade cidade = db.Cidade.Find(id);
            return View(cidade);
        }

        public ActionResult Excluir(int id)
        {
            Cidade cidade = db.Cidade.Find(id);
            return View(cidade);
        }

        public ActionResult ErroExcluir()
        {
            return View();
        }

    }
}