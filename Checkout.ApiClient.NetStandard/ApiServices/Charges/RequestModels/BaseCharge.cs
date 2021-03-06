using Checkout.ApiServices.RecurringPayments.RequestModels;
using Checkout.ApiServices.SharedModels;
using System.Collections.Generic;
namespace Checkout.ApiServices.Charges.RequestModels
{
    public class BaseCharge : BaseChargeInfo
    {
        private const string Yes = "Y";

        public string Value { get; set; }
        public string Currency { get; set; }
        public int ChargeMode { get; set; } = 1; // Default mode is no 3D
        public string AutoCapture { get; set; } = Yes;
        public decimal AutoCapTime { get; set; }
        public string CustomerIp { get; set; }
        public string Email { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string RedirectUrl { get; set; }
        public List<Product> Products { get; set; }
        public Address BillingDetails { get; set; }
        public Address ShippingDetails { get; set; }
        public BillingDescriptor Descriptor { get; set; }
        public bool? RiskCheck { get; set; }
        public string SuccessUrl { get; set; }
        public string FailUrl { get; set; }
    }
}
