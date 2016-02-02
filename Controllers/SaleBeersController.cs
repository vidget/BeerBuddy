using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BeerBuddy.Context;
using BeerBuddy.Models;

namespace BeerBuddy.Controllers
{
    public class SaleBeersController : Controller
    {
        private BeerContext db = new BeerContext();

        // GET: SaleBeers
        public ActionResult Index()
        {
            return View(db.SaleBeers.ToList());
        }

        // GET: SaleBeers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SaleBeer saleBeer = db.SaleBeers.Find(id);
            if (saleBeer == null)
            {
                return HttpNotFound();
            }
            return View(saleBeer);
        }

        // GET: SaleBeers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaleBeers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SaleBeerId,BarId,BeerId,UserId,BeerCost,Date")] SaleBeer saleBeer)
        {
            if (ModelState.IsValid)
            {
                db.SaleBeers.Add(saleBeer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(saleBeer);
        }

        // GET: SaleBeers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SaleBeer saleBeer = db.SaleBeers.Find(id);
            if (saleBeer == null)
            {
                return HttpNotFound();
            }
            return View(saleBeer);
        }

        // POST: SaleBeers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SaleBeerId,BarId,BeerId,UserId,BeerCost,Date")] SaleBeer saleBeer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(saleBeer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(saleBeer);
        }

        // GET: SaleBeers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SaleBeer saleBeer = db.SaleBeers.Find(id);
            if (saleBeer == null)
            {
                return HttpNotFound();
            }
            return View(saleBeer);
        }

        // POST: SaleBeers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SaleBeer saleBeer = db.SaleBeers.Find(id);
            db.SaleBeers.Remove(saleBeer);
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
