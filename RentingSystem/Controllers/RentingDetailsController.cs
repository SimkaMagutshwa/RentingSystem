using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RentingSystem.Data;
using RentingSystem.Models;

namespace RentingSystem.Controllers
{
    public class RentingDetailsController : Controller
    {
        private RentingSystemContext db = new RentingSystemContext();

        // GET: RentingDetails
        public ActionResult Index()
        {
            return View(db.RentingDetails.ToList());
        }

        // GET: RentingDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RentingDetails rentingDetails = db.RentingDetails.Find(id);
            if (rentingDetails == null)
            {
                return HttpNotFound();
            }
            return View(rentingDetails);
        }

        // GET: RentingDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RentingDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RenterFirstName,ReleaseDate,MovieTitle,NumberofMovies,TotalPrice,Duration")] RentingDetails rentingDetails)
        {
            if (ModelState.IsValid)
            {
                db.RentingDetails.Add(rentingDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rentingDetails);
        }

        // GET: RentingDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RentingDetails rentingDetails = db.RentingDetails.Find(id);
            if (rentingDetails == null)
            {
                return HttpNotFound();
            }
            return View(rentingDetails);
        }

        // POST: RentingDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RenterFirstName,ReleaseDate,MovieTitle,NumberofMovies,TotalPrice,Duration")] RentingDetails rentingDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rentingDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rentingDetails);
        }

        // GET: RentingDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RentingDetails rentingDetails = db.RentingDetails.Find(id);
            if (rentingDetails == null)
            {
                return HttpNotFound();
            }
            return View(rentingDetails);
        }

        // POST: RentingDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RentingDetails rentingDetails = db.RentingDetails.Find(id);
            db.RentingDetails.Remove(rentingDetails);
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
