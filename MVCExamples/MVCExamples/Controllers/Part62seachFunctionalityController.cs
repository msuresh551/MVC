using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExample1.Models;
using PagedList;
using PagedList.Mvc;
using BusinessObjects;

namespace MVCExamples.Controllers
{
    public class Part62seachFunctionalityController : Controller
    {
        // GET: Part62seachFunctionality

        public ActionResult Part62seachFunctionality(string searchby, string search)
        {
            EmployeeBusiness db = new EmployeeBusiness();
            if (searchby == "Gender")
            {
                return View(db.DeptEmployees().Where(x => x.Gender == search || search == null).ToList());
            }
            else
            {
                return View(db.DeptEmployees().Where(x => x.Employeename.StartsWith(search) || search == null).ToList());
            }
        }

        public ActionResult Part63Pagenation(string searchby, string search, int? Page)
        {
            EmployeeBusiness db = new EmployeeBusiness();
            if (searchby == "Gender")
            {
                return View(db.DeptEmployees().Where(x => x.Gender == search || search == null).ToList().ToPagedList(Page ?? 1, 3));
            }
            else
            {
                return View(db.DeptEmployees().Where(x => x.Employeename.StartsWith(search) || search == null).ToList().ToPagedList(Page ?? 1, 3));
            }
        }

        public ActionResult Part64Sorting(string searchby, string search, int? Page, string sortBy)
        {
            ViewBag.SortByNameParameter = string.IsNullOrEmpty(sortBy) ? "Name desc" : "";
            ViewBag.SortByGenderParameter = (sortBy == "Gender") ? "Gender Desc" : "Gender";
            EmployeeBusiness db = new EmployeeBusiness();
            var employee = db.DeptEmployees().AsQueryable();
            if (searchby == "Gender")
            {
                employee = employee.Where(x => x.Gender == search || search == null);
            }
            else
            {
                employee = employee.Where(x => x.Employeename.StartsWith(search) || search == null);
            }
            switch (sortBy)
            {
                case "Name desc":
                    employee = employee.OrderByDescending(x => x.Employeename);
                    break;
                case "Gender Desc":
                    employee = employee.OrderByDescending(x => x.Gender);
                    break;
                case "Gender":
                    employee = employee.OrderBy(x => x.Gender);
                    break;
                default:
                    employee = employee.OrderBy(x => x.Employeename);
                    break;
            }
            return View(employee.ToPagedList(Page ?? 1, 3));
        }
        /// <summary>
        /// Part 65 Deleting Check box data
        /// </summary>
        /// <param name="searchby"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult Part65DeleteData()
        {
            EmployeeBusiness db = new EmployeeBusiness();

            return View(db.DeptEmployees().ToList());
        }
        /// <summary>
        /// Part 65 Delete multiple items based on user selected items 
        /// Part 66 Check all checkboxs 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSelected(IEnumerable<int> ids)
        {
            EmployeeBusiness db = new EmployeeBusiness();
            //            db.Employees.Where(x => ids.Contains(x.EmpID)).ToList().RemoveAll();
            //db.DeptEmployees().RemoveRange(db.DeptEmployees().Where(x => ids.Contains(x.EmpID)).ToList());
            //db.SaveChanges();
            //              .ForEach(db.Employees.Remove();
            return RedirectToAction("Part65DeleteData");
        }
      

        [ActionName("Part67")]
        public string TestActionName()
        {
            return "This is Testing Action name";
            
        }

        [ActionName("Part67View")]
        public ActionResult TestUrl()
        {
            return View("TestUrl");
        }

        [NonAction]
        public string NonActionMethod()
        {
            return "This is Testing Action name";
        }
    }
}