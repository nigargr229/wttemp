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
    public class MyBlogController : Controller
    {
        private AdamContext db = new AdamContext();

        // GET: Admin/MyBlog
        public ActionResult Index()
        {
            if (Session["isLogin"] != null && (bool)Session["isLogin"] == true)
            {
                return View(db.MyBlogs.ToList());
            }
            return RedirectToAction("Index", "Login");
           
        }

        // GET: Admin/MyBlog/Details/5
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

        // GET: Admin/MyBlog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/MyBlog/Create
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

        // GET: Admin/MyBlog/Edit/5
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

        // POST: Admin/MyBlog/Edit/5
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

        // GET: Admin/MyBlog/Delete/5
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

        // POST: Admin/MyBlog/Delete/5
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
