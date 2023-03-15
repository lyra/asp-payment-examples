using core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace web.Pages.Payment
{
    public class SingleModel : PageModel
    {
        [BindProperty]
        public Dictionary<string, string> PaymentForm { get; set; } = null!;

        [BindProperty]
        public string PaymentUrl { get; set; } = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string Amount { get; set; } = string.Empty;

        private readonly IConfiguration _configuration;
        private readonly IPaymentService _paymentService;

        public SingleModel(IConfiguration configuration, IPaymentService paymentService)
        {
            _configuration = configuration;
            _paymentService = paymentService;
        }

        public IActionResult OnGet()
        {
            if (_configuration["paymentUrl"] == null)
            {
                return RedirectToPage("/Error");
            }
            PaymentUrl = _configuration["paymentUrl"]!;

            PaymentForm = _paymentService.CreateSinglePaymentForm(Amount);
            return Page();
        }
    }
}
