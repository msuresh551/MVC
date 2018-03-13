using MVCExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MVCExamples.Controllers
{
    public class EntityController : Controller
    {
        // GET: Entity
        public ActionResult Index()
        {
            EmployeeDBContext empDB = new EmployeeDBContext();
            List<EnitityClass> entityclass = empDB.employees.ToList();



            return View(entityclass);
        }
        public ActionResult Details(EnitityClass updated)
        {
            EmployeeDBContext empDB = new EmployeeDBContext();
            List<EnitityClass> entityclass = empDB.employees.ToList();
            // To updating the Data for Entity Framework
            EnitityClass newemp = empDB.employees.Single(x => x.ID == updated.ID);
            newemp.Name = updated.Name;
            empDB.employees.Attach(newemp);
            empDB.Entry(newemp).Property(x => x.Name).IsModified = true;
            //For Multiple columns to update
            // empDB.Entry(newemp).State = EntityState.Modified;
            empDB.SaveChanges();

            return View(entityclass);

        }
    }
}