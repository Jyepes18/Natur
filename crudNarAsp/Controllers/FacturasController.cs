using System;
using System.Linq;
using System.Web.Mvc;
using crudNarAsp.Models;

namespace crudNarAsp.Controllers
{
    public class FacturasController : Controller
    {
        private readonly NaturEntities _context;

        public FacturasController()
        {
            _context = new NaturEntities();
        }

        // GET: Facturas
        public ActionResult Index()
        {
            var facturas = _context.Facturas.ToList();
            return View(facturas);
        }

        // GET: Facturas/Details/5
        public ActionResult Details(int id)
        {
            var factura = _context.Facturas.FirstOrDefault(x => x.Codigo == id);
            if (factura == null)
            {
                return HttpNotFound();
            }

            return View(factura);
        }

        // GET: Facturas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Facturas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Facturas factura)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Facturas.Add(factura);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al crear la factura");
            }

            return View(factura);
        }

        // GET: Facturas/Edit/5
        public ActionResult Edit(int id)
        {
            var factura = _context.Facturas.FirstOrDefault(x => x.Codigo == id);
            if (factura == null)
            {
                return HttpNotFound();
            }

            return View(factura);
        }

        // POST: Facturas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Facturas factura)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Entry(factura).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al editar la factura");
            }

            return View(factura);
        }

        // GET: Facturas/Delete/5
        public ActionResult Delete(int id)
        {
            var factura = _context.Facturas.FirstOrDefault(x => x.Codigo == id);
            if (factura == null)
            {
                return HttpNotFound();
            }

            return View(factura);
        }

        // POST: Facturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var factura = _context.Facturas.FirstOrDefault(x => x.Codigo == id);
                if (factura != null)
                {
                    _context.Facturas.Remove(factura);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al eliminar la factura");
            }

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
