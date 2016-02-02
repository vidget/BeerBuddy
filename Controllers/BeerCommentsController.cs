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
    public class BeerCommentsController : Controller
    {
        private BeerContext db = new BeerContext();

        // GET: BeerComments
        public ActionResult Index()
        {
            return View(db.BeerComments.ToList());
        }

        // GET: BeerComments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BeerComment beerComment = db.BeerComments.Find(id);
            if (beerComment == null)
            {
                return HttpNotFound();
            }
            return View(beerComment);
        }

        // GET: BeerComments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BeerComments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BeerCommentId,BeerId,UserId,Comment")] BeerComment beerComment)
        {
            if (ModelState.IsValid)
            {
                db.BeerComments.Add(beerComment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(beerComment);
        }

        // GET: BeerComments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BeerComment beerComment = db.BeerComments.Find(id);
            if (beerComment == null)
            {
                return HttpNotFound();
            }
            return View(beerComment);
        }

        // POST: BeerComments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BeerCommentId,BeerId,UserId,Comment")] BeerComment beerComment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(beerComment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(beerComment);
        }

        // GET: BeerComments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BeerComment beerComment = db.BeerComments.Find(id);
            if (beerComment == null)
            {
                return HttpNotFound();
            }
            return View(beerComment);
        }

        // POST: BeerComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BeerComment beerComment = db.BeerComments.Find(id);
            db.BeerComments.Remove(beerComment);
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
