using System.ComponentModel.DataAnnotations;

namespace LyraSample.ViewModels
{
    public class RedirectedFormViewModel
    {
        [Display(Name = "Shop ID", Prompt = "12345678")]
        public string ShopID { get; set; } = string.Empty;

        [Display(Name = "Transaction ID", Prompt = "xrT15p")]
        public string TransactionID { get; set; } = string.Empty;

        [Display(Name = "Transaction date", Prompt = "20200101130025")]
        public string TransactionDate { get; set; } = string.Empty;

        [Display(Name = "Amount", Prompt = "4525 for EUR 45.25")]
        public double Amount { get; set; }

        [Display(Name = "Currency", Prompt = "978 for euro (EUR)")]
        public string Currency { get; set; } = string.Empty;

        [Display(Name = "Action mode", Prompt = "INTERACTIVE")]
        public string ActionMode { get; set; } = string.Empty;

        [Display(Name = "Page action", Prompt = "PAYMENT")]
        public string PageAction { get; set; } = string.Empty;

        [Display(Name = "Version", Prompt = "V2")]
        public string Version { get; set; } = string.Empty;

        [Display(Name = "Payment type", Prompt = "SINGLE")]
        public string PaymentConfig { get; set; } = string.Empty;

        [Display(Name = "Payment cards", Prompt = "CB")]
        public string PaymentCards { get; set; } = string.Empty;

        [Display(Name = "Capture Delay", Prompt = "0")]
        public string CaptureDelay { get; set; } = string.Empty;
    }
}
