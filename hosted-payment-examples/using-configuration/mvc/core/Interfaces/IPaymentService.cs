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
        Dictionary<string, string> CreateSinglePaymentForm(string amount);
        string SignPayment(PaymentFormModel paymentForm);
        Dictionary<string, string> CreatePaymentFormWithParameters(PaymentFormModel model);
    }
}
