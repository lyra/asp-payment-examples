using core.Interfaces;
using core.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using web.Models;

namespace web.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ILogger<PaymentController> _logger;
        private IPaymentService _paymentService;

        public PaymentController(ILogger<PaymentController> logger, IPaymentService paymentService)
        {
            _logger = logger;
            _paymentService = paymentService;
        }

        public IActionResult ConfigureSinglePayment()
        {
            _logger.LogInformation("Configure the single payment form");
            return View(new ConfigurationViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfigureSinglePayment(ConfigurationViewModel model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("MakeSinglePayment", "Payment", new { apiKey = model.ApiKey, paymentUrl = model.PaymentUrl, siteId = model.SiteId, amount = model.Amount });
            }
            return View(model);
        }

        public IActionResult MakeSinglePayment(string apiKey, string paymentUrl, string siteId, string amount)
        {
            var paymentModel = new PaymentFormModel
            {
                SiteId = siteId,
                TransactionId = string.Join("", Guid.NewGuid().ToString("n").Take(6).Select(s => s)),
                Currency = "978",
                Amount = amount,
                Mode = "INTERACTIVE",
                Delay = "0",
                Context = "TEST",
                Action = "PAYMENT",
                Config = "SINGLE",
                TransactionDate = DateTime.UtcNow.ToString("yyyyMMddHHmmss"),
                ValidationMode = "0",
                ReturnMode = "POST"
            };
            paymentModel.Signature = _paymentService.SignPayment(apiKey, paymentModel);
            var model = new PaymentViewModel();
            model.PaymentForm = _paymentService.CreateSinglePayment(apiKey, siteId, amount);
            model.PaymentUrl = paymentUrl;
            return View(model);
        }
    }
}
