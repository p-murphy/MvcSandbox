using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcSandbox.Controllers
{
    public class Projects : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdvancedLearner()
        {
            return View();
        }

        public IActionResult CanvasWrite()
        {
            return View();
        }

        public IActionResult AnimalAdventure()
        {
            return View();
        }

        public IActionResult ArchitecturalVisualization()
        {
            return View();
        }
    }
}
