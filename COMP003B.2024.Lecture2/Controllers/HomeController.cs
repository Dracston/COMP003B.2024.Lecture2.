using COMP003B._2024.Lecture2_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace COMP003B._2024.Lecture2_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //GET "Homes/ Index

        public IActionResult Index()
        {
            return View();
        }
        //GET "Home/ Privacy"
        public IActionResult Privacy()
        {
            return View();
        }
        //GET 
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
