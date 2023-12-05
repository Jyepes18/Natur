using crudNarAsp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudNarAsp.Controllers
{
    public class DetaFacController : Controller
    {
        // GET: DetaFac
        public ActionResult Index()
        {
            using (NaturEntities context = new NaturEntities())
            {
                return View(context.FacturaDetalle.ToList());
            }

        }

        // GET: DetaFac/Details/5
        public ActionResult Details(int id)
        {
            using (NaturEntities context = new NaturEntities())
            {
                return View(context.FacturaDetalle.Where(x => x.Numero == id).FirstOrDefault());
            }

        }

        // GET: DetaFac/Create
        public ActionResult Create()
        {
            return View();

        }

        // POST: DetaFac/Create
        [HttpPost]
        public ActionResult Create(FacturaDetalle Detalle)
        {
            try
            {
                using (NaturEntities context = new NaturEntities())
                {
                    context.FacturaDetalle.Add(Detalle);
                    context.SaveChanges();
                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DetaFac/Edit/5
        public ActionResult Edit(int id)
        {
            using (NaturEntities context = new NaturEntities())
            {
                return View(context.FacturaDetalle.Where(x => x.Numero == id).FirstOrDefault());
            }

        }

        // POST: DetaFac/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FacturaDetalle Detalle)
        {
            try
            {
                using (NaturEntities context = new NaturEntities())
                {
                    context.Entry(Detalle).State = (System.Data.Entity.EntityState)EntityState.Modified;
                    context.SaveChanges();
                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DetaFac/Delete/5
        public ActionResult Delete(int id)
        {
            using (NaturEntities context = new NaturEntities())
            {
                return View(context.FacturaDetalle.Where(x => x.Numero == id).FirstOrDefault());
            }

        }

        // POST: DetaFac/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (NaturEntities context = new NaturEntities())
                {
                    FacturaDetalle Detalle = context.FacturaDetalle.Where(x => x.Numero == id).FirstOrDefault();
                    context.FacturaDetalle.Remove(Detalle);
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
