using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExamples.Models;
using System.Text;
using BusinessObjects;

namespace MVCExamples.Controllers
{
    public class Part37GeneratingRadiobuttonlistController : Controller
    {
        // GET: Part37GeneratingRadiobuttonlist
        [HttpGet]
        public ActionResult Index()
        {
            Part36HTMLTextBoxnFor dept = new Part36HTMLTextBoxnFor("");
            return View(dept);
        }
        [HttpPost]
        public string Index(Part36HTMLTextBoxnFor ctr)
        {
            if (string.IsNullOrEmpty(ctr.selectedDepartmet))
            {
                return "Selected Department is Empty";
            }
            else
            {
                return "Selected Department : " + ctr.selectedDepartmet;
            }
        }
        [HttpGet]
        public ActionResult CheckBox()
        {
            EmployeeBusiness city = new EmployeeBusiness();
            return View(city.getCities());
        }
        [HttpPost]
        public string CheckBox(IEnumerable<City> cities)
        {
            if(cities.Count(x=>x.IsSelected)==0)
            {
                return "You did not selected any City";
            }
            else
            {

                StringBuilder sb = new StringBuilder();
                sb.Append("You selected");
                foreach (City item in cities)
                {
                    if (item.IsSelected)
                        sb.Append(item.Name + ",");
                }
                sb.Remove(sb.ToString().LastIndexOf(','), 1);
                return sb.ToString(); 
            }
             
        }
        
    }
}