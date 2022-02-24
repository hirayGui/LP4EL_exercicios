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
    public class HomeController : Controller
    {
        private HotelariaBDEntities db = new HotelariaBDEntities();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Categoria = new SelectList(db.Categoria, "IdCategoria", "Descricao");
            ViewBag.Cidade = new SelectList(db.Cidade, "IdCidade", "Nome", "UF");
            return View();
        }

        public ActionResult Pesquisar(Pesquisa pesquisa)
        {
            var estabelecimentos = from e in db.Estabelecimento
                                   where e.IdCategoria == pesquisa.IdCategoria && e.IdCidade == pesquisa.IdCidade
                                   select new ResultadoPesquisa
                                   {
                                       NomeComercial = e.NomeComercial,
                                       CNPJ = e.CNPJ,
                                       Endereco = e.Endereco,
                                       Telefone = e.Telefone,
                                       Site = e.PaginaWeb
                                   };

            return Json(estabelecimentos, JsonRequestBehavior.AllowGet);
        }
    }
}