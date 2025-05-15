using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]

        public IActionResult User()
        {
            _logger.LogInformation("User action called {m}", Request.Method);
            return Content("User: ");
        }

        [HttpPost]
        public IActionResult User(string userid)
        {
            _logger.LogInformation("User action called userid:  {m}", Request.Method);
            return Content("UserID: " + userid);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
