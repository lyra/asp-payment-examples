using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class PrivacyController : Controller
    {
        private readonly ILogger<PrivacyController> _logger;

        public PrivacyController(ILogger<PrivacyController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Viewing the privacy policy page");
            return View();
        }
    }
}
