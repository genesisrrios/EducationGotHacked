using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EducationGotHacked.Controllers
{
    public class StudentGradesController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}