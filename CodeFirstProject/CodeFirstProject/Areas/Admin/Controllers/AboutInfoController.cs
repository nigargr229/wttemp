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
    public class AboutInfoController : Controller
    {
        private AdamContext db = new AdamContext();

        // GET: Admin/AboutInfo
        public ActionResult Index()
        {

            if (Session["isLogin"] != null && (bool)Session["isLogin"] == true)
            {
                return View(db.AboutInfos.ToList());
            }
            return RedirectToAction("Index", "Login");
          
        }

        // GET: Admin/AboutInfo/Details/5
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

        // GET: Admin/AboutInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AboutInfo/Create
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

        // GET: Admin/AboutInfo/Edit/5
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

        // POST: Admin/AboutInfo/Edit/5
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

        // GET: Admin/AboutInfo/Delete/5
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

        // POST: Admin/AboutInfo/Delete/5
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
