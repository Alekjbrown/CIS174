using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CIS174_TestCoreApp.Controllers
{
    public class AssignmentController : Controller
    {
        private List<Models.Student> students = new List<Models.Student>()
        {
            new Models.Student{FirstName="Shea",LastName="Brown",Grade=9},
            new Models.Student{FirstName="Seth",LastName="Brown",Grade=5},
            new Models.Student{FirstName="Evalyn",LastName="Follet",Grade=1},
            new Models.Student{FirstName="Bernie",LastName="Sanders",Grade=50}
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Assignment6(int AccessLevel)
        {
            ViewBag.AccessLevel = AccessLevel;
            return View(students);
        }
    }
}