using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExamples.Models;
using BusinessObjects;

namespace MVCExamples.Controllers
{
    public class Part9GenerateHyperlinksController : Controller
    {
        // GET: Part9GenerateHyperlinks
        public ActionResult Part9GenerateHyperlinks()
        {
            List<EmployeeBO> li = new List<EmployeeBO>();
            EmployeeBusiness eb = new EmployeeBusiness();
            li= eb.DeptEmployees().ToList();
            return View(li);
        }
        public ActionResult EmployeeDetails(int id)
        {
            EmployeeDetails emp = new EmployeeDetails();
            return View("EmployeeDetails", emp);
        }



    }
}