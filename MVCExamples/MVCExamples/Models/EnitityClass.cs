﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCExamples.Models
{
    [Table("Emps")]
    public class EnitityClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}