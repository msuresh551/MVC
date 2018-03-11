using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExamples.Models
{
    public class Part39ListBoxControl
    {
       public IEnumerable<SelectListItem> selectlistitems { get; set; }
        public IEnumerable<string> selectedlistItems { get; set;}
    }
}