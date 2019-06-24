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
    public class AboutInfoController : Controller
    {
        private AdamContext db = new AdamContext();

        // GET: AboutInfo
        public ActionResult Index()
        {
            return View(db.AboutInfos.ToList());
        }

        // GET: AboutInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutInfo aboutInfo = db.AboutInfos.Find(id);
            if (aboutInfo == null)
            {
                return HttpNotFound();
            }
            return View(aboutInfo);
        }

        // GET: AboutInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AboutInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Content,ButtonInfo,Name,Image,Position,CountryInfo,Faculty,EducationTitle,EducationInfo,PreviosTitle,Previosİnfo")] AboutInfo aboutInfo)
        {
            if (ModelState.IsValid)
            {
                db.AboutInfos.Add(aboutInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aboutInfo);
        }

        // GET: AboutInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutInfo aboutInfo = db.AboutInfos.Find(id);
            if (aboutInfo == null)
            {
                return HttpNotFound();
            }
            return View(aboutInfo);
        }

        // POST: AboutInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Content,ButtonInfo,Name,Image,Position,CountryInfo,Faculty,EducationTitle,EducationInfo,PreviosTitle,Previosİnfo")] AboutInfo aboutInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aboutInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aboutInfo);
        }

        // GET: AboutInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutInfo aboutInfo = db.AboutInfos.Find(id);
            if (aboutInfo == null)
            {
                return HttpNotFound();
            }
            return View(aboutInfo);
        }

        // POST: AboutInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AboutInfo aboutInfo = db.AboutInfos.Find(id);
            db.AboutInfos.Remove(aboutInfo);
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
