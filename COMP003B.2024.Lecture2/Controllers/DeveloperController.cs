using Microsoft.AspNetCore.Mvc;

namespace COMP003B._2024.Lecture2_.Controllers
{
    public class DeveloperController : Controller
    {
        //GET "Developer/Index"
        public IActionResult Index()
        {
            return View();
        }

        // Get "Developer/AboutMe"
        public IActionResult AboutMe()
        {
            return View();
        }
    }
}
