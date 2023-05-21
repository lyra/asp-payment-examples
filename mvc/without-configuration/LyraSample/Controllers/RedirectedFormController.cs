using LyraSample.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LyraSample.Controllers
{
    public class RedirectedFormController : Controller
    {
        public IActionResult Index()
        {
            var model = new RedirectedFormViewModel();
            return View(model);
        }
    }
}
