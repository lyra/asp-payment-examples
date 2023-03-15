using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace web.Models
{
    public class SinglePaymentViewModel
    {
        [Display(Name = "Amount", Prompt = "4525 for EUR 45.25")]
        [Required(ErrorMessage = "An amount is required")]
        public string Amount { get; set; } = string.Empty;
    }
}
