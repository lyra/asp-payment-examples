using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
        [Display(Name = "Transaction id", Prompt = "xrT15p")]
        public string TransactionId { get; set; } = string.Empty;

        [BindProperty]
        [Display(Name = "Amount", Prompt = "4525 for EUR 45.25")]
        [Required(ErrorMessage = "An amount is required")]
        public int Amount { get; set; }

        [BindProperty]
        [Display(Name = "Payment url", Prompt = "https://sogecommerce.societegenerale.eu/vads-payment/")]
        [Required(ErrorMessage = "A payment url is required")]
        public string PaymentUrl { get; set; } = string.Empty;
        public void OnGet()
        {
        }
    }
}
