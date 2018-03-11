using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExamples.Models;
using BusinessObjects;

namespace MVCExamples.Controllers
{
    public class Part34GeneratingDropdownListItemsController : Controller
    {
        // GET: Part34GeneratingDropdownListItems
        /// <summary>
        /// Part35 Set An Item Selected when asp.net dropdownlist loaded once
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            EmployeeBusiness DB = new EmployeeBusiness();
            //ViewBag.Departments = new SelectList(DB.Departments, "Id", "Department_Name","1");
            List<SelectListItem> li = new List<SelectListItem>();
            foreach (Department dept in DB.getDepartments())
            {
                SelectListItem sli = new SelectListItem
                {
                    Text = dept.Department_Name,
                    Value = dept.Id.ToString(),
                    Selected = dept.IsSelected.HasValue ? dept.IsSelected.Value : false
                };
                li.Add(sli);
            }
            ViewBag.Departments = li;
            return View();
        }
    }
}