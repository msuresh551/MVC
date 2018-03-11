using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExamples.Models;
using BusinessObjects;

namespace MVCExamples.Controllers
{
    public class Part71HandleErrorController : Controller
    {
        // GET: Part72HandleError
        // [HandleError]
        public ActionResult Index()
        {
            throw new Exception("this is Exception");
            //  return View();
        }
        public ActionResult HomeCountry()
        {
            return View();
        }

        //Part71 ChildActiononly
        [ChildActionOnly]
        public ActionResult ChildCoutries(List<string> contries)
        {
            return View(contries);
        }

        //Part 72
        public ActionResult ErrorPage()
        {
            throw new Exception("this is Exception");
            //  return View();
        }
        public ActionResult ErrorData()
        {
            return View("ErrorData");
        }

       // [OutputCache(Duration = 20)]
        //Part 74 Cache profiles
        [OutputCache(CacheProfile = "1MinuteCache")]
        public ActionResult Part73OutputCache()
        {
         //   System.Threading.Thread.Sleep(3000);
            EmployeeBusiness db = new EmployeeBusiness();
            return View(db.DeptEmployees());
        }

        [OutputCache(Duration = 10)]
        [ChildActionOnly]
        public string Part73GetEmployeeCount()
        {
            EmployeeBusiness db = new EmployeeBusiness();
            return "Employee Count " + db.DeptEmployees().Count().ToString() + " @ " + DateTime.Now.ToString();
        }
        [RequireHttps]
        public string requesthttp()
        {
            return "Return HTTPs ";
        }
    }
}