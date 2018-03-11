using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExamples.Models;

namespace MVCExamples.Controllers
{
    public class Part7ModelsController : Controller
    {
        // GET: Part6Models
        public ActionResult EmployeeDetails(int id)
        {
            EmployeeDetails emp = new EmployeeDetails() { ID = 1, EmpID = 102, Name = "Suresh Mogudala", City = "a@b.com", Gender = "Male", Email = "a@b.com", Department = "IT" };
            List<EmployeeDetails> liobj = new List<EmployeeDetails>();
            EmployeeDetails empDetails = new EmployeeDetails() { ID = 2, EmpID = 103, City = "Hyderabad", Name = "Mahesh Mogudala", Email = "a@b.com", Gender = "Male", Department = "Accounts" };
            liobj.Add(emp);
            liobj.Add(empDetails);
            return View(liobj);

        }
    }
}