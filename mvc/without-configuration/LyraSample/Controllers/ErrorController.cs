using Microsoft.AspNetCore.Mvc;

namespace LyraSample.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
