using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class NoParameterController : Controller
    {
        private readonly ILogger<NoParameterController> _logger;

        public NoParameterController(ILogger<NoParameterController> logger)
        {
            _logger = logger;
        }

        public IActionResult SinglePayment()
        {
            _logger.LogInformation("Create a single payment form");
            return View(new SinglePaymentViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SinglePayment(SinglePaymentViewModel model)
        {
            if(ModelState.IsValid)
            {
                var paymentModel = new PaymentFormModel
                {
                    PaymentUrl = model.PaymentUrl,
                    SiteId = model.SiteId,
                    TransactionId = string.Join("", Guid.NewGuid().ToString("n").Take(6).Select(s => s)),
                    Currency = "978",
                    Amount = model.Amount,
                    Mode = "INTERACTIVE",
                    Delay = "0",
                    Context = "TEST",
                    PageAction = "PAYMENT",
                    Config = "SINGLE",
                    TransactionDate = DateTime.UtcNow.ToString("yyyyMMddHHmmss"),
                    ValidationMode = "0",
                    ReturnMode = "POST",
                    ApiKey = model.ApiKey
                };
                return RedirectToAction("Index", "Payment",  paymentModel);
            }
            return View();
        }
    }
}
