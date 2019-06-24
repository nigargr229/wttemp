using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodeFirstProject.DAL;
using CodeFirstProject.Models;

namespace CodeFirstProject.Controllers
{
    public class PersonalDetailController : Controller
    {
        private AdamContext db = new AdamContext();

        // GET: PersonalDetail
        public ActionResult Index()
        {
            return View(db.PersonalDetails.ToList());
        }

        // GET: PersonalDetail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalDetails personalDetails = db.PersonalDetails.Find(id);
            if (personalDetails == null)
            {
                return HttpNotFound();
            }
            return View(personalDetails);
        }

        // GET: PersonalDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonalDetail/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Info")] PersonalDetails personalDetails)
        {
            if (ModelState.IsValid)
            {
                db.PersonalDetails.Add(personalDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personalDetails);
        }

        // GET: PersonalDetail/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalDetails personalDetails = db.PersonalDetails.Find(id);
            if (personalDetails == null)
            {
                return HttpNotFound();
            }
            return View(personalDetails);
        }

        // POST: PersonalDetail/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Info")] PersonalDetails personalDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personalDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personalDetails);
        }

        // GET: PersonalDetail/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalDetails personalDetails = db.PersonalDetails.Find(id);
            if (personalDetails == null)
            {
                return HttpNotFound();
            }
            return View(personalDetails);
        }

        // POST: PersonalDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonalDetails personalDetails = db.PersonalDetails.Find(id);
            db.PersonalDetails.Remove(personalDetails);
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
