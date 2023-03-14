namespace razor_pages.Models
{
    public class PaymentFormModel
    {
        /// <summary>
        /// vads_action_mode
        /// </summary>
        public string Mode { get; set; } = string.Empty;
        /// <summary>
        /// vads_amount
        /// </summary>
        public string Amount { get; set; } = string.Empty;
        /// <summary>
        /// vads_capture_delay
        /// </summary>
        public string Delay { get; set; } = string.Empty;
        /// <summary>
        /// vads_ctx_mode
        /// </summary>
        public string Context { get; set; } = string.Empty;
        /// <summary>
        /// vads_currency
        /// </summary>
        public string Currency { get; set; } = string.Empty;
        /// <summary>
        /// vads_order_id
        /// </summary>
        public string OrderId { get; set; } = string.Empty;
        /// <summary>
        /// vads_order_info
        /// Add additionnal information to the payment, ex: Code interphone 1234
        /// </summary>
        public string OrderInfo { get; set; } = string.Empty;
        /// <summary>
        /// vads_order_info2
        /// Add another additionnal information to the payment, ex: Sans ascenseur
        /// </summary>
        public string OrderInfo2 { get; set; } = string.Empty;
        /// <summary>
        /// vads_order_info3
        /// Add another additionnal information to the payment, ex: Prioritaire
        /// </summary>
        public string OrderInfo3 { get; set; } = string.Empty;
        public string EmailAdditionalInformation { get; set; } = string.Empty;
        /// <summary>
        /// vads_page_action
        /// </summary>
        public string Action { get; set; } = string.Empty;
        /// <summary>
        /// vads_payment_cards
        /// </summary>
        public string Card { get; set; } = string.Empty;
        /// <summary>
        /// vads_payment_config
        /// </summary>
        public string Config { get; set; } = string.Empty;
        /// <summary>
        /// vads_site_id
        /// </summary>
        public string SiteId { get; set; } = string.Empty;
        /// <summary>
        /// vads_trans_date
        /// </summary>
        public string TransactionDate { get; set; } = string.Empty;
        /// <summary>
        /// vads_trans_id
        /// </summary>
        public string TransactionId { get; set; } = string.Empty;
        /// <summary>
        /// vads_version
        /// </summary>
        public string Version { get; set; } = "V2";
        /// <summary>
        /// vads_validation_mode
        /// </summary>
        public string ValidationMode { get; set; } = string.Empty;
        /// <summary>
        /// vads_return_mode
        /// </summary>
        public string ReturnMode { get; set; } = string.Empty;
        /// <summary>
        /// signature
        /// </summary>
        public string Signature { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_email
        /// </summary>
        public string CustomerEmail { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_id
        /// </summary>
        public string CustomerId { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_national_id
        /// </summary>
        public string CustomerNationalId { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_title
        /// </summary>
        public string CustomerTitle { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_status
        /// </summary>
        public string CustomerStatus { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_first_name
        /// </summary>
        public string CustomerFirstname { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_last_name
        /// </summary>
        public string CustomerLastname { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_legal_name
        /// </summary>
        public string CustomerLegalName { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_phone
        /// </summary>
        public string CustomerPhone { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_cell_phone
        /// </summary>
        public string CustomerMobilePhone { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_address_number
        /// </summary>
        public string CustomerAddressNumber { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_address
        /// </summary>
        public string CustomerAddress { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_address2
        /// </summary>
        public string CustomerAddressComplementary { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_district
        /// </summary>
        public string CustomerAddressDistrict { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_zip
        /// </summary>
        public string CustomerAddressPostalCode { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_city
        /// </summary>
        public string CustomerAddressCity { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_state
        /// </summary>
        public string CustomerAddressState { get; set; } = string.Empty;
        /// <summary>
        /// vads_cust_country
        /// </summary>
        public string CustomerAddressCountry { get; set; } = string.Empty;
        /// <summary>
        /// vads_ship_to_city
        /// </summary>
        public string ShipmentCity { get; set; } = string.Empty;
        /// <summary>
        /// vads_ship_to_country
        /// </summary>
        public string ShipmentCountry { get; set; } = string.Empty;
        /// <summary>
        /// vads_ship_to_district
        /// </summary>
        public string ShipmentDistrict { get; set; } = string.Empty;
        /// <summary>
        /// vads_ship_to_first_name
        /// </summary>
        public string ShipmentFirstname { get; set; } = string.Empty;
        /// <summary>
        /// vads_ship_to_last_name
        /// </summary>
        public string ShipmentLastname { get; set; } = string.Empty;
        /// <summary>
        /// vads_ship_to_phone_num
        /// </summary>
        public string ShipmentPhone { get; set; } = string.Empty;
        /// <summary>
        /// vads_ship_to_state
        /// </summary>
        public string ShipmentState { get; set; } = string.Empty;
        /// <summary>
        /// vads_ship_to_type
        /// </summary>
        public string ShipmentType { get; set; } = string.Empty;
        /// <summary>
        /// vads_ship_to_street_number
        /// </summary>
        public string ShipmentAddressNumber { get; set; } = string.Empty;
        /// <summary>
        /// vads_ship_to_street
        /// </summary>
        public string ShipmentAddress { get; set; } = string.Empty;
        /// <summary>
        /// vads_ship_to_street2
        /// </summary>
        public string ShipmentAddressComplementary { get; set; } = string.Empty;
        /// <summary>
        /// vads_ship_to_zip
        /// </summary>
        public string ShipmentAddressPostalCode { get; set; } = string.Empty;

        /// <summary>
        /// The url ending by vads-payment from your bank
        /// </summary>
        public string PaymentUrl { get; set; } = string.Empty;

        /// <summary>
        /// Payment api key
        /// </summary>
        public string ApiKey { get; set; } = string.Empty;
    }
}
