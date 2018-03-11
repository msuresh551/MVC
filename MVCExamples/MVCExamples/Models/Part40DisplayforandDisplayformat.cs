using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCExamples.Models;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

namespace MVCExamples.Models
{
    public class Part40DisplayforandDisplayformat
    {

    }
    [MetadataType(typeof(EmployeeMetadata))]
    [DisplayColumn("Name")]
    public partial class Employee
    {

    }
    public class EmployeeMetadata
    {
        [StringLength(10,ErrorMessage ="String should be max 10 chars")]
        [Required]
        [DisplayAttribute(Name = "Full Name")]
        public string Name { get; set; }
        [Display(Name = "Department ID")]
        public Nullable<int> DepartmentID { get; set; }

        //[ScaffoldColumn(false)]
        [HiddenInput(DisplayValue = false)]
        public int EmpID { get; set; }
        [DisplayFormat(NullDisplayText = "Gender Not Specified")]
        [ReadOnly(true)]
        public string Gender { get; set; }
        [DataType(DataType.Currency)]
        public string Salary { get; set; }
        [DataType(DataType.Url)]
        [UIHint("OpenInNewWindow")]
        public string PersonnelWebSite { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("Date of Join")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime? Dateofjoin { get; set; }
    }
}