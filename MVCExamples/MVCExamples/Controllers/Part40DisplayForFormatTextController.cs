using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessObjects;

namespace MVCExamples.Controllers
{
    public class Part40DisplayForFormatTextController : Controller
    {

        // GET: Part40DisplayForFormatText/Details/5
        public ActionResult Details(int id)
        {
            EmployeeBusiness emp = new EmployeeBusiness();
            EmployeeBO employee = (EmployeeBO)emp.DeptEmployees().Where(m => m.EmpID == id).FirstOrDefault();
            return View(employee);
        }
        //Datatype and Display Column Attribute Part41
        public ActionResult CompanyDirector()
        {
            EmployeeBO cmp = new EmployeeBO();

            return View(cmp);
        }

        //Part44 DiplayTemplate and Edit Template
        public  ActionResult DisplayTemplate(int id)
        {

            EmployeeBusiness emp = new EmployeeBusiness();
            EmployeeBO employee = (EmployeeBO)emp.DeptEmployees().Where(m => m.EmpID == id);
            ViewData["EmployeeData"] = employee;
            return View();
        }



        // GET: Part40DisplayForFormatText/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Part40DisplayForFormatText/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Part40DisplayForFormatText/Edit/5
        public ActionResult Edit(int id)
        {
            EmployeeBusiness emp = new EmployeeBusiness();
            EmployeeBO employee = (EmployeeBO)emp.DeptEmployees().SingleOrDefault(m => m.EmpID == id);
            return View(employee);
        }

        // POST: Part40DisplayForFormatText/Edit/5
        [HttpPost]
        public ActionResult Edit(EmployeeBO objEmployee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmployeeBusiness db = new EmployeeBusiness();

                    EmployeeBO employeefromdb = db.DeptEmployees().SingleOrDefault(x => x.EmpID == objEmployee.EmpID);
                    employeefromdb.Employeename = objEmployee.Employeename;
                    employeefromdb.Gender = objEmployee.Gender;
                    employeefromdb.Department = objEmployee.Department;
                    employeefromdb.Email = objEmployee.Email;
                    employeefromdb.City = objEmployee.City;
                    employeefromdb.Salary = objEmployee.Salary;
                    
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Part40DisplayForFormatText/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Part40DisplayForFormatText/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
