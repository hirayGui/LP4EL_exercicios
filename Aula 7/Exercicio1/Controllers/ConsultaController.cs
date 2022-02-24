using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Clinica.Models;

namespace Clinica.Controllers
{
    public class ConsultaController : Controller
    {
        private ModeloDeDadosContainer db = new ModeloDeDadosContainer();

        // GET: Consulta
        public ActionResult Index()
        {
            var consulta = db.Consulta.Include(c => c.Medico).Include(c => c.Paciente);
            return View(consulta.ToList());
        }

        // GET: Consulta/Details/5
        public ActionResult Details(int? IdMedico, int? IdPaciente)
        {
            if (IdMedico == null || IdPaciente == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consulta consulta = db.Consulta.Find(IdMedico, IdPaciente);
            if (consulta == null)
            {
                return HttpNotFound();
            }
            return View(consulta);
        }

        // GET: Consulta/Create
        public ActionResult Create()
        {
            ViewBag.IdMedico = new SelectList(db.Medico, "IdMedico", "Nome");
            ViewBag.IdPaciente = new SelectList(db.Paciente, "IdPaciente", "Nome");
            return View();
        }

        // POST: Consulta/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Dia,Hora,IdMedico,IdPaciente")] Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                db.Consulta.Add(consulta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdMedico = new SelectList(db.Medico, "IdMedico", "Nome", consulta.IdMedico);
            ViewBag.IdPaciente = new SelectList(db.Paciente, "IdPaciente", "Nome", consulta.IdPaciente);
            return View(consulta);
        }

        // GET: Consulta/Edit/5
        public ActionResult Edit(int? IdMedico, int? IdPaciente)
        {
            if (IdMedico == null || IdPaciente == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consulta consulta = db.Consulta.Find(IdMedico, IdPaciente);
            if (consulta == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdMedico = new SelectList(db.Medico, "IdMedico", "Nome", consulta.IdMedico);
            ViewBag.IdPaciente = new SelectList(db.Paciente, "IdPaciente", "Nome", consulta.IdPaciente);
            return View(consulta);
        }

        // POST: Consulta/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Dia,Hora,IdMedico,IdPaciente")] Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consulta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdMedico = new SelectList(db.Medico, "IdMedico", "Nome", consulta.IdMedico);
            ViewBag.IdPaciente = new SelectList(db.Paciente, "IdPaciente", "Nome", consulta.IdPaciente);
            return View(consulta);
        }

        // GET: Consulta/Delete/5
        public ActionResult Delete(int? IdMedico, int? IdPaciente)
        {
            if (IdMedico == null || IdPaciente == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consulta consulta = db.Consulta.Find(IdMedico, IdPaciente);
            if (consulta == null)
            {
                return HttpNotFound();
            }
            return View(consulta);
        }

        // POST: Consulta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? IdMedico, int? IdPaciente)
        {
            Consulta consulta = db.Consulta.Find(IdMedico, IdPaciente);
            db.Consulta.Remove(consulta);
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
