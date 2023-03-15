using core.Interfaces;
using core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web;

namespace web.Pages.noParameters
{
    public class MakeSinglePaymentModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string ApiKey { get; set; } = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string PaymentUrl { get; set; } = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string SiteId { get; set; } = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string Amount { get; set; } = string.Empty;

        [BindProperty]
        public Dictionary<string, string> PaymentForm { get; set; } = null!;

        private readonly IPaymentService _paymentService;

        public MakeSinglePaymentModel(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void OnGet()
        {
            var paymentModel = new PaymentFormModel
            {
                SiteId = SiteId,
                TransactionId = string.Join("", Guid.NewGuid().ToString("n").Take(6).Select(s => s)),
                Currency = "978",
                Amount = Amount,
                Mode = "INTERACTIVE",
                Delay = "0",
                Context = "TEST",
                Action = "PAYMENT",
                Config = "SINGLE",
                TransactionDate = DateTime.UtcNow.ToString("yyyyMMddHHmmss"),
                ValidationMode = "0",
                ReturnMode = "POST"
            };
            paymentModel.Signature = _paymentService.SignPayment(ApiKey, paymentModel);
            PaymentForm = _paymentService.CreateSinglePayment(ApiKey, SiteId, Amount);
            PaymentUrl = HttpUtility.UrlDecode(PaymentUrl);
        }
    }
}
