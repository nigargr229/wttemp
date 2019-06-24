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
    public class ConnectNumberController : Controller
    {
        private AdamContext db = new AdamContext();

        // GET: ConnectNumber
        public ActionResult Index()
        {
            return View(db.ConnectNumbers.ToList());
        }

        // GET: ConnectNumber/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConnectNumber connectNumber = db.ConnectNumbers.Find(id);
            if (connectNumber == null)
            {
                return HttpNotFound();
            }
            return View(connectNumber);
        }

        // GET: ConnectNumber/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConnectNumber/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Icon,Title,Content")] ConnectNumber connectNumber)
        {
            if (ModelState.IsValid)
            {
                db.ConnectNumbers.Add(connectNumber);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(connectNumber);
        }

        // GET: ConnectNumber/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConnectNumber connectNumber = db.ConnectNumbers.Find(id);
            if (connectNumber == null)
            {
                return HttpNotFound();
            }
            return View(connectNumber);
        }

        // POST: ConnectNumber/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Icon,Title,Content")] ConnectNumber connectNumber)
        {
            if (ModelState.IsValid)
            {
                db.Entry(connectNumber).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(connectNumber);
        }

        // GET: ConnectNumber/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConnectNumber connectNumber = db.ConnectNumbers.Find(id);
            if (connectNumber == null)
            {
                return HttpNotFound();
            }
            return View(connectNumber);
        }

        // POST: ConnectNumber/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConnectNumber connectNumber = db.ConnectNumbers.Find(id);
            db.ConnectNumbers.Remove(connectNumber);
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
