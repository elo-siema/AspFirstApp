using BookProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookProject1.Controllers
{
    public class HomeController : Controller
    {
        MovieDb _movieDb = new MovieDb();
        public ActionResult Index()
        {
            return View();
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
        protected override void Dispose(bool disposing)
        {
            if (_movieDb!=null)
            {
                _movieDb.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}