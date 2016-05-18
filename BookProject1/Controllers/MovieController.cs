using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookProject1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        
        public ActionResult Search(string name = "Empty Value")
        {
            var userinput = Server.HtmlEncode(name);
            return RedirectToAction("Index", "Home", new { name = userinput, myName = "Michal Flak" });
            
        }
    }
}