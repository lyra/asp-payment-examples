using core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using web.Models;

namespace web.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ILogger<PaymentController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IPaymentService _paymentService;

        public PaymentController(ILogger<PaymentController> logger, IConfiguration configuration, IPaymentService paymentService)
        {
            _logger = logger;
            _configuration = configuration;
            _paymentService = paymentService;
        }


        public IActionResult ConfigureSinglePayment()
        {
            _logger.LogInformation("Configure the single payment form");
            return View(new SinglePaymentViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfigureSinglePayment(SinglePaymentViewModel model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("MakeSinglePayment", "Payment", new { amount = model.Amount });
            }
            return View(model);
        }

        public IActionResult MakeSinglePayment(string amount)
        {
            var model = new PaymentViewModel();
            if (_configuration["paymentUrl"] == null)
            {
                return RedirectToAction("Index", "Error");
            }
            model.PaymentUrl = _configuration["paymentUrl"]!;

            model.PaymentForm = _paymentService.CreateSinglePaymentForm(amount);
            return View(model);
        }
    }
}
