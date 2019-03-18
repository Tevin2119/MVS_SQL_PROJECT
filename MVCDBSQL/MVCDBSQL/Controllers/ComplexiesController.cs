using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCDBSQL.Models;

namespace MVCDBSQL.Controllers
{
    public class ComplexiesController : Controller
    {
        private PropertyDBOEntities1 db = new PropertyDBOEntities1();

        // GET: Complexies
        public ActionResult Index()
        {
            return View(db.Complexies1.ToList());
        }

        // GET: Complexies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Complexies complexies = db.Complexies1.Find(id);
            if (complexies == null)
            {
                return HttpNotFound();
            }
            return View(complexies);
        }

        // GET: Complexies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Complexies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ComplexID,Country,Location,Price,Availability,NumBedrooms,NumBathrooms,NumFloors,Squareacres,TypeKitchen,Garden,Age")] Complexies complexies)
        {
            if (ModelState.IsValid)
            {
                db.Complexies1.Add(complexies);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(complexies);
        }

        // GET: Complexies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Complexies complexies = db.Complexies1.Find(id);
            if (complexies == null)
            {
                return HttpNotFound();
            }
            return View(complexies);
        }

        // POST: Complexies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ComplexID,Country,Location,Price,Availability,NumBedrooms,NumBathrooms,NumFloors,Squareacres,TypeKitchen,Garden,Age")] Complexies complexies)
        {
            if (ModelState.IsValid)
            {
                db.Entry(complexies).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(complexies);
        }

        // GET: Complexies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Complexies complexies = db.Complexies1.Find(id);
            if (complexies == null)
            {
                return HttpNotFound();
            }
            return View(complexies);
        }

        // POST: Complexies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Complexies complexies = db.Complexies1.Find(id);
            db.Complexies1.Remove(complexies);
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
