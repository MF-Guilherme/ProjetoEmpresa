using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Empresa.Db;
using Empresa.Models;

namespace Empresa.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var db = new ClienteDb();
            var lista = db.Listar();

            return View(lista);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            var db = new ClienteDb();
            var cliente = db.ObterPorId(id);

            return View(cliente);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                // TODO: Add insert logic here
                var db = new ClienteDb();
                db.Incluir(cliente);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(cliente);
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            var db = new ClienteDb();
            var cliente = db.ObterPorId(id);

            return View(cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cliente cliente)
        {
            try
            {
                // TODO: Add update logic here

                var db = new ClienteDb();
                db.Alterar(cliente);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(cliente);
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
