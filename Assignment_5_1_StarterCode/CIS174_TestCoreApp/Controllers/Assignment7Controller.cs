using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class Assignment7Controller : Controller
    {

        public IActionResult Index()
        {
            //the book says nothing about initializing this and it took hours to find the problem.
            var model = new CreatePersonViewModel();
            model.Country = "";
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(CreatePersonViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index", "Assigntment7");
        }
    }
}