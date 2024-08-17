using ExedePrueba.Context;
using ExedePrueba.Models;
using ExedePrueba.ViewModels;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ExedePrueba.Controllers
{
    public class HabitacionsController : Controller
    {
        private ModeloHotel db = new ModeloHotel();

        // GET: Habitacions
        public ActionResult Index(long id)
        {
            List<GetHabitaciones> Habitaciones = (from a in db.Habitacion
                                                  join b in db.TipoAlojamientos on a.Id_TipoAlojamiento equals b.Id
                                                  where a.Id_Hotel == id
                                                  select new GetHabitaciones
                                                  {
                                                      Activo = a.Activo,
                                                      Id = a.Id,
                                                      Id_Hotel = a.Id_Hotel,
                                                      Id_TipoAlojamiento = a.Id_TipoAlojamiento,
                                                      MaximaCantidadHuespedes = a.MaximaCantidadHuespedes,
                                                      Nombre = a.Nombre,
                                                      TipoAlojamiento = b.Nombre
                                                  }).ToList();
            ViewBag.Id_hotel = id;
            return View(Habitaciones);
        }

        // GET: Habitacions/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Habitacion habitacion = db.Habitacion.Find(id);
            if (habitacion == null)
            {
                return HttpNotFound();
            }
            return View(habitacion);
        }

        // GET: Habitacions/Create
        public ActionResult Create(long id)
        {
            ViewBag.Tipos = db.TipoAlojamientos.Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Nombre }).ToList();

            return View(new Habitacion { Id_Hotel = id });
        }

        // POST: Habitacions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Id_Hotel,Nombre,MaximaCantidadHuespedes,Id_TipoAlojamiento,Activo")] Habitacion habitacion)
        {
            if (ModelState.IsValid)
            {
                db.Habitacion.Add(habitacion);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = habitacion.Id_Hotel });
            }

            return View(habitacion);
        }

        // GET: Habitacions/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Habitacion habitacion = db.Habitacion.Find(id);
            if (habitacion == null)
            {
                return HttpNotFound();
            }
            return View(habitacion);
        }

        // POST: Habitacions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Id_Hotel,Nombre,MaximaCantidadHuespedes,Id_TipoAlojamiento,Activo")] Habitacion habitacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(habitacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(habitacion);
        }

        // GET: Habitacions/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Habitacion habitacion = db.Habitacion.Find(id);
            if (habitacion == null)
            {
                return HttpNotFound();
            }
            return View(habitacion);
        }

        // POST: Habitacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Habitacion habitacion = db.Habitacion.Find(id);
            db.Habitacion.Remove(habitacion);
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
