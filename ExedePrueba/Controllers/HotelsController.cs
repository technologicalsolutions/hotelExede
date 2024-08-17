using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExedePrueba.Bll;
using ExedePrueba.Context;
using ExedePrueba.Models;
using ExedePrueba.ViewModels;

namespace ExedePrueba.Controllers
{
    public class HotelsController : Controller
    {
        private ModeloHotel db = new ModeloHotel();

        // GET: Hotels
        public ActionResult Index()
        {
            return View(db.Hotel.ToList());
        }

        // GET: Hotels/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hotel hotel = db.Hotel.Find(id);
            if (hotel == null)
            {
                return HttpNotFound();
            }
            return View(hotel);
        }

        // GET: Hotels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hotels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Capacidad,Ciudad,Foto,Activo")] ResponseHotel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Hotel hotel = new Hotel
                    {
                        Activo = modelo.Activo,
                        Capacidad = modelo.Capacidad,
                        Ciudad = modelo.Ciudad,
                        Nombre = modelo.Nombre
                    };

                    if (modelo.Foto != null)
                    {
                        using (Utilidades util = new Utilidades())
                        {
                            hotel.Imagen = util.ConvertirStreamXBase64(modelo.Foto.InputStream);
                        }
                    }

                    db.Hotel.Add(hotel);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    modelo.Error = true;
                    modelo.Mensaje = new List<string> { ex.Message, ex.ToString() };
                }

                return View(modelo);

            }

            return View(modelo);
        }

        // GET: Hotels/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hotel hotel = db.Hotel.Find(id);
            if (hotel == null)
            {
                return HttpNotFound();
            }
            return View(hotel);
        }

        // POST: Hotels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Capacidad,Ciudad,Foto,Activo")] ResponseHotel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Hotel hotel = new Hotel
                    {
                        Activo = modelo.Activo,
                        Capacidad = modelo.Capacidad,
                        Ciudad = modelo.Ciudad,
                        Nombre = modelo.Nombre
                    };

                    if (modelo.Foto != null)
                    {
                        using (Utilidades util = new Utilidades())
                        {
                            hotel.Imagen = util.ConvertirStreamXBase64(modelo.Foto.InputStream);
                        }
                    }

                    db.Entry(hotel).State = EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    modelo.Error = true;
                    modelo.Mensaje = new List<string> { ex.Message, ex.ToString() };
                }

                return View(modelo);
            }
            return View(modelo);
        }

        // GET: Hotels/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hotel hotel = db.Hotel.Find(id);
            if (hotel == null)
            {
                return HttpNotFound();
            }
            return View(hotel);
        }

        // POST: Hotels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Hotel hotel = db.Hotel.Find(id);
            db.Hotel.Remove(hotel);
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
