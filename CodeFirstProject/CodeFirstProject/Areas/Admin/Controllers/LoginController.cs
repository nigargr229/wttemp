using CodeFirstProject.DAL;
using CodeFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace CodeFirstProject.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {


        private readonly AdamContext db;

        public LoginController()
        {
            db = new AdamContext();
        }
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Signin(AdminUser admin)
        {
            bool isMatch = false;

            if (string.IsNullOrEmpty(admin.Username) || string.IsNullOrEmpty(admin.Password))
            {
                Session["loginError"] = "Username and Password don't be empty!";
                return RedirectToAction("Index", "Login");
            }

           AdminUser adm= db.AdminUsers.FirstOrDefault(a => a.Username == admin.Username);
            if (adm !=null)
            {   
                isMatch = Crypto.VerifyHashedPassword(adm.Password, admin.Password);
                if (isMatch)
                {
                    Session["isLogin"] = true;
                    return RedirectToAction("Index","Home", new {area= "Admin"});
                }
            }


            Session["loginError"] = "Username or Password wrong";
            return RedirectToAction("Index", "Login");
        }


        public ActionResult Signout()
        {
            Session["isLogin"] = null;
            return RedirectToAction("Index","Login");
        }
        public ActionResult HashPass()
        {
            string parol = "admin";
            string hashedParol = Crypto.HashPassword(parol);


            return Content(hashedParol);
        }
    }
}