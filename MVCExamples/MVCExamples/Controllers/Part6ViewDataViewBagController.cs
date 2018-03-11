using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExamples.Models;

namespace MVCExamples.Controllers
{
    public class Part6ViewDataViewBagController : Controller
    {
        //        ViewData and ViewBag in MVC
        //Both ViewData and ViewBag are used to pass data
        //from a controller to a view.ViewData is a dictionary of objects that
        //are stored and retrieved using strings as keys

        //  ViewData["KeyName"] = "Data" and ViewBag.PropertyName="Data"
        //ViewBag uses the dynamic feature that was introduced in to C# 4.
        //It allows an object to have properties dynamically added to it.

        //  Both ViewData and ViewBag does not provide compile time error checking.
        //  For example, if know about the error only at runtime.Internally ViewBag
        //  Properties are stored as name/Value pairs in the ViewData dictionary.

        //  To pass data from controller to a view, It's always a good practice to use
        //strongly typed view models over viewBag and ViewData.
        //Strongly typed view models provide compile time error checking.

        // GET: Part6ViewDataViewBag
        public ActionResult Display()
        {
            ViewData["Contries"] = new List<string>() { "India", "US", "UK" };
            ViewBag.Contries = new List<string>() { "India", "US", "UK" };
            List<Customer> liobj = new List<Customer>();
            for (int i = 0; i < 10; i++)
            {
                Customer custobj = new Customer();
                custobj.CustID = i;
                custobj.Email = "a@b.com";
                custobj.Mobile = "123045678";
                custobj.Name = "Suresh";
                liobj.Add(custobj); 
            }
            return View(liobj);
        }
    }
}