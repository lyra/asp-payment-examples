using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using System.Security.Cryptography;
using System.Text;

namespace mvc.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(PaymentFormModel formModel)
        {
            _logger.LogInformation("Initiate a payment");
            if (string.IsNullOrEmpty(formModel.PaymentUrl))
            {
                return RedirectToAction("Index", "Error");
            }
            var model = new PaymentViewModel();
            model.PaymentUrl = formModel.PaymentUrl;
            formModel.Signature = CalculateSignature(formModel);
            model.PaymentForm = CreateParameters(formModel);
            return View(model);
        }

        private string CalculateSignature(PaymentFormModel model)
        {
            var encodingKey = Encoding.UTF8.GetBytes(model.ApiKey);
            var signatureParameters = new StringBuilder();
            var parametersFromClass = CreateParameters(model).OrderBy(x => x.Key);
            foreach (var parameter in parametersFromClass)
            {
                signatureParameters.Append(parameter.Value);
                signatureParameters.Append("+");
            }
            signatureParameters.Append(model.ApiKey);
            var signatureBytes = Encoding.UTF8.GetBytes(signatureParameters.ToString());
            var cryptoKey = new HMACSHA256(encodingKey);
            var signatureHash = cryptoKey.ComputeHash(signatureBytes);
            var signatureBase64String = Convert.ToBase64String(signatureHash);
            return signatureBase64String;

        }

        private Dictionary<string, string> CreateParameters(PaymentFormModel model)
        {
            var parameters = new Dictionary<string, string>();
            var properties = model.GetType().GetProperties().ToList();
            foreach (var property in properties)
            {
                var propertyValue = property.GetValue(model);
                if (propertyValue != null && !string.IsNullOrEmpty(propertyValue!.ToString()))
                {
                    switch (property.Name)
                    {
                        case "Mode":
                            parameters.Add("vads_action_mode", property.GetValue(model)!.ToString()!);
                            break;
                        case "Amount":
                            parameters.Add("vads_amount", property.GetValue(model)!.ToString()!);
                            break;
                        case "Delay":
                            parameters.Add("vads_capture_delay", property.GetValue(model)!.ToString()!);
                            break;
                        case "Context":
                            parameters.Add("vads_ctx_mode", property.GetValue(model)!.ToString()!);
                            break;
                        case "Currency":
                            parameters.Add("vads_currency", property.GetValue(model)!.ToString()!);
                            break;
                        case "OrderId":
                            parameters.Add("vads_order_id", property.GetValue(model)!.ToString()!);
                            break;
                        case "OrderInfo":
                            parameters.Add("vads_order_info", property.GetValue(model)!.ToString()!);
                            break;
                        case "OrderInfo2":
                            parameters.Add("vads_order_info2", property.GetValue(model)!.ToString()!);
                            break;
                        case "OrderInfo3":
                            parameters.Add("vads_order_info3", property.GetValue(model)!.ToString()!);
                            break;
                        case "PageAction":
                            parameters.Add("vads_page_action", property.GetValue(model)!.ToString()!);
                            break;
                        case "Card":
                            parameters.Add("vads_payment_cards", property.GetValue(model)!.ToString()!);
                            break;
                        case "Config":
                            parameters.Add("vads_payment_config", property.GetValue(model)!.ToString()!);
                            break;
                        case "SiteId":
                            parameters.Add("vads_site_id", property.GetValue(model)!.ToString()!);
                            break;
                        case "TransactionDate":
                            parameters.Add("vads_trans_date", property.GetValue(model)!.ToString()!);
                            break;
                        case "TransactionId":
                            parameters.Add("vads_trans_id", property.GetValue(model)!.ToString()!);
                            break;
                        case "Version":
                            parameters.Add("vads_version", property.GetValue(model)!.ToString()!);
                            break;
                        case "ValidationMode":
                            parameters.Add("vads_validation_mode", property.GetValue(model)!.ToString()!);
                            break;
                        case "ReturnMode":
                            parameters.Add("vads_return_mode", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerEmail":
                            parameters.Add("vads_cust_email", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerFirstname":
                            parameters.Add("vads_cust_first_name", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerLastname":
                            parameters.Add("vads_cust_last_name", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerId":
                            parameters.Add("vads_cust_id", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerNationalId":
                            parameters.Add("vads_cust_national_id", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerTitle":
                            parameters.Add("vads_cust_title", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerStatus":
                            parameters.Add("vads_cust_status", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerLegalName":
                            parameters.Add("vads_cust_legal_name", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerPhone":
                            parameters.Add("vads_cust_phone", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerMobilePhone":
                            parameters.Add("vads_cust_phone_cell", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerAddressNumber":
                            parameters.Add("vads_cust_address_number", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerAddress":
                            parameters.Add("vads_cust_address", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerAddressComplementary":
                            parameters.Add("vads_cust_address2", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerAddressDistrict":
                            parameters.Add("vads_cust_district", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerAddressPostalCode":
                            parameters.Add("vads_cust_zip", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerAddressCity":
                            parameters.Add("vads_cust_city", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerAddressState":
                            parameters.Add("vads_cust_state", property.GetValue(model)!.ToString()!);
                            break;
                        case "CustomerAddressCountry":
                            parameters.Add("vads_cust_country", property.GetValue(model)!.ToString()!);
                            break;
                        case "ShipmentCity":
                            parameters.Add("vads_ship_to_city", property.GetValue(model)!.ToString()!);
                            break;
                        case "ShipmentDistrict":
                            parameters.Add("vads_ship_to_district", property.GetValue(model)!.ToString()!);
                            break;
                        case "ShipmentFirstname":
                            parameters.Add("vads_ship_to_first_name", property.GetValue(model)!.ToString()!);
                            break;
                        case "ShipmentLastname":
                            parameters.Add("vads_ship_to_last_name", property.GetValue(model)!.ToString()!);
                            break;
                        case "ShipmentPhone":
                            parameters.Add("vads_ship_to_phone_num", property.GetValue(model)!.ToString()!);
                            break;
                        case "ShipmentState":
                            parameters.Add("vads_ship_to_state", property.GetValue(model)!.ToString()!);
                            break;
                        case "ShipmentType":
                            parameters.Add("vads_ship_to_type", property.GetValue(model)!.ToString()!);
                            break;
                        case "ShipmentAddressNumber":
                            parameters.Add("vads_ship_to_street_number", property.GetValue(model)!.ToString()!);
                            break;
                        case "ShipmentAddress":
                            parameters.Add("vads_ship_to_street", property.GetValue(model)!.ToString()!);
                            break;
                        case "ShipmentAddressComplementary":
                            parameters.Add("vads_ship_to_street2", property.GetValue(model)!.ToString()!);
                            break;
                        case "ShipmentAddressPostalCode":
                            parameters.Add("vads_ship_to_zip", property.GetValue(model)!.ToString()!);
                            break;
                        case "Signature":
                            parameters.Add("signature", property.GetValue(model)!.ToString()!);
                            break;
                    }
                }
            }
            return parameters;
        }
    }
}
