using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EducationGotHacked.Controllers
{
    public class TechnologyController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult K12()
        {

            return View();
        }
        public IActionResult FirstGrade()
        {

            return View();
        }
        public IActionResult ThirdGrade()
        {

            return View();
        }
        public IActionResult PCAssembly()
        {

            return View();
        }
    }
}