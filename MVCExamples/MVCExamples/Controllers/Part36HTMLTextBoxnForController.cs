using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExamples.Models;
namespace MVCExamples.Controllers
{
    public class Part36HTMLTextBoxnForController : Controller
    {
        // GET: Part36HTMLTextBoxnFor
        public ActionResult Index()
        {
            Part36HTMLTextBoxnFor TB = new Part36HTMLTextBoxnFor("TodayNIFTY");
            ViewBag.Departments =new SelectList( TB.Departments1,"Id", "Department_Name");
            ViewBag.ComName = TB.Companyname;
            return View();
        }
        public ActionResult Index1()
        {
            Part36HTMLTextBoxnFor TB = new Part36HTMLTextBoxnFor("TodayNIFTY");
            //ViewBag.Departments = new SelectList(TB.Departments1, "Id", "Department_Name");
            //ViewBag.ComName = TB.Companyname;
            return View(TB);
        }
    }
}