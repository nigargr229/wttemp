using CodeFirstProject.DAL;
using CodeFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstProject.Controllers
{
    public class HomeController : Controller
    {
        AdamContext db = new AdamContext();
        AboutInfo AboutInfo;
        public HomeController()
        {
            AboutInfo = db.AboutInfos.FirstOrDefault();
        }


        public ActionResult Index()
        {
            ViewModelHome model = new ViewModelHome();

            model.AboutInfo = db.AboutInfos.ToList();
            model.ConnectNumbers = db.ConnectNumbers.ToList();
            model.Educations = db.Educations.ToList();
            model.Experiences = db.Experiences.ToList();
            model.Languages = db.Languages.ToList();
            model.MyBlogs = db.MyBlogs.ToList();
            model.PersonalDetails = db.PersonalDetails.ToList();
            model.Portfolios = db.Portfolios.ToList();
            model.PortfolioNavs = db.PortfolioNavs.ToList();
            model.Recommendations = db.Recommendations.ToList();
            model.Skills = db.Skills.ToList();
            
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}