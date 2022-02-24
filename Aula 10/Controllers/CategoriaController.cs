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
            //testei os métodos apenas na view de categoria, pois, como mencionado em aula, esse tipo de validação é vulnerável
            //métodos para validação por parte do cliente
            HtmlHelper.ClientValidationEnabled = true;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true;
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