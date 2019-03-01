using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AHBC_Question2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Welcome()
        {
            var random = new Random();
            var list = new List<string> { "Thank you for Visiting", "Enjoy the site!", "Glad to have you", "Rate us on Google" };
            int index = random.Next(list.Count);

            ViewBag.Phrase = list[index];

            return View();
        }

        public ActionResult Receipt()
        {
            Random rng = new Random();
            ViewBag.Random = rng.Next(20000, 50000);
            



            return View();
        }

    }
}