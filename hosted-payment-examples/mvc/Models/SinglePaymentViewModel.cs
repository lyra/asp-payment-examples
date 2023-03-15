using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace mvc.Models
{
    public class SinglePaymentViewModel
    {
        [Display(Name = "Site id", Prompt = "12345678")]
        [Required(ErrorMessage = "A site id is required")]
        [MaxLength(8, ErrorMessage = "This site id is too long. A site id is only 8 digits long")]
        public string SiteId { get; set; } = string.Empty;

        [Display(Name = "Amount", Prompt = "4525 for EUR 45.25")]
        [Required(ErrorMessage = "An amount is required")]
        public string Amount { get; set; } = string.Empty;

        [Display(Name = "Payment url", Prompt = "https://sogecommerce.societegenerale.eu/vads-payment/")]
        [Required(ErrorMessage = "A payment url is required")]
        public string PaymentUrl { get; set; } = string.Empty;

        [Display(Name = "Api key")]
        [Required(ErrorMessage = "A development api key is required")]
        public string ApiKey { get; set; } = string.Empty;
    }
}
