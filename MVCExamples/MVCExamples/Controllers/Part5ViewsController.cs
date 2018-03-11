using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExamples.Controllers
{
    public class Part5ViewsController : Controller
    {
        // GET: Views
        public ActionResult CountriesList()
        {
            ViewBag.Contries = new List<string>() { "India", "US", "UK" };
            return View();
        }
    }
}