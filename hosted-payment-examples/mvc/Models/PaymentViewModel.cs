using Microsoft.AspNetCore.Mvc;

namespace mvc.Models
{
    public class PaymentViewModel
    {
        public string PaymentUrl { get; set; } = string.Empty;

        public Dictionary<string, string> PaymentForm { get; set; } = null!;
    }
}
