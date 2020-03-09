using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class Student
    {
        [Display(Name = "FirstName")]
        public String FirstName { get; set; }

        public String LastName { get; set; }
        public int Grade { get; set; }
    }
}
