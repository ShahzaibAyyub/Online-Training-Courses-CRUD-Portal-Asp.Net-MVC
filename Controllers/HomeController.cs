using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PNTS.DAL;
using PNTS.Models;

namespace PNTS.Controllers
{
    public class HomeController : Controller
    {
        private PNTSContext db = new PNTSContext();
        public ActionResult Index()
        {
            return View(db.Courses.ToList());
            
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

        public ActionResult Selenuim()
        {
            ViewBag.Message = "Selenium";

            return View();
        }

        public ActionResult MachineLearning()
        {
            ViewBag.Message = "MachineLearning.";

            return View();
        }

        public ActionResult EthicalHacking()
        {
            ViewBag.Message = "Ethical Hacking.";

            return View();
        }

        public ActionResult DataScience()
        {
            ViewBag.Message = "DataScience";

            return View();
        }

        public ActionResult DevOpsEngineer()
        {
            ViewBag.Message = "DevOps Engineer.";

            return View();
        }

        public ActionResult Javascript()
        {
            ViewBag.Message = "Javascript";

            return View();
        }

        public ActionResult PostGreSQL()
        {
            ViewBag.Message = "PostGreSQL";

            return View();
        }

        public ActionResult PythonScripting()
        {
            ViewBag.Message = "Python Scripting.";

            return View();
        }
    }
}