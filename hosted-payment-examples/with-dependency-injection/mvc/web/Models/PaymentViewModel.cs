namespace web.Models
{
    public class PaymentViewModel
    {
        public Dictionary<string, string> PaymentForm { get; set; } = null!;
        public string PaymentUrl { get; set; } = string.Empty;
    }
}
