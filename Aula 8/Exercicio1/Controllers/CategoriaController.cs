using Exercicio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio1.Controllers
{
    public class CategoriaController : Controller
    {
        private HotelariaBDEntities db = new HotelariaBDEntities();
        // GET: Categoria
        public ActionResult Index()
        {
            var categorias = db.Categoria.ToList();
            return View(categorias);
        }

        public ActionResult Inserir()
        {
            return View();
        }

        public ActionResult Alterar(int id)
        {
            Categoria categoria = db.Categoria.Find(id);
            return View(categoria);

        }

        public ActionResult Excluir(int id)
        {
            Categoria categoria = db.Categoria.Find(id);
            return View(categoria);
        }

        public ActionResult ErroExcluir()
        {
            return View();
        }
    }
}