using ExedePrueba.Context;
using ExedePrueba.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ExedePrueba.Controllers
{
    public class TipoAlojamientosController : Controller
    {
        private ModeloHotel db = new ModeloHotel();

        // GET: TipoAlojamientos
        public ActionResult Index()
        {
            return View(db.TipoAlojamientos.ToList());
        }

        // GET: TipoAlojamientos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoAlojamientos tipoAlojamientos = db.TipoAlojamientos.Find(id);
            if (tipoAlojamientos == null)
            {
                return HttpNotFound();
            }
            return View(tipoAlojamientos);
        }

        // GET: TipoAlojamientos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoAlojamientos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Activo")] TipoAlojamientos tipoAlojamientos)
        {
            if (ModelState.IsValid)
            {
                db.TipoAlojamientos.Add(tipoAlojamientos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoAlojamientos);
        }

        // GET: TipoAlojamientos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoAlojamientos tipoAlojamientos = db.TipoAlojamientos.Find(id);
            if (tipoAlojamientos == null)
            {
                return HttpNotFound();
            }
            return View(tipoAlojamientos);
        }

        // POST: TipoAlojamientos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Activo")] TipoAlojamientos tipoAlojamientos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoAlojamientos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoAlojamientos);
        }

        // GET: TipoAlojamientos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoAlojamientos tipoAlojamientos = db.TipoAlojamientos.Find(id);
            if (tipoAlojamientos == null)
            {
                return HttpNotFound();
            }
            return View(tipoAlojamientos);
        }

        // POST: TipoAlojamientos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TipoAlojamientos tipoAlojamientos = db.TipoAlojamientos.Find(id);
            db.TipoAlojamientos.Remove(tipoAlojamientos);
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
