using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using System.Diagnostics;

namespace mvc.Controllers
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
            _logger.LogInformation("Access to the home page");
            return View();
        }
    }
}