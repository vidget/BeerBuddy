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
    public class BarCommentsController : Controller
    {
        private BeerContext db = new BeerContext();

        // GET: BarComments
        public ActionResult Index()
        {
            return View(db.BarComments.ToList());
        }

        // GET: BarComments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BarComment barComment = db.BarComments.Find(id);
            if (barComment == null)
            {
                return HttpNotFound();
            }
            return View(barComment);
        }

        // GET: BarComments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BarComments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BarCommentId,BarId,UserId,Comment")] BarComment barComment)
        {
            if (ModelState.IsValid)
            {
                db.BarComments.Add(barComment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(barComment);
        }

        // GET: BarComments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BarComment barComment = db.BarComments.Find(id);
            if (barComment == null)
            {
                return HttpNotFound();
            }
            return View(barComment);
        }

        // POST: BarComments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BarCommentId,BarId,UserId,Comment")] BarComment barComment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(barComment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(barComment);
        }

        // GET: BarComments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BarComment barComment = db.BarComments.Find(id);
            if (barComment == null)
            {
                return HttpNotFound();
            }
            return View(barComment);
        }

        // POST: BarComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BarComment barComment = db.BarComments.Find(id);
            db.BarComments.Remove(barComment);
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
