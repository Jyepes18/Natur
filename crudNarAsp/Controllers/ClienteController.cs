using crudNarAsp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudNarAsp.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            using (NaturEntities context = new NaturEntities())
            {
                return View(context.GestionClientes.ToList());
            }
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
              using (NaturEntities context = new NaturEntities())
            {
                return View(context.GestionClientes.Where(x=>x.Documento == id).FirstOrDefault());
            }
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(GestionClientes Clientes)
        {
            try
            {
                using (NaturEntities context = new NaturEntities())
                {
                    context.GestionClientes.Add(Clientes);
                    context.SaveChanges();
                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            using (NaturEntities context = new NaturEntities())
            {
                return View(context.GestionClientes.Where(x => x.Documento == id).FirstOrDefault());
            }
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, GestionClientes Clientes)
        {
            try
            {
                using (NaturEntities context = new NaturEntities())
                {
                    context.Entry(Clientes).State = (System.Data.Entity.EntityState)EntityState.Modified;
                    context.SaveChanges();
                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            using (NaturEntities context = new NaturEntities())
            {
                return View(context.GestionClientes.Where(x => x.Documento == id).FirstOrDefault());
            }

        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (NaturEntities context = new NaturEntities())
                {
                    GestionClientes Clientes = context.GestionClientes.Where(x => x.Documento == id).FirstOrDefault();
                    context.GestionClientes.Remove(Clientes);
                    context.SaveChanges();
                }



                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
