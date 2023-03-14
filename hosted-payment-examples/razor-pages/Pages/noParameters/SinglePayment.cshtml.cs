using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pages.Models;
using System.ComponentModel.DataAnnotations;

namespace razor_pages.Pages.noParameters
{
    public class SinglePaymentModel : PageModel
    {
        [BindProperty]
        [Display(Name = "Site id", Prompt = "12345678")]
        [Required(ErrorMessage = "A site id is required")]
        [MaxLength(8, ErrorMessage = "This site id is too long. A site id is only 8 digits long")]
        public string SiteId { get; set; } = string.Empty;

        [BindProperty]
        [Display(Name = "Amount", Prompt = "4525 for EUR 45.25")]
        [Required(ErrorMessage = "An amount is required")]
        public string Amount { get; set; } = string.Empty;

        [BindProperty]
        [Display(Name = "Payment url", Prompt = "https://sogecommerce.societegenerale.eu/vads-payment/")]
        [Required(ErrorMessage = "A payment url is required")]
        public string PaymentUrl { get; set; } = string.Empty;

        [BindProperty]
        [Display(Name = "Api key")]
        [Required(ErrorMessage = "A development api key is required")]
        public string ApiKey { get; set; } = string.Empty;
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var paymentModel = new PaymentFormModel
            {
                PaymentUrl = PaymentUrl,
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
                ReturnMode = "POST",
                ApiKey = ApiKey
            };
            return RedirectToPage("/Payment",paymentModel);
        }
    }
}
