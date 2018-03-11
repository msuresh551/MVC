using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExamples.Models
{
    public class Part36HTMLTextBoxnFor
    {
        public string Companyname { get; set; }
        public Part36HTMLTextBoxnFor()
        {

        }
        public Part36HTMLTextBoxnFor(string _CompanyName)
        {
            Companyname = _CompanyName;
        }
        public string selectedDepartmet { get; set; }
        public List<Department> Departments1
        {
            get
            {
                EmployeeBusiness db = new EmployeeBusiness();
                return db.getDepartments().ToList();
            }
        }
    }
}