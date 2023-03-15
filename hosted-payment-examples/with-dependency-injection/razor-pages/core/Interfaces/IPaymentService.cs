using core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Interfaces
{
    public interface IPaymentService
    {
        Dictionary<string, string> CreateSinglePayment(string apiKey, string siteId, string amount);
        string SignPayment(string apiKey, PaymentFormModel paymentForm);
        Dictionary<string, string> CreatePaymentFormWithParameters(PaymentFormModel model);
    }
}
