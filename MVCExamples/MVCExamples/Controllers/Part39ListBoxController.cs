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
    public class Part39ListBoxController : Controller
    {
        // GET: Part39ListBox
        [HttpGet]
        public ActionResult Index()
        {
            EmployeeBusiness en = new EmployeeBusiness();
            List<SelectListItem> liitems = new List<SelectListItem>();
            foreach (City city in en.getCities())
            {
                SelectListItem li = new SelectListItem()
                {
                    Text = city.Name,
                    Value = city.ID.ToString(),
                    Selected = city.IsSelected

                };
                liitems.Add(li);
            }
            Part39ListBoxControl cs = new Part39ListBoxControl();
            cs.selectlistitems = liitems;
            return View(cs);
        }

        [HttpPost]
        public string Index(IEnumerable<string> selectedlistItems)
        {
            if (selectedlistItems == null)
                return "You did not selected any thing";
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(" You selected - "+string.Join(",", selectedlistItems));
                return sb.ToString();
            }
        }

    }
}