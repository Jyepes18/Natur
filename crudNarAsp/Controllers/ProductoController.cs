using crudNarAsp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudNarAsp.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            using (NaturEntities context = new NaturEntities())
            {
                return View(context.GestionProductos.ToList());
            }

        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            using (NaturEntities context = new NaturEntities())
            {
                return View(context.GestionProductos.Where(x => x.Codigo == id).FirstOrDefault());
            }
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(GestionProductos Productos)
        {
            try
            {
                using (NaturEntities context = new NaturEntities())
                {
                    context.GestionProductos.Add(Productos);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            using (NaturEntities context = new NaturEntities())
            {
                return View(context.GestionProductos.Where(x => x.Codigo == id).FirstOrDefault());
            }
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, GestionProductos Productos)
        {
            try
            {
                using (NaturEntities context = new NaturEntities())
                {
                    context.Entry(Productos).State = (System.Data.Entity.EntityState)EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            using (NaturEntities context = new NaturEntities())
            {
                return View(context.GestionProductos.Where(x => x.Codigo == id).FirstOrDefault());
            }
        }

        // POST: Producto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (NaturEntities context = new NaturEntities())
                {
                    GestionProductos Productos = context.GestionProductos.Where(x => x.Codigo == id).FirstOrDefault();
                    context.GestionProductos.Remove(Productos);
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
