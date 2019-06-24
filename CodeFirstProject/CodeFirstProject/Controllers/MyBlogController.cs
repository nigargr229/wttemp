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
    public class MyBlogController : Controller
    {
        private AdamContext db = new AdamContext();

        // GET: MyBlog
        public ActionResult Index()
        {
            return View(db.MyBlogs.ToList());
        }

        // GET: MyBlog/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyBlog myBlog = db.MyBlogs.Find(id);
            if (myBlog == null)
            {
                return HttpNotFound();
            }
            return View(myBlog);
        }

        // GET: MyBlog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyBlog/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Image,Title,Content,History,Share,Network")] MyBlog myBlog)
        {
            if (ModelState.IsValid)
            {
                db.MyBlogs.Add(myBlog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(myBlog);
        }

        // GET: MyBlog/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyBlog myBlog = db.MyBlogs.Find(id);
            if (myBlog == null)
            {
                return HttpNotFound();
            }
            return View(myBlog);
        }

        // POST: MyBlog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Image,Title,Content,History,Share,Network")] MyBlog myBlog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myBlog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myBlog);
        }

        // GET: MyBlog/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyBlog myBlog = db.MyBlogs.Find(id);
            if (myBlog == null)
            {
                return HttpNotFound();
            }
            return View(myBlog);
        }

        // POST: MyBlog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MyBlog myBlog = db.MyBlogs.Find(id);
            db.MyBlogs.Remove(myBlog);
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
