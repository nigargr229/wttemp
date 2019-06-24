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

namespace CodeFirstProject.Areas.Admin.Controllers
{
    public class PortfolioNavController : Controller
    {
        private AdamContext db = new AdamContext();

        // GET: Admin/PortfolioNav
        public ActionResult Index()
        {
            if (Session["isLogin"] != null && (bool)Session["isLogin"] == true)
            {
                return View(db.PortfolioNavs.ToList());
            }
            return RedirectToAction("Index", "Login");
          
        }

        // GET: Admin/PortfolioNav/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PortfolioNav portfolioNav = db.PortfolioNavs.Find(id);
            if (portfolioNav == null)
            {
                return HttpNotFound();
            }
            return View(portfolioNav);
        }

        // GET: Admin/PortfolioNav/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/PortfolioNav/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Menu")] PortfolioNav portfolioNav)
        {
            if (ModelState.IsValid)
            {
                db.PortfolioNavs.Add(portfolioNav);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(portfolioNav);
        }

        // GET: Admin/PortfolioNav/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PortfolioNav portfolioNav = db.PortfolioNavs.Find(id);
            if (portfolioNav == null)
            {
                return HttpNotFound();
            }
            return View(portfolioNav);
        }

        // POST: Admin/PortfolioNav/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Menu")] PortfolioNav portfolioNav)
        {
            if (ModelState.IsValid)
            {
                db.Entry(portfolioNav).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(portfolioNav);
        }

        // GET: Admin/PortfolioNav/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PortfolioNav portfolioNav = db.PortfolioNavs.Find(id);
            if (portfolioNav == null)
            {
                return HttpNotFound();
            }
            return View(portfolioNav);
        }

        // POST: Admin/PortfolioNav/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PortfolioNav portfolioNav = db.PortfolioNavs.Find(id);
            db.PortfolioNavs.Remove(portfolioNav);
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
